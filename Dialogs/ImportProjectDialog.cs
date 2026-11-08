using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;

namespace GSX_Studio
{
	public partial class ImportProjectDialog : XtraForm
	{
		public void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			bool doReplace = this.ConflictsHandling.Text[0] == 'O';
			e.Result = this.BeginImportsThread(this.Directories, (BackgroundWorker)sender, this.ScriptPath.Text, this.CreatorName.Text, doReplace);
			if (((BackgroundWorker)sender).CancellationPending)
			{
				e.Cancel = true;
			}
		}

		public byte[] BytesFromString(string str)
		{
			List<byte> list = new List<byte>();
			int num = 0;
			if (0 < str.Length)
			{
				do
				{
					list.Add((byte)str[num]);
					num++;
				}
				while (num < str.Length);
			}
			list.Add(0);
			return list.ToArray();
		}

		public void AddProject()
		{
			if (this.Browser.ShowDialog() == DialogResult.OK)
			{
				if (!File.Exists(this.Browser.SelectedPath + Path.DirectorySeparatorChar + "main.gsc"))
				{
					NotifyDialog notifyDialog = new NotifyDialog();
					notifyDialog.Text = "Invalid GSC Studio Project";
					notifyDialog.Message.Text = "No 'main.gsc' file found in this folder. If you meant to add a projects folder, please select the 'Add Projects Folder' option.";
					notifyDialog.ShowDialog();
					if (notifyDialog != null)
					{
						((IDisposable)notifyDialog).Dispose();
					}
				}
				else if (!this.Directories.Contains(this.Browser.SelectedPath))
				{
					this.Directories.Add(this.Browser.SelectedPath);
					this.RefreshProjectsList();
				}
			}
		}

		public void AddProjectsPath()
		{
			if (this.Browser.ShowDialog() == DialogResult.OK)
			{
				List<string> list = new List<string>();
				string[] directories = Directory.GetDirectories(this.Browser.SelectedPath);
				int num = 0;
				if (0 < directories.Length)
				{
					do
					{
						string text = directories[num];
						if (text + Path.DirectorySeparatorChar + "main.gsc" != null)
						{
							list.Add(text);
						}
						num++;
					}
					while (num < directories.Length);
				}
				if (list.Count < 1)
				{
					IDisposable disposable = list as IDisposable;
					if (disposable != null)
					{
						disposable.Dispose();
					}
					NotifyDialog notifyDialog = new NotifyDialog();
					notifyDialog.Text = "No GSC Studio Projects Found";
					notifyDialog.Message.Text = "None of the folders in this directory contain a 'main.gsc'. This folder doesnt appear to contain any valid projects to import. If you meant to select a single project folder, please select 'Add project'";
					notifyDialog.ShowDialog();
					if (notifyDialog != null)
					{
						((IDisposable)notifyDialog).Dispose();
					}
				}
				else
				{
					List<string>.Enumerator enumerator = list.GetEnumerator();
					if (enumerator.MoveNext())
					{
						do
						{
							string item = enumerator.Current;
							if (!this.Directories.Contains(item))
							{
								this.Directories.Add(item);
							}
						}
						while (enumerator.MoveNext());
					}
					this.RefreshProjectsList();
				}
			}
		}

		public void ClearProjects()
		{
			this.Directories.Clear();
			this.RefreshProjectsList();
		}

		public void RemoveSelectedProject()
		{
			if (this.ProjectsList.Selection[0] != null)
			{
				string item = (string)this.ProjectsList.Selection[0].GetValue(0);
				this.Directories.Remove(item);
				this.RefreshProjectsList();
			}
		}

		public void OnTreeMouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				Point location = e.Location;
				Point p = ((Control)sender).PointToScreen(location);
				this.RContextMenu.ShowPopup(p);
			}
		}

		public void RefreshProjectsList()
		{
			this.ProjectsList.BeginUnboundLoad();
			this.ProjectsList.Nodes.Clear();
			List<string>.Enumerator enumerator = this.Directories.GetEnumerator();
			if (enumerator.MoveNext())
			{
				do
				{
					string text = enumerator.Current;
					string[] nodeData = new string[]
					{
						text
					};
					this.ProjectsList.AppendNode(nodeData, -1);
				}
				while (enumerator.MoveNext());
			}
			this.ProjectsList.EndUnboundLoad();
			if (this.Directories.Count > 0)
			{
				this.StartImports.Enabled = true;
			}
			else
			{
				this.StartImports.Enabled = false;
			}
		}

		public void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			if (!e.Cancelled && e.Result != null)
			{
				NotifyDialog notifyDialog = new NotifyDialog();
				notifyDialog.Text = "Success!";
				notifyDialog.Message.Text = "Finished importing all projects!";
				notifyDialog.ShowDialog();
				if (notifyDialog != null)
				{
					((IDisposable)notifyDialog).Dispose();
				}
			}
			this.progressBarControl1.EditValue = 0;
			this.progressBarControl1.Update();
			this.CancelImports.Enabled = false;
			this.CancelImports.Visible = false;
			this.StartImports.Enabled = true;
			this.ProjectsList.Enabled = true;
			this.simpleButton1.Enabled = true;
			this.AddProjects.Enabled = true;
		}

		public void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			if (this.progressBarControl1.Properties.Maximum != (int)e.UserState)
			{
				this.progressBarControl1.Properties.Maximum = (int)e.UserState;
			}
			this.progressBarControl1.PerformStep();
			this.progressBarControl1.Update();
		}

		public List<byte> GetDefaultProjectData()
		{
			List<byte> list = new List<byte>();
			list.Add(1);
			list.Add(2);
			list.Add(1);
			list.AddRange(this.BytesFromString("Created in GSX Studio!"));
			return list;
		}

		public object BeginImportsThread(List<string> directories, BackgroundWorker bgx, string ScriptName, string Creator, [MarshalAs(UnmanagedType.U1)] bool DoReplace)
		{
			int num = 0;
			while (num < directories.Count && !bgx.CancellationPending)
			{
				char[] separator = new char[]
				{
					Path.DirectorySeparatorChar
				};
				string[] array = directories[num].Split(separator);
				string text = array[array.Length - 1];
				string text2 = this.ProjectsLocation + Path.DirectorySeparatorChar + text + Path.DirectorySeparatorChar + text;
				string text3 = text2;
				if (!Directory.Exists(this.ProjectsLocation + Path.DirectorySeparatorChar + text) || DoReplace)
				{
					if (Directory.Exists(this.ProjectsLocation + Path.DirectorySeparatorChar + text))
					{
						DirectoryInfo directoryInfo = new DirectoryInfo(this.ProjectsLocation + Path.DirectorySeparatorChar + text);
						FileInfo[] files = directoryInfo.GetFiles();
						int num2 = 0;
						if (0 < files.Length)
						{
							do
							{
								files[num2].Delete();
								num2++;
							}
							while (num2 < files.Length);
						}
						DirectoryInfo[] directories2 = directoryInfo.GetDirectories();
						int num3 = 0;
						if (0 < directories2.Length)
						{
							do
							{
								directories2[num3].Delete(true);
								num3++;
							}
							while (num3 < directories2.Length);
						}
						if (Directory.Exists(this.ProjectsLocation + Path.DirectorySeparatorChar + text))
						{
							Directory.Delete(this.ProjectsLocation + Path.DirectorySeparatorChar + text);
						}
					}
					Directory.CreateDirectory(this.ProjectsLocation + Path.DirectorySeparatorChar + text);
					Directory.CreateDirectory(text2);
					string[] array2 = ScriptName.Split(new char[]
					{
						'\\'
					});
					int num4 = 0;
					if (0 < array2.Length)
					{
						do
						{
							string text4 = array2[num4];
							if (!Directory.Exists(text3 + Path.DirectorySeparatorChar + text4))
							{
								Directory.CreateDirectory(text3 + Path.DirectorySeparatorChar + text4);
							}
							text3 += Path.DirectorySeparatorChar + text4;
							num4++;
						}
						while (num4 < array2.Length);
					}
					List<string> list = new List<string>();
					string[] files2 = Directory.GetFiles(directories[num], "*.gsc");
					int num5 = 0;
					if (0 < files2.Length)
					{
						do
						{
							string text5 = files2[num5];
							list.Add(text5);
							string sourceFileName = text5;
							string str = text3 + Path.DirectorySeparatorChar;
							string text6 = text5;
							File.Copy(sourceFileName, str + text6.Substring(text6.LastIndexOf(Path.DirectorySeparatorChar) + 1).Replace(".gsc", ".gsx"));
							num5++;
						}
						while (num5 < files2.Length);
					}
					List<byte> list2 = new List<byte>();
					list2.AddRange(new byte[]
					{
						0x25,
						0x47,
						0x53,
						0x58,
						0x50,
						0x25
					});
					list2.AddRange(this.BytesFromString(Creator));
					list2.AddRange(this.BytesFromString(text));
					list2.Add(1);
					list2.AddRange(this.BytesFromString(ScriptName));
					list2.Add((byte)list.Count);
					List<string>.Enumerator enumerator = list.GetEnumerator();
					if (enumerator.MoveNext())
					{
						do
						{
							string text7 = enumerator.Current;
							List<byte> list3 = list2;
							string text8 = text7;
							list3.AddRange(this.BytesFromString(text8.Substring(text8.LastIndexOf(Path.DirectorySeparatorChar) + 1).Replace(".gsc", ".gsx")));
						}
						while (enumerator.MoveNext());
					}
					list2.AddRange(this.GetDefaultProjectData());
					try
					{
						File.WriteAllBytes(this.ProjectsLocation + Path.DirectorySeparatorChar + text + Path.DirectorySeparatorChar + text + ".gsxp", list2.ToArray());
					}
					catch (Exception)
					{
					}
				}
				bgx.ReportProgress(num / directories.Count, directories.Count);
				num++;
			}
			return 1;
		}

		public ImportProjectDialog(string plocation)
		{
			try
			{
				this.ProjectsLocation = plocation;
				this.InitializeComponent();
				FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
				this.Browser = folderBrowserDialog;
				folderBrowserDialog.Description = "Select a Project";
				this.Browser.ShowNewFolderButton = false;
				this.ProjectsList.MouseClick += this.OnTreeMouseClick;
				this.bgw = new BackgroundWorker();
				this.bgw.DoWork += this.BackgroundWorker1_DoWork;
				this.bgw.WorkerReportsProgress = true;
				this.bgw.WorkerSupportsCancellation = true;
				this.bgw.RunWorkerCompleted += this.BackgroundWorker1_RunWorkerCompleted;
				this.bgw.ProgressChanged += this.BackgroundWorker1_ProgressChanged;
			}
			catch
			{
				base.Dispose(true);
				throw;
			}
		}

		private void CleanupManaged()
		{
			IContainer container = this.components;
			if (container != null)
			{
				container.Dispose();
			}
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			this.AddProject();
		}

		private void AddProjects_Click(object sender, EventArgs e)
		{
			this.AddProjectsPath();
		}

		private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
		{
			this.ClearProjects();
		}

		private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
		{
			this.RemoveSelectedProject();
		}

		private void StartImports_Click(object sender, EventArgs e)
		{
			this.CancelImports.Enabled = true;
			this.CancelImports.Visible = true;
			this.StartImports.Enabled = false;
			this.ProjectsList.Enabled = false;
			this.simpleButton1.Enabled = false;
			this.AddProjects.Enabled = false;
			this.bgw.RunWorkerAsync();
		}

		private void CancelImports_Click(object sender, EventArgs e)
		{
			this.bgw.CancelAsync();
			this.CancelImports.Enabled = false;
			this.CancelImports.Visible = false;
			this.StartImports.Enabled = true;
			this.ProjectsList.Enabled = true;
			this.simpleButton1.Enabled = true;
			this.AddProjects.Enabled = true;
		}

		public FolderBrowserDialog Browser;

		public BackgroundWorker bgw;

		public List<string> Directories = new List<string>();

		public string ProjectsLocation;
	}
}
