using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraSpellChecker;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using FastColoredTextBoxNS;
using GSXCompilerLib;
using GSXCompilerLib.GSC;
using Irony.Parsing;
using Microsoft.Win32;
using XParserLib;

namespace GSX_Studio
{
	public class IDE
	{
		public RichEditControl GetNewDefaultEditor(string A_0, IDE A_1)
		{
			RichEditControl richEditControl = new RichEditControl();
			richEditControl.ActiveViewType = RichEditViewType.Simple;
			richEditControl.Appearance.Text.Font = new Font("Consolas", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			richEditControl.Appearance.Text.Options.UseFont = true;
			richEditControl.Dock = DockStyle.Fill;
			richEditControl.EnableToolTips = true;
			Point location = new Point(0, 0);
			richEditControl.Location = location;
			richEditControl.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
			richEditControl.LookAndFeel.UseDefaultLookAndFeel = false;
			richEditControl.Name = "DocTemplate";
			richEditControl.Options.AutoCorrect.ReplaceTextAsYouType = false;
			richEditControl.Options.Behavior.Printing = DocumentCapability.Disabled;
			richEditControl.Options.Behavior.Save = DocumentCapability.Disabled;
			richEditControl.Options.Behavior.SaveAs = DocumentCapability.Disabled;
			richEditControl.Options.Behavior.ShowPopupMenu = DocumentCapability.Disabled;
			richEditControl.Options.DocumentCapabilities.FloatingObjects = DocumentCapability.Disabled;
			richEditControl.Options.DocumentCapabilities.FootNotes = DocumentCapability.Disabled;
			richEditControl.Options.DocumentCapabilities.HeadersFooters = DocumentCapability.Disabled;
			richEditControl.Options.DocumentCapabilities.InlinePictures = DocumentCapability.Disabled;
			richEditControl.Options.SpellChecker.AutoDetectDocumentCulture = false;
			richEditControl.Options.DocumentCapabilities.Bookmarks = DocumentCapability.Disabled;
			richEditControl.Options.HorizontalScrollbar.Visibility = RichEditScrollbarVisibility.Visible;
			richEditControl.Options.VerticalScrollbar.Visibility = RichEditScrollbarVisibility.Visible;
			richEditControl.ReadOnly = false;
			Size size = new Size(0x30A, 0x14A);
			richEditControl.Size = size;
			richEditControl.TabIndex = 0;
			richEditControl.Views.SimpleView.AllowDisplayLineNumbers = true;
			Color backColor = Color.FromArgb(0x1E, 0x1E, 0x1E);
			richEditControl.Views.SimpleView.BackColor = backColor;
			richEditControl.Views.SimpleView.Padding = new DevExpress.Portable.PortablePadding(0x46, 4, 0, 0);
			richEditControl.Views.SimpleView.WordWrap = false;
			richEditControl.Document.Sections[0].LineNumbering.RestartType = LineNumberingRestart.Continuous;
			richEditControl.Document.Sections[0].LineNumbering.Start = 1;
			richEditControl.Document.Sections[0].LineNumbering.CountBy = 1;
			richEditControl.Document.Sections[0].LineNumbering.Distance = 0.1f;
			richEditControl.Document.InsertText(richEditControl.Document.CaretPosition, A_0);
			richEditControl.Document.CaretPosition = richEditControl.Document.Range.Start;
			if (richEditControl.SpellChecker != null)
			{
				richEditControl.SpellChecker.SpellCheckMode = SpellCheckMode.OnDemand;
			}
			return richEditControl;
		}

		internal void Print(string A_0, string A_1)
		{
			IDE.Print(A_0, A_1, this.DOutput);
		}

		public static void Print(string A_0, string A_1, RichEditControl A_2)
		{
			DateTime now = DateTime.Now;
			A_2.Document.InsertText(A_2.Document.Range.End, "[" + now.ToShortTimeString() + "] " + A_1 + ": " + A_0 + "\n");
			A_2.Document.CaretPosition = A_2.Document.Range.End;
			A_2.ScrollToCaret();
		}

		public static XParseLanguage GetNewGSXHandle()
		{
			XParseLanguage xparseLanguage = new XParseLanguage("Black Ops II - GSX Version 1");
			XParseLanguage.DefineLanguage a_ = new XParseLanguage.DefineLanguage(IDE.DefineGSX);
			xparseLanguage.SealLanguage(a_);
			return xparseLanguage;
		}

		public static XLNonTerminal DefineGSX()
		{
			return XLNonTerminal.GetDefaultProgram();
		}

		public static void ClearConsole(RichEditControl A_0)
		{
			A_0.Text = "";
			IDE.Print("Console Cleared", "Notification", A_0);
		}

		public IDE(RichEditControl dout, TreeList derror, TreeList explorer, TabbedView docmanager, DockManager dockmanager)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			this.GSXProjectSelector = openFileDialog;
			openFileDialog.Filter = "GSX Project File|*.gsxp";
			this.GSXProjectSelector.Multiselect = false;
			this.DOutput = dout;
			this.ProjectsLocation = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + Path.DirectorySeparatorChar + "Black Ops II - GSX Projects";
			this.DError = derror;
			this.Explorer = explorer;
			this.DocumentManager = docmanager;
			this.DockingManager = dockmanager;
			this.Explorer.FocusedNodeChanged += this.OnFocusedNodeChanged;
			XParseLanguage newGSXHandle = IDE.GetNewGSXHandle();
			this.LanguageDefinition = newGSXHandle;
			this.ParserHandle = new XParser(newGSXHandle);
			this.Explorer.MouseClick += this.ExplorerOnMouseClick;
			this.Explorer.MouseDoubleClick += this.OnMouseDoubleClick;
			this.DocumentManager.DocumentActivated += this.OnDMDocumentActivated;
			this.DocumentManager.DocumentProperties.AllowFloat = false;
			this.DocumentManager.DocumentAdded += this.OnDocumentAdded;
			this.DocumentManager.BeginDocumentsHostDocking += this.OnDMBeginDocumentsHostDocking;
			this.DocumentManager.BeginDocking += this.OnDMBeginDocking;
			this.EditorImagesList = new ImageList();
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Method_purple_64x.png");
			this.EditorImagesList.Images.Add(Image.FromStream(manifestResourceStream));
			manifestResourceStream.Close();
			Stream manifestResourceStream2 = Assembly.GetExecutingAssembly().GetManifestResourceStream("IntelliSenseKeyword_16x.png");
			this.EditorImagesList.Images.Add(Image.FromStream(manifestResourceStream2));
			manifestResourceStream2.Close();
			this.GSXParser = Intellisense.GetGSXParser();
			BackgroundWorker backgroundWorker = new BackgroundWorker();
			this.CompilationWorker = backgroundWorker;
			backgroundWorker.WorkerReportsProgress = true;
			this.CompilationWorker.WorkerSupportsCancellation = true;
			this.CompilationWorker.DoWork += this.OnCWDoWork;
			this.CompilationWorker.RunWorkerCompleted += this.OnCWRunWorkerCompleted;
			this.CompilationWorker.ProgressChanged += this.OnCWProgressChanged;
			this.RepairWorker = new BackgroundWorker();
			this.RepairWorker.DoWork += this.OnRWDoWork;
			this.RepairWorker.RunWorkerCompleted += this.OnRWRunWorkerCompleted;
			this.Platforms = new List<XPlatform>();
			this.SyntaxWorker = new BackgroundWorker();
			this.SyntaxWorker.DoWork += this.SyntaxDoWork;
			this.SyntaxWorker.RunWorkerCompleted += this.OnSyntaxRunWorkerCompleted;
			this.SyntaxWorker.WorkerReportsProgress = true;
			this.SyntaxWorker.ProgressChanged += this.SyntaxProgressChanged;
			if (manifestResourceStream2 != null)
			{
				((IDisposable)manifestResourceStream2).Dispose();
			}
		}

		internal void ResetParseTree()
		{
			foreach (XPlatform platform in this.Platforms)
			{
				try
				{
					GSXInjector.ResetScriptParseTree(platform);
				}
				catch (Exception ex)
				{
					IDE.Print("Parse tree reset failed: " + ex.Message, "Error", this.DOutput);
					return;
				}
			}
			IDE.Print("Parse Tree Reset", "Notification", this.DOutput);
		}

		internal void ReportClicked()
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = "http://gsxstudio.net/bugreporter.php",
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				ErrorDialog = true,
				UseShellExecute = true
			});
		}

		internal void PlatformMemClicked()
		{
			if (this.Platforms.Count < 1)
			{
				IDE.Print("No platforms are connected.", "Error", this.DOutput);
			}
			else
			{
				XPlatformMemory xplatformMemory = new XPlatformMemory();
				xplatformMemory.ShowDialog();
				if (xplatformMemory != null)
				{
					((IDisposable)xplatformMemory).Dispose();
				}
			}
		}

		internal void OpenProject()
		{
			if (this.GSXProjectSelector.ShowDialog() == DialogResult.OK)
			{
				GSXProject activeProject = this.ActiveProject;
				if (activeProject == null || !activeProject.Unsaved || this.AskToSave())
				{
					this.ClearProjectWindows();
					try
					{
						GSXProject gsxproject = GSXProject.LoadProject(this.GSXProjectSelector.FileName);
						this.ActiveProject = gsxproject;
						string a_ = "Loaded Project";
						IDE.Print(gsxproject.ProjectName, a_, this.DOutput);
					}
					catch (Exception ex)
					{
						string a_2 = "Error";
						IDE.Print("Couldnt open project!", a_2, this.DOutput);
						return;
					}
					this.FormControl.Text = this.ActiveProject.ProjectName + " - Black Ops II - GSX Studio";
					this.LoadProjectWindows();
					this.SetProjectSpecificButtonsState(true);
					this.SyntaxTimer.Start();
				}
			}
		}

		internal void ClearProjectWindows()
		{
			this.UnboundWindowTransition = true;
			this.ClearErrorConsole();
			GSCScript activeScript = this.ActiveScript;
			if (activeScript != null && activeScript.Linked)
			{
				this.CacheOldScript(activeScript);
			}
			this.Explorer.BeginUnboundLoad();
			this.Explorer.Nodes.Clear();
			this.Explorer.EndUnboundLoad();
			this.ClearEditorWindows();
			GSCScript activeScript2 = this.ActiveScript;
			if (activeScript2 != null && activeScript2.Linked)
			{
				this.UnlinkScriptEditors(activeScript2);
			}
			this.UnboundWindowTransition = false;
		}

		internal void LoadProjectWindows()
		{
			if (this.ActiveProject != null)
			{
				try
				{
					SplashScreenManager.ShowForm(typeof(WaitForm1));
				}
				catch (Exception)
				{
					try
					{
					}
					catch (Exception)
					{
					}
				}
				this.LoadExplorerTree();
				this.LoadTextEditors();
				this.LoadBuildItems();
				try
				{
					SplashScreenManager.CloseForm();
				}
				catch (Exception)
				{
				}
			}
		}

		internal void NewProject()
		{
			GSXProject activeProject = this.ActiveProject;
			if (activeProject == null || !activeProject.Unsaved || this.AskToSave())
			{
				NewProjectDialog newProjectDialog = new NewProjectDialog();
				if (newProjectDialog.ShowDialog() != DialogResult.OK)
				{
					if (newProjectDialog != null)
					{
						((IDisposable)newProjectDialog).Dispose();
					}
				}
				else if (Directory.Exists(this.ProjectsLocation + Path.DirectorySeparatorChar + newProjectDialog.ProjectNameBox.Text))
				{
					IDE.Print("A project with this name already exists!", "Error", this.DOutput);
					if (newProjectDialog != null)
					{
						((IDisposable)newProjectDialog).Dispose();
					}
				}
				else
				{
					try
					{
						this.ClearProjectWindows();
						GSXProject gsxproject = GSXProject.CreateProject(newProjectDialog.ProjectNameBox.Text, newProjectDialog.CreatorNameBox.Text, newProjectDialog.DescriptionBox.Text, this.ProjectsLocation, newProjectDialog.ScriptLocation.Text);
						this.ActiveProject = gsxproject;
						string a_ = "Loaded Project";
						string projectName = gsxproject.ProjectName;
						IDE.Print(projectName, a_, this.DOutput);
						this.LoadProjectWindows();
						this.SetProjectSpecificButtonsState(true);
					}
					catch (Exception ex)
					{
						string a_2 = "Error";
						IDE.Print("Couldnt make new project", a_2, this.DOutput);
					}
					if (newProjectDialog != null)
					{
						((IDisposable)newProjectDialog).Dispose();
					}
				}
			}
		}

		[return: MarshalAs(UnmanagedType.U1)]
		internal bool AskToSave()
		{
			if (!this.ActiveProject.Unsaved)
			{
				return true;
			}
			AskToSaveDialog askToSaveDialog = new AskToSaveDialog();
			DialogResult dialogResult = askToSaveDialog.ShowDialog();
			if (dialogResult == DialogResult.Cancel)
			{
				if (askToSaveDialog != null)
				{
					((IDisposable)askToSaveDialog).Dispose();
				}
				return false;
			}
			if (dialogResult == DialogResult.Yes)
			{
				this.SaveProject();
			}
			return true;
		}

		internal void SaveProject()
		{
			if (this.ActiveProject == null)
			{
				IDE.Print("No active project", "Warning", this.DOutput);
			}
			else
			{
				try
				{
					string arg = this.ProjectsLocation + Path.DirectorySeparatorChar + this.ActiveProject.ProjectName + Path.DirectorySeparatorChar + this.ActiveProject.ProjectName;
					foreach (GSCScript gscscript in this.ActiveProject.ProjectFiles)
					{
						if (gscscript.Linked)
						{
							foreach (GSCPart gscpart in gscscript.ScriptFiles)
							{
								gscpart.Modified = false;
								gscscript.WindowLinks[gscpart].Text = gscpart.Name.Substring(0, gscpart.Name.Length - 4);
							}
							gscscript.SyncEditorContents();
						}
						foreach (GSCPart gscpart2 in gscscript.ScriptFiles)
						{
							File.WriteAllText(arg + Path.DirectorySeparatorChar + gscscript.Name + Path.DirectorySeparatorChar + gscpart2.Name, gscpart2.Contents);
						}
					}
					this.ActiveProject.Unsaved = false;
					this.SaveProjectFile();
					this.StatusLabel.Caption = "Item(s) Saved";
				}
				catch (Exception ex)
				{
					string a_ = "Error";
					IDE.Print("Couldnt finish saving the project! (" + ex.StackTrace.ToString() + ")", a_, this.DOutput);
				}
			}
		}

		internal void SaveProjectFile()
		{
			if (this.ActiveProject != null)
			{
				List<byte> list = new List<byte>();
				list.AddRange(new byte[]
				{
					0x25,
					0x47,
					0x53,
					0x58,
					0x50,
					0x25
				});
				list.AddRange(IDE.Utility.BytesFromString(this.ActiveProject.CreatorName));
				list.AddRange(IDE.Utility.BytesFromString(this.ActiveProject.ProjectName));
				list.Add(this.ActiveProject.NumberOfScripts);
				List<GSCScript>.Enumerator enumerator = this.ActiveProject.ProjectFiles.GetEnumerator();
				if (enumerator.MoveNext())
				{
					do
					{
						GSCScript gscscript = enumerator.Current;
						list.AddRange(IDE.Utility.BytesFromString(gscscript.Name));
						list.Add(gscscript.NumberOfScriptFiles);
						List<GSCPart>.Enumerator enumerator2 = gscscript.ScriptFiles.GetEnumerator();
						if (enumerator2.MoveNext())
						{
							do
							{
								GSCPart gscpart = enumerator2.Current;
								list.AddRange(IDE.Utility.BytesFromString(gscpart.Name));
							}
							while (enumerator2.MoveNext());
						}
					}
					while (enumerator.MoveNext());
				}
				list.Add(this.ActiveProject.TypeStrictState);
				list.Add(this.ActiveProject.InlineState);
				int num = this.ActiveProject.Debug ? 1 : 0;
				list.Add((byte)num);
				list.AddRange(IDE.Utility.BytesFromString(this.ActiveProject.Watermark));
				File.WriteAllBytes(this.ProjectsLocation + Path.DirectorySeparatorChar + this.ActiveProject.ProjectName + Path.DirectorySeparatorChar + this.ActiveProject.ProjectName + ".gsxp", list.ToArray());
				this.StatusLabel.Caption = "Item(s) Saved";
			}
		}

		internal void LoadExplorerTree()
		{
			this.Explorer.BeginUnboundLoad();
			this.Explorer.Nodes.Clear();
			string[] nodeData = new string[]
			{
				"mp"
			};
			TreeListNode treeListNode = this.Explorer.AppendNode(nodeData, -1);
			Dictionary<string, TreeListNode> dictionary = new Dictionary<string, TreeListNode>();
			int num = 0;
			if (0 < this.ActiveProject.NumberOfScripts)
			{
				do
				{
					char[] separator = new char[]
					{
						'\\',
						'/'
					};
					string[] array = this.ActiveProject.ProjectFiles[num].Name.Split(separator);
					TreeListNode parentNode = treeListNode;
					int num2 = 0;
					if (0 < array.Length)
					{
						do
						{
							if (!(array[num2] == "maps") && !(array[num2] == "mp"))
							{
								if (!dictionary.ContainsKey(array[num2]))
								{
									if (num2 == array.Length - 1)
									{
										ExplorerScriptWrapper explorerScriptWrapper = new ExplorerScriptWrapper(array[num2], this.ActiveProject.ProjectFiles[num]);
										ExplorerScriptWrapper[] nodeData2 = new ExplorerScriptWrapper[]
										{
											explorerScriptWrapper
										};
										TreeListNode treeListNode2 = this.Explorer.AppendNode(nodeData2, parentNode);
										explorerScriptWrapper.Node = treeListNode2;
										explorerScriptWrapper.Script.Node = treeListNode2;
										dictionary[array[num2]] = treeListNode2;
										parentNode = treeListNode2;
									}
									else
									{
										string[] nodeData3 = new string[]
										{
											array[num2]
										};
										TreeListNode treeListNode3 = this.Explorer.AppendNode(nodeData3, parentNode);
										dictionary[array[num2]] = treeListNode3;
										parentNode = treeListNode3;
									}
								}
								else
								{
									parentNode = dictionary[array[num2]];
								}
							}
							num2++;
						}
						while (num2 < array.Length);
					}
					int num3 = 0;
					if (0 < this.ActiveProject.ProjectFiles[num].NumberOfScriptFiles)
					{
						do
						{
							ExplorerPartWrapper[] nodeData4 = new ExplorerPartWrapper[]
							{
								new ExplorerPartWrapper(this.ActiveProject.ProjectFiles[num].ScriptFiles[num3].Name, this.ActiveProject.ProjectFiles[num].ScriptFiles[num3])
							};
							this.Explorer.AppendNode(nodeData4, parentNode);
							num3++;
						}
						while (num3 < (int)this.ActiveProject.ProjectFiles[num].NumberOfScriptFiles);
					}
					num++;
				}
				while (num < (int)this.ActiveProject.NumberOfScripts);
			}
			this.Explorer.EndUnboundLoad();
		}

		internal void LoadTextEditors()
		{
			this.ActiveScript = null;
			if (this.ActiveProject.ProjectFiles.Count < 1)
			{
				IDE.Print("There arent any scripts in this project. Please add a script file to get started!", "Notification", this.DOutput);
			}
			else
			{
				GSCScript gscscript = this.ActiveProject.ProjectFiles[0];
				this.ActiveScript = gscscript;
				if (gscscript != null)
				{
					this.ActivePart = this.ActiveProject.ProjectFiles[0].ScriptFiles[0];
				}
				this.CreateAndLinkScriptEditors(this.ActiveScript);
			}
		}

		internal void CacheOldScript(GSCScript OldScript)
		{
			if (OldScript != null && OldScript.Linked)
			{
				OldScript.SyncEditorContents();
				OldScript.RefreshParseTrees(this.GSXParser);
			}
		}

		internal void UnlinkScriptEditors(GSCScript OldScript)
		{
			if (OldScript != null && OldScript.Linked)
			{
				OldScript.Links.Clear();
				OldScript.EditorLinks.Clear();
				OldScript.WindowLinks.Clear();
				OldScript.Linked = false;
			}
		}

		internal void CreateAndLinkScriptEditors(GSCScript NewScript)
		{
			if (!NewScript.Linked)
			{
				this.DError.BeginUnboundLoad();
				this.DError.Nodes.Clear();
				this.DError.EndUnboundLoad();
				NewScript.Links.Clear();
				NewScript.WindowLinks.Clear();
				NewScript.EditorLinks.Clear();
				List<AutocompleteItem> autoCompleteItems = this.LoadAutoCompleteItems();
				List<GSCPart>.Enumerator enumerator = NewScript.ScriptFiles.GetEnumerator();
				if (enumerator.MoveNext())
				{
					do
					{
						GSCPart gscpart = enumerator.Current;
						XEditor gsxeditor = this.GetGSXEditor(gscpart.Contents, this);
						gsxeditor.SetAutoCompleteItems(autoCompleteItems);
						DockPanel dockPanel = new DockPanel();
						dockPanel.Text = gscpart.Name.Substring(0, gscpart.Name.Length - 4);
						NewScript.WindowLinks[gscpart] = dockPanel;
						if (gscpart.Modified)
						{
							this.ActiveScript.WindowLinks[gscpart].Text = gscpart.Name.Substring(0, gscpart.Name.Length - 4) + "*";
						}
						dockPanel.Controls.Add(gsxeditor);
						gsxeditor.Dock = DockStyle.Fill;
						dockPanel.Register(this.DockingManager);
						this.DocumentManager.AddDocument(dockPanel);
						dockPanel.Options.ShowAutoHideButton = false;
						dockPanel.Options.ShowCloseButton = false;
						NewScript.Links[gscpart] = gsxeditor;
						NewScript.EditorLinks[gsxeditor] = gscpart;
					}
					while (enumerator.MoveNext());
				}
				NewScript.Linked = true;
			}
		}

		internal void OnFocusedNodeChanged(object A_0, FocusedNodeChangedEventArgs A_1)
		{
			if (!this.UnboundWindowTransition && A_1.Node != null)
			{
				this.UnboundWindowTransition = true;
				this.ResetTimerInterval();
				if (A_1.Node.GetValue(0).GetType() != typeof(ExplorerScriptWrapper))
				{
					if (A_1.Node.GetValue(0).GetType() == typeof(ExplorerPartWrapper))
					{
						GSCPart script = ((ExplorerPartWrapper)A_1.Node.GetValue(0)).Script;
						this.ActivePart = script;
						if (this.ActiveProject == null)
						{
							this.UnboundWindowTransition = false;
							return;
						}
						GSCScript gscscript = null;
						GSCScript activeScript = this.ActiveScript;
						if (activeScript != null && activeScript.ScriptFiles.Contains(script))
						{
							activeScript = this.ActiveScript;
							if (activeScript.Linked)
							{
								this.DocumentManager.ActivateDocument(activeScript.WindowLinks[script]);
								this.UnboundWindowTransition = false;
								return;
							}
						}
						List<GSCScript>.Enumerator enumerator = this.ActiveProject.ProjectFiles.GetEnumerator();
						if (enumerator.MoveNext())
						{
							do
							{
								GSCScript gscscript2 = enumerator.Current;
								if (gscscript2.ScriptFiles.Contains(script))
								{
									gscscript = gscscript2;
								}
							}
							while (enumerator.MoveNext());
						}
						if (gscscript == null)
						{
							IDE.Print("Oops... Looks like some how this file got into the project without being part of a script... We arent loading just to be safe.", "Warning", this.DOutput);
							this.UnboundWindowTransition = false;
							return;
						}
						try
						{
							SplashScreenManager.ShowForm(typeof(WaitForm1));
						}
						catch (Exception)
						{
							try
							{
							}
							catch (Exception)
							{
							}
						}
						GSCScript activeScript2 = this.ActiveScript;
						if (activeScript2 != null && activeScript2.Linked)
						{
							this.CacheOldScript(activeScript2);
						}
						this.ClearEditorWindows();
						GSCScript activeScript3 = this.ActiveScript;
						if (activeScript3 != null && activeScript3.Linked)
						{
							this.UnlinkScriptEditors(activeScript3);
						}
						this.ActiveScript = gscscript;
						this.CreateAndLinkScriptEditors(gscscript);
						this.DocumentManager.ActivateDocument(this.ActiveScript.WindowLinks[script]);
						try
						{
							SplashScreenManager.CloseForm();
						}
						catch (Exception)
						{
						}
					}
					this.UnboundWindowTransition = false;
				}
				else
				{
					GSCScript script2 = ((ExplorerScriptWrapper)A_1.Node.GetValue(0)).Script;
					GSCScript activeScript4 = this.ActiveScript;
					if (activeScript4 != null && script2 == activeScript4)
					{
						this.UnboundWindowTransition = false;
					}
					else
					{
						if (activeScript4 != null && activeScript4.Linked)
						{
							this.CacheOldScript(activeScript4);
						}
						try
						{
							SplashScreenManager.ShowForm(typeof(WaitForm1));
						}
						catch (Exception)
						{
						}
						this.ClearEditorWindows();
						GSCScript activeScript5 = this.ActiveScript;
						if (activeScript5 != null && activeScript5.Linked)
						{
							this.UnlinkScriptEditors(activeScript5);
						}
						this.ActiveScript = script2;
						this.CreateAndLinkScriptEditors(script2);
						SplashScreenManager.CloseForm();
						this.UnboundWindowTransition = false;
					}
				}
			}
		}

		internal void ExplorerOnMouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				if (this.Explorer.Selection[0] != null && this.Explorer.Selection[0].GetValue(0).GetType() == typeof(ExplorerScriptWrapper))
				{
					Point location = e.Location;
					Point p = ((Control)sender).PointToScreen(location);
					this.ScriptRightClick.ShowPopup(p);
				}
				else if (this.Explorer.Selection[0] != null && this.Explorer.Selection[0].GetValue(0).GetType() == typeof(ExplorerPartWrapper))
				{
					Point location2 = e.Location;
					Point p2 = ((Control)sender).PointToScreen(location2);
					this.PartRightClick.ShowPopup(p2);
				}
				else if (this.ActiveProject != null && this.Explorer.Selection[0] != null && this.Explorer.Selection[0].GetValue(0).GetType() == typeof(string))
				{
					Point location3 = e.Location;
					Point p3 = ((Control)sender).PointToScreen(location3);
					this.SubgroupPopup.ShowPopup(p3);
				}
			}
		}

		internal void RenameScriptFired()
		{
			if (this.ActiveScript != null && this.ActiveProject != null)
			{
				RenameScriptDialog renameScriptDialog = new RenameScriptDialog();
				if (renameScriptDialog.ShowDialog() != DialogResult.OK)
				{
					if (renameScriptDialog != null)
					{
						((IDisposable)renameScriptDialog).Dispose();
					}
				}
				else
				{
					List<GSCScript>.Enumerator enumerator = this.ActiveProject.ProjectFiles.GetEnumerator();
					if (enumerator.MoveNext())
					{
						while (!(enumerator.Current.Name.ToLower() == renameScriptDialog.ScriptPath.Text))
						{
							if (!enumerator.MoveNext())
							{
								goto IL_A2;
							}
						}
						if (renameScriptDialog != null)
						{
							((IDisposable)renameScriptDialog).Dispose();
						}
						IDE.Print("A script with this name already exists in this project", "Error", this.DOutput);
						return;
					}
					IL_A2:
					((ExplorerScriptWrapper)this.Explorer.Selection[0].GetValue(0)).Name = renameScriptDialog.ScriptPath.Text;
					GSCScript script = ((ExplorerScriptWrapper)this.Explorer.Selection[0].GetValue(0)).Script;
					char[] separator = new char[]
					{
						'\\'
					};
					string[] array = renameScriptDialog.ScriptPath.Text.Split(separator);
					string text = this.ProjectsLocation + Path.DirectorySeparatorChar + this.ActiveProject.ProjectName + Path.DirectorySeparatorChar + this.ActiveProject.ProjectName;
					string text2 = text + "";
					int num = 0;
					if (0 < array.Length)
					{
						do
						{
							string arg = array[num];
							text2 += Path.DirectorySeparatorChar + arg;
							if (!Directory.Exists(text2))
							{
								Directory.CreateDirectory(text2);
							}
							num++;
						}
						while (num < array.Length);
					}
					Directory.Delete(text2);
					Directory.Move(text + Path.DirectorySeparatorChar + script.Name, text2);
					char[] separator2 = new char[]
					{
						'\\',
						'/'
					};
					string[] array2 = script.Name.Split(separator2);
					int num2 = array2.Length - 1;
					if (num2 > -1)
					{
						for (;;)
						{
							string text3 = text + "";
							int num3 = 0;
							if (0 < num2)
							{
								do
								{
									text3 += Path.DirectorySeparatorChar + array2[num3];
									num3++;
								}
								while (num3 < num2);
							}
							bool flag = false;
							List<GSCScript>.Enumerator enumerator2 = this.ActiveProject.ProjectFiles.GetEnumerator();
							if (!enumerator2.MoveNext())
							{
								goto IL_2A3;
							}
							do
							{
								flag = (enumerator2.Current.Name.ToLower() == text3 || flag);
							}
							while (enumerator2.MoveNext());
							if (!flag)
							{
								goto IL_2A3;
							}
							IL_2C6:
							num2--;
							if (num2 <= -1)
							{
								break;
							}
							continue;
							IL_2A3:
							if (!Directory.Exists(text3))
							{
								goto IL_2C6;
							}
							int num4 = Directory.GetFiles(text3).Length;
							if (Directory.GetDirectories(text3).Length + num4 == 0)
							{
								Directory.Delete(text3);
								goto IL_2C6;
							}
							goto IL_2C6;
						}
					}
					script.Name = renameScriptDialog.ScriptPath.Text;
					if (renameScriptDialog != null)
					{
						((IDisposable)renameScriptDialog).Dispose();
					}
					this.SaveProjectFile();
					this.Explorer.BeginUnboundLoad();
					this.Explorer.Nodes.Clear();
					this.Explorer.EndUnboundLoad();
					this.LoadExplorerTree();
				}
			}
		}

		internal void RenameFileFired()
		{
			if (this.ActiveScript != null)
			{
				GSCPart script = ((ExplorerPartWrapper)this.Explorer.Selection[0].GetValue(0)).Script;
				RenamePartDialog renamePartDialog = new RenamePartDialog();
				renamePartDialog.CValue.Text = script.Name;
				if (renamePartDialog.ShowDialog() != DialogResult.OK)
				{
					if (renamePartDialog != null)
					{
						((IDisposable)renamePartDialog).Dispose();
					}
				}
				else
				{
					string text = new string(Path.GetInvalidFileNameChars());
					renamePartDialog.CValue.Text = renamePartDialog.CValue.Text.ToLower();
					int num = 0;
					if (0 < text.Length)
					{
						do
						{
							renamePartDialog.CValue.Text = renamePartDialog.CValue.Text.Replace(text[num], '#');
							num++;
						}
						while (num < text.Length);
					}
					List<GSCPart>.Enumerator enumerator = this.ActiveScript.ScriptFiles.GetEnumerator();
					if (enumerator.MoveNext())
					{
						while (!(enumerator.Current.Name == renamePartDialog.CValue.Text))
						{
							if (!enumerator.MoveNext())
							{
								goto IL_130;
							}
						}
						if (renamePartDialog != null)
						{
							((IDisposable)renamePartDialog).Dispose();
						}
						IDE.Print("Script item with this name already exists", "Error", this.DOutput);
						return;
					}
					IL_130:
					string str = this.ProjectsLocation + Path.DirectorySeparatorChar + this.ActiveProject.ProjectName + Path.DirectorySeparatorChar + this.ActiveProject.ProjectName + Path.DirectorySeparatorChar + this.ActiveScript.Name + Path.DirectorySeparatorChar;
					if (File.Exists(str + renamePartDialog.CValue.Text))
					{
						if (renamePartDialog != null)
						{
							((IDisposable)renamePartDialog).Dispose();
						}
						IDE.Print("A file already exists in that location with your selected name", "Error", this.DOutput);
					}
					else
					{
						GSCScript activeScript = this.ActiveScript;
						if (activeScript.Linked)
						{
							activeScript.SyncEditorContents();
						}
						if (File.Exists(str + script.Name))
						{
							File.Delete(str + script.Name);
						}
						File.WriteAllText(str + renamePartDialog.CValue.Text, script.Contents);
						this.Explorer.BeginUnboundLoad();
						TreeListNode node = this.ActiveScript.Node;
						if (node != null)
						{
							foreach (TreeListNode treeListNode in node.Nodes)
							{
								if (((ExplorerPartWrapper)treeListNode.GetValue(0)).Script == script)
								{
									((ExplorerPartWrapper)treeListNode.GetValue(0)).Name = renamePartDialog.CValue.Text;
								}
							}
						}
						this.Explorer.EndUnboundLoad();
						script.Name = renamePartDialog.CValue.Text;
						try
						{
							this.ActiveScript.WindowLinks[script].Text = script.Name.Substring(0, script.Name.Length - 4);
						}
						catch (Exception ex)
						{
						}
						this.SaveProjectFile();
						if (renamePartDialog != null)
						{
							((IDisposable)renamePartDialog).Dispose();
						}
					}
				}
			}
		}

		internal void DeleteScriptFired()
		{
			GSXProject activeProject = this.ActiveProject;
			if (activeProject != null)
			{
				if (this.ActiveScript == null)
				{
					List<GSCScript>.Enumerator enumerator = activeProject.ProjectFiles.GetEnumerator();
					if (enumerator.MoveNext())
					{
						do
						{
							GSCScript gscscript = enumerator.Current;
							if (gscscript.Node != null && gscscript.Node == this.Explorer.Selection[0])
							{
								this.ActiveScript = gscscript;
							}
						}
						while (enumerator.MoveNext());
					}
					if (this.ActiveScript == null)
					{
						IDE.Print("The active script couldnt be found... ", "Error", this.DOutput);
						return;
					}
				}
				DeleteConfirmationDialog deleteConfirmationDialog = new DeleteConfirmationDialog();
				if (deleteConfirmationDialog.ShowDialog() != DialogResult.Yes)
				{
					if (deleteConfirmationDialog != null)
					{
						((IDisposable)deleteConfirmationDialog).Dispose();
					}
				}
				else
				{
					bool @checked = deleteConfirmationDialog.DeleteFile.Checked;
					this.ActiveProject.ProjectFiles.Remove(this.ActiveScript);
					activeProject = this.ActiveProject;
					activeProject.NumberOfScripts += byte.MaxValue;
					if (@checked)
					{
						string path = this.ProjectsLocation + Path.DirectorySeparatorChar + this.ActiveProject.ProjectName + Path.DirectorySeparatorChar + this.ActiveProject.ProjectName + Path.DirectorySeparatorChar + this.ActiveScript.Name;
						try
						{
							Directory.Delete(path, true);
						}
						catch (Exception)
						{
							string a_ = "Warning";
							IDE.Print("Couldnt delete file from disc because the file doesnt exist", a_, this.DOutput);
						}
					}
					this.ClearEditorWindows();
					TreeListNode node = this.ActiveScript.Node;
					this.ActiveScript = null;
					this.Explorer.BeginUnboundLoad();
					node.ParentNode.Nodes.Remove(node);
					this.Explorer.EndUnboundLoad();
					this.SaveProjectFile();
					if (deleteConfirmationDialog != null)
					{
						((IDisposable)deleteConfirmationDialog).Dispose();
					}
				}
			}
		}

		internal void DeleteFileFired()
		{
			if (this.ActiveProject != null)
			{
				if (this.ActiveScript == null)
				{
					IDE.Print("The active script couldnt be found... ", "Error", this.DOutput);
				}
				else
				{
					DeleteConfirmationDialog deleteConfirmationDialog = new DeleteConfirmationDialog();
					if (deleteConfirmationDialog.ShowDialog() != DialogResult.Yes)
					{
						if (deleteConfirmationDialog != null)
						{
							((IDisposable)deleteConfirmationDialog).Dispose();
						}
					}
					else
					{
						bool @checked = deleteConfirmationDialog.DeleteFile.Checked;
						GSCPart script = ((ExplorerPartWrapper)this.Explorer.Selection[0].GetValue(0)).Script;
						this.ActiveScript.ScriptFiles.Remove(script);
						this.ActiveScript.NumberOfScriptFiles += byte.MaxValue;
						this.Explorer.BeginUnboundLoad();
						this.Explorer.Selection[0].ParentNode.Nodes.Remove(this.Explorer.Selection[0]);
						this.Explorer.EndUnboundLoad();
						this.ActiveScript.EditorLinks.Remove(this.ActiveScript.Links[script]);
						this.ActiveScript.Links.Remove(script);
						this.DocumentManager.RemoveDocument(this.ActiveScript.WindowLinks[script]);
						IDisposable disposable = this.ActiveScript.WindowLinks[script];
						if (disposable != null)
						{
							disposable.Dispose();
						}
						this.ActiveScript.WindowLinks.Remove(script);
						if (@checked)
						{
							File.Delete(this.ProjectsLocation + Path.DirectorySeparatorChar + this.ActiveProject.ProjectName + Path.DirectorySeparatorChar + this.ActiveProject.ProjectName + Path.DirectorySeparatorChar + this.ActiveScript.Name + Path.DirectorySeparatorChar + script.Name);
						}
						this.SaveProjectFile();
						if (deleteConfirmationDialog != null)
						{
							((IDisposable)deleteConfirmationDialog).Dispose();
						}
					}
				}
			}
		}

		internal void DeleteSubgroupFired()
		{
			if (this.ActiveProject != null)
			{
				string text = this.Explorer.Selection[0].GetValue(0).ToString();
				if (text == "mp")
				{
					IDE.Print("Cannot delete subgroup 'mp'", "Error", this.DOutput);
				}
				else if (new DeleteConfirmationDialog
				{
					Message = 
					{
						Text = "Delete ENTIRE subgroup from project??"
					}
				}.ShowDialog() == DialogResult.Yes)
				{
					TreeListNode parentNode = this.Explorer.Selection[0].ParentNode;
					if (parentNode != null)
					{
						do
						{
							text = parentNode.GetValue(0).ToString() + Path.DirectorySeparatorChar + text;
							parentNode = parentNode.ParentNode;
						}
						while (parentNode != null);
					}
					text = "maps" + Path.DirectorySeparatorChar + text;
					this.ClearProjectWindows();
					string str = this.ProjectsLocation + Path.DirectorySeparatorChar + this.ActiveProject.ProjectName + Path.DirectorySeparatorChar + this.ActiveProject.ProjectName + Path.DirectorySeparatorChar;
					int num = 0;
					GSXProject activeProject = this.ActiveProject;
					if (0 < activeProject.NumberOfScripts)
					{
						do
						{
							if (activeProject.ProjectFiles[num].Name.Replace("/", "\\").ToLower().Contains(text))
							{
								this.ActiveProject.ProjectFiles.Remove(this.ActiveProject.ProjectFiles[num]);
								activeProject = this.ActiveProject;
								activeProject.NumberOfScripts += byte.MaxValue;
								num--;
							}
							num++;
							activeProject = this.ActiveProject;
						}
						while (num < (int)activeProject.NumberOfScripts);
					}
					IDE.Utility.DeleteAllFilesAndDirectories(str + text);
					this.SaveProjectFile();
					this.LoadProjectWindows();
				}
			}
		}

		internal void AddNewScript()
		{
			if (this.ActiveProject != null)
			{
				NewScriptDialog newScriptDialog = new NewScriptDialog();
				if (newScriptDialog.ShowDialog() != DialogResult.OK)
				{
					if (newScriptDialog != null)
					{
						((IDisposable)newScriptDialog).Dispose();
					}
				}
				else
				{
					string text = new string(Path.GetInvalidPathChars());
					int num = 0;
					if (0 < text.Length)
					{
						do
						{
							newScriptDialog.ScriptPath.Text = newScriptDialog.ScriptPath.Text.Replace(text[num] + "", "#");
							num++;
						}
						while (num < text.Length);
					}
					newScriptDialog.ScriptPath.Text = newScriptDialog.ScriptPath.Text.Replace("/", "\\");
					List<GSCScript>.Enumerator enumerator = this.ActiveProject.ProjectFiles.GetEnumerator();
					if (enumerator.MoveNext())
					{
						while (!(enumerator.Current.Name.Replace("/", "\\").ToLower() == newScriptDialog.ScriptPath.Text.ToLower()))
						{
							if (!enumerator.MoveNext())
							{
								goto IL_125;
							}
						}
						IDE.Print("A script with that name already exists", "Error", this.DOutput);
						if (newScriptDialog != null)
						{
							((IDisposable)newScriptDialog).Dispose();
							return;
						}
						return;
					}
					IL_125:
					this.AppendScript(newScriptDialog.ScriptPath.Text, newScriptDialog.Description.Text);
					if (newScriptDialog != null)
					{
						((IDisposable)newScriptDialog).Dispose();
					}
				}
			}
		}

		internal void AppendScript(string Name, string Description)
		{
			string arg = null;
			try
			{
				SplashScreenManager.ShowForm(typeof(WaitForm1));
			}
			catch (Exception)
			{
				try
				{
				}
				catch (Exception)
				{
				}
			}
			string text = new string(Path.GetInvalidPathChars());
			int num = 0;
			if (0 < text.Length)
			{
				do
				{
					Name = Name.Replace(text[num] + "", "#");
					num++;
				}
				while (num < text.Length);
			}
			GSCScript gscscript = new GSCScript();
			gscscript.Name = Name;
			gscscript.NumberOfScriptFiles = 1;
			GSXProject activeProject = this.ActiveProject;
			GSCPart gscpart = new GSCPart("/*\n" + Description + "\n*/" + GSXProject.GetDefaultProjectCode(activeProject.CreatorName, activeProject.ProjectName, Name), "main.gsx");
			gscscript.ScriptFiles.Add(gscpart);
			this.ActiveProject.ProjectFiles.Add(gscscript);
			this.ActiveProject.NumberOfScripts += 1;
			arg = this.ProjectsLocation + Path.DirectorySeparatorChar + this.ActiveProject.ProjectName + Path.DirectorySeparatorChar + this.ActiveProject.ProjectName;
			try
			{
				string[] array = Name.Split(new char[]
				{
					'\\',
					'/'
				});
				for (int i = 0; i < array.Length; i++)
				{
					if (!Directory.Exists(arg + Path.DirectorySeparatorChar + array[i]))
					{
						Directory.CreateDirectory(arg + Path.DirectorySeparatorChar + array[i]);
					}
					arg = arg + Path.DirectorySeparatorChar + array[i];
				}
			}
			catch (Exception ex)
			{
				throw new Exception("Couldnt create a script directory! (" + ex.Message + ")");
			}
			File.WriteAllText(arg + Path.DirectorySeparatorChar + "main.gsx", gscpart.Contents);
			this.CacheOldScript(this.ActiveScript);
			this.UnlinkScriptEditors(this.ActiveScript);
			this.ClearProjectWindows();
			this.ActiveScript = gscscript;
			this.LoadExplorerTree();
			this.CreateAndLinkScriptEditors(this.ActiveScript);
			this.SaveProjectFile();
			try
			{
				SplashScreenManager.CloseForm();
			}
			catch (Exception)
			{
			}
		}

		internal void AddScriptFile()
		{
			if (this.ActiveProject != null && this.ActiveScript != null)
			{
				NewPartDialog newPartDialog = new NewPartDialog();
				if (newPartDialog.ShowDialog() != DialogResult.OK)
				{
					if (newPartDialog != null)
					{
						((IDisposable)newPartDialog).Dispose();
					}
				}
				else
				{
					string text = new string(Path.GetInvalidFileNameChars());
					int num = 0;
					if (0 < text.Length)
					{
						do
						{
							newPartDialog.FileName.Text = newPartDialog.FileName.Text.Replace(text[num] + "", "#");
							num++;
						}
						while (num < text.Length);
					}
					this.AppendScriptFile(newPartDialog.FileName.Text, newPartDialog.Description.Text, newPartDialog.DefaultCode.Checked);
					if (newPartDialog != null)
					{
						((IDisposable)newPartDialog).Dispose();
					}
				}
			}
		}

		internal void AppendScriptFile(string Name, string Description, [MarshalAs(UnmanagedType.U1)] bool DefaultCode)
		{
			if (this.ActiveProject != null && this.ActiveScript != null)
			{
				Name += ".gsx";
				List<GSCPart>.Enumerator enumerator = this.ActiveScript.ScriptFiles.GetEnumerator();
				if (enumerator.MoveNext())
				{
					while (!(enumerator.Current.Name == Name))
					{
						if (!enumerator.MoveNext())
						{
							goto IL_77;
						}
					}
					IDE.Print("A file with that name already exists for this script", "Error", this.DOutput);
					return;
				}
				IL_77:
				GSCPart gscpart;
				if (DefaultCode)
				{
					GSXProject activeProject = this.ActiveProject;
					gscpart = new GSCPart("/*\n" + Description + "\n*/" + GSXProject.GetDefaultProjectCode(activeProject.CreatorName, activeProject.ProjectName, this.ActiveScript.Name), Name);
				}
				else
				{
					gscpart = new GSCPart("/*\n" + Description + "\n*/", Name);
				}
				this.ActiveScript.ScriptFiles.Add(gscpart);
				this.ActiveScript.NumberOfScriptFiles += 1;
				File.WriteAllText(this.ProjectsLocation + Path.DirectorySeparatorChar + this.ActiveProject.ProjectName + Path.DirectorySeparatorChar + this.ActiveProject.ProjectName + Path.DirectorySeparatorChar + this.ActiveScript.Name + Path.DirectorySeparatorChar + gscpart.Name, gscpart.Contents);
				XEditor gsxeditor = this.GetGSXEditor(gscpart.Contents, this);
				gscpart.SetCache(this.GSXParser, gscpart.Name, gscpart.Contents);
				gsxeditor.SetAutoCompleteItems(this.LoadAutoCompleteItems());
				DockPanel dockPanel = new DockPanel();
				dockPanel.Text = gscpart.Name.Substring(0, gscpart.Name.Length - 4);
				this.ActiveScript.WindowLinks[gscpart] = dockPanel;
				if (gscpart.Modified)
				{
					this.ActiveScript.WindowLinks[gscpart].Text = gscpart.Name.Substring(0, gscpart.Name.Length - 4) + "*";
				}
				dockPanel.Controls.Add(gsxeditor);
				gsxeditor.Dock = DockStyle.Fill;
				dockPanel.Register(this.DockingManager);
				this.DocumentManager.AddDocument(dockPanel);
				dockPanel.Options.ShowAutoHideButton = false;
				dockPanel.Options.ShowCloseButton = false;
				this.ActiveScript.Links[gscpart] = gsxeditor;
				this.ActiveScript.EditorLinks[gsxeditor] = gscpart;
				if (this.ActiveScript.Node != null)
				{
					this.Explorer.BeginUnboundLoad();
					ExplorerPartWrapper[] nodeData = new ExplorerPartWrapper[]
					{
						new ExplorerPartWrapper(gscpart.Name, gscpart)
					};
					this.Explorer.AppendNode(nodeData, this.ActiveScript.Node);
					this.Explorer.EndUnboundLoad();
				}
				this.SaveProjectFile();
			}
		}

		internal void UnloadProject()
		{
			if (this.ActiveProject != null && this.AskToSave())
			{
				IDisposable disposable = this.ActiveProject as IDisposable;
				if (disposable != null)
				{
					disposable.Dispose();
				}
				this.ClearProjectWindows();
				this.UnboundWindowTransition = true;
				string name = "README.txt";
				Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name);
				StreamReader streamReader = new StreamReader(manifestResourceStream);
				string text = streamReader.ReadToEnd();
				if (streamReader != null)
				{
					((IDisposable)streamReader).Dispose();
				}
				if (manifestResourceStream != null)
				{
					((IDisposable)manifestResourceStream).Dispose();
				}
				RichEditControl newDefaultEditor = this.GetNewDefaultEditor(text.Replace("{VERSION}", FileVersionInfo.GetVersionInfo(Application.ExecutablePath).FileVersion.ToString()), this);
				newDefaultEditor.ReadOnly = true;
				DockPanel dockPanel = new DockPanel();
				dockPanel.Text = "README";
				dockPanel.Controls.Add(newDefaultEditor);
				newDefaultEditor.Dock = DockStyle.Fill;
				dockPanel.Register(this.DockingManager);
				this.DocumentManager.AddDocument(dockPanel);
				this.Explorer.BeginUnboundLoad();
				string[] nodeData = new string[]
				{
					"README"
				};
				this.Explorer.AppendNode(nodeData, -1);
				this.Explorer.EndUnboundLoad();
				this.ActiveProject = null;
				this.UnboundWindowTransition = false;
				this.FormControl.Text = "Black Ops II - GSX Studio®";
				this.SetProjectSpecificButtonsState(false);
				this.SyntaxTimer.Stop();
			}
		}

		internal void ClearEditorWindows()
		{
			foreach (BaseDocument baseDocument in ((IEnumerable<BaseDocument>)this.DocumentManager.Documents))
			{
				try
				{
					((DockPanel)baseDocument.Control).Options.ShowCloseButton = true;
				}
				catch (Exception)
				{
				}
			}
			this.DocumentManager.Controller.CloseAll();
			GSCScript activeScript = this.ActiveScript;
			if (activeScript != null && activeScript.Linked)
			{
				foreach (DockPanel dockPanel in activeScript.WindowLinks.Values)
				{
					if (dockPanel != null)
					{
						try
						{
							dockPanel.Options.ShowCloseButton = true;
							this.DManager.RemovePanel(dockPanel);
							continue;
						}
						catch (Exception)
						{
							continue;
						}
						break;
					}
				}
			}
		}

		internal void LoadImportsWindow()
		{
			new ImportProjectDialog(this.ProjectsLocation).Show();
		}

		internal void SaveActiveFile()
		{
			if (this.ActiveProject != null && this.ActiveScript != null && this.DocumentManager.ActiveDocument != null)
			{
				this.DocumentManager.ActivateDocument(this.DocumentManager.ActiveDocument.Control);
				try
				{
					GSCPart script = ((ExplorerPartWrapper)this.Explorer.FocusedNode.GetValue(0)).Script;
					this.ActiveScript.SyncEditorContents();
					script.Modified = false;
					File.WriteAllText(this.ProjectsLocation + Path.DirectorySeparatorChar + this.ActiveProject.ProjectName + Path.DirectorySeparatorChar + this.ActiveProject.ProjectName + Path.DirectorySeparatorChar + this.ActiveScript.Name + Path.DirectorySeparatorChar + script.Name, script.Contents);
					((DockPanel)this.DocumentManager.ActiveDocument.Control).Text = ((DockPanel)this.DocumentManager.ActiveDocument.Control).Text.Replace("*", "");
					this.ActiveProject.UpdateModified();
				}
				catch (InvalidCastException)
				{
					this.SaveProject();
				}
			}
		}

		[return: MarshalAs(UnmanagedType.U1)]
		internal bool CheckScriptSyntax()
		{
			if (this.ActiveProject != null && this.ActiveScript != null)
			{
				bool result = false;
				this.ClearErrorConsole();
				this.DError.BeginUnboundLoad();
				List<GSCPart>.Enumerator enumerator = this.ActiveScript.ScriptFiles.GetEnumerator();
				if (enumerator.MoveNext())
				{
					do
					{
						GSCPart gscpart = enumerator.Current;
						Intellisense.ParserErrorData[] array = GSCCompiler.CheckSyntax(out gscpart.Tree, gscpart.Contents, gscpart.Name);
						int num = 0;
						if (0 < array.Length)
						{
							result = true;
							do
							{
								Intellisense.ParserErrorData parserErrorData = array[num];
								object[] nodeData = new object[]
								{
									parserErrorData[0],
									parserErrorData,
									parserErrorData[2],
									parserErrorData[3],
									parserErrorData[4]
								};
								this.DError.AppendNode(nodeData, -1);
								num++;
							}
							while (num < array.Length);
						}
					}
					while (enumerator.MoveNext());
				}
				this.DError.EndUnboundLoad();
				return result;
			}
			return false;
		}

		internal void ClearErrorConsole()
		{
			this.DError.BeginUnboundLoad();
			this.DError.Nodes.Clear();
			this.DError.EndUnboundLoad();
		}

		internal void CheckCurrentFileSyntax()
		{
			if (this.ActiveProject != null && this.ActiveScript != null)
			{
				this.ClearErrorConsole();
				this.DError.BeginUnboundLoad();
				GSCPart activePart = this.ActivePart;
				Intellisense.ParserErrorData[] array = GSCCompiler.CheckSyntax(out this.ActivePart.Tree, this.ActiveScript.Links[activePart].Editor.Text, activePart.Name);
				int num = 0;
				if (0 < array.Length)
				{
					do
					{
						Intellisense.ParserErrorData parserErrorData = array[num];
						object[] nodeData = new object[]
						{
							parserErrorData[0],
							parserErrorData,
							parserErrorData[2],
							parserErrorData[3],
							parserErrorData[4]
						};
						this.DError.AppendNode(nodeData, -1);
						num++;
					}
					while (num < array.Length);
				}
				this.DError.EndUnboundLoad();
			}
		}

		internal void NavigateToSyntaxError(TreeListNode node)
		{
			if (node != null)
			{
				if (node.GetValue(1).GetType() == typeof(Intellisense.ParserGrammarErrorData))
				{
					Intellisense.ParserGrammarErrorData parserGrammarErrorData = (Intellisense.ParserGrammarErrorData)node.GetValue(1);
					if (parserGrammarErrorData != null)
					{
						this.ActivateWindowByName(parserGrammarErrorData.FileName);
						Color selectionColor = Color.FromArgb(0xE2, 0x32, 0x2F);
						this.ActiveScript.Links[this.ActivePart].Editor.SelectionColor = selectionColor;
						this.ActiveScript.Links[this.ActivePart].Editor.SelectionStart = parserGrammarErrorData.TokenPosition;
						this.ActiveScript.Links[this.ActivePart].Editor.SelectionLength = Regex.Match(this.ActiveScript.Links[this.ActivePart].Editor.Text.Substring(this.ActiveScript.Links[this.ActivePart].Editor.SelectionStart, this.ActiveScript.Links[this.ActivePart].Editor.Text.Length - this.ActiveScript.Links[this.ActivePart].Editor.SelectionStart), "[^ \n\r]+").Length;
						this.ActiveScript.Links[this.ActivePart].Editor.DoCaretVisible();
						this.ActiveScript.Links[this.ActivePart].Editor.Focus();
					}
				}
				else
				{
					Intellisense.ParserErrorData parserErrorData = (Intellisense.ParserErrorData)node.GetValue(1);
					if (parserErrorData != null)
					{
						this.ActivateWindowByName(parserErrorData.FileName);
						Color selectionColor2 = Color.FromArgb(0xE2, 0x32, 0x2F);
						this.ActiveScript.Links[this.ActivePart].Editor.SelectionColor = selectionColor2;
						this.ActiveScript.Links[this.ActivePart].Editor.SelectionStart = parserErrorData.Message.Location.Position;
						this.ActiveScript.Links[this.ActivePart].Editor.SelectionLength = Regex.Match(this.ActiveScript.Links[this.ActivePart].Editor.Text.Substring(this.ActiveScript.Links[this.ActivePart].Editor.SelectionStart, this.ActiveScript.Links[this.ActivePart].Editor.Text.Length - this.ActiveScript.Links[this.ActivePart].Editor.SelectionStart), "[^ \n\r]+").Length;
						this.ActiveScript.Links[this.ActivePart].Editor.DoCaretVisible();
						this.ActiveScript.Links[this.ActivePart].Editor.Focus();
					}
				}
			}
		}

		internal void ActivateWindowByName(string name)
		{
			if (!this.UnboundWindowTransition)
			{
				this.UnboundWindowTransition = true;
				using (IEnumerator<BaseDocument> enumerator = ((IEnumerable<BaseDocument>)this.DocumentManager.Documents).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						DevExpress.XtraBars.Docking2010.Views.Tabbed.Document document = (DevExpress.XtraBars.Docking2010.Views.Tabbed.Document)enumerator.Current;
						if (((DockPanel)document.Control).Text.Replace("*", "") == name.Substring(0, name.Length - 4))
						{
							foreach (GSCPart gscpart in this.ActiveScript.ScriptFiles)
							{
								if (gscpart.Name == name)
								{
									this.ActivePart = gscpart;
									foreach (TreeListNode treeListNode in this.ActiveScript.Node.Nodes)
									{
											if (treeListNode.GetValue(0) != null && treeListNode.GetValue(0).GetType() == typeof(ExplorerPartWrapper) && ((ExplorerPartWrapper)treeListNode.GetValue(0)).Script == gscpart)
											{
												this.Explorer.FocusedNode = treeListNode;
												break;
											}
									}
									break;
								}
							}
							this.DocumentManager.ActivateDocument(document.Control);
							break;
						}
					}
				}
				this.ResetTimerInterval();
				this.UnboundWindowTransition = false;
			}
		}

		internal void SetUpSyntaxTimer()
		{
			this.SyntaxTimer.Tick += this.OnSyntaxTick;
		}

		internal void ResetTimerInterval()
		{
			this.SyntaxTimer.Stop();
			this.SyntaxTimer.Start();
		}

		internal void SmartCheckFileSyntax()
		{
			if (this.ActiveProject != null)
			{
				GSCScript activeScript = this.ActiveScript;
				if (activeScript != null && activeScript.Linked)
				{
					GSCPart activePart = this.ActivePart;
					if (activePart != null && activeScript.Links.ContainsKey(activePart))
					{
						this.DError.BeginUnboundLoad();
						int num = 0;
						if (0 < this.DError.Nodes.Count)
						{
							do
							{
								if (this.DError.Nodes[num].GetValue(3).ToString() == this.ActivePart.Name)
								{
									this.DError.Nodes.RemoveAt(num);
									num--;
								}
								num++;
							}
							while (num < this.DError.Nodes.Count);
						}
						this.ActiveScript.SyncEditorContents();
						GSCPart activePart2 = this.ActivePart;
						Intellisense.ParserErrorData[] array = GSCCompiler.CheckSyntax(out activePart2.Tree, activePart2.Contents, activePart2.Name);
						int num2 = 0;
						if (0 < array.Length)
						{
							do
							{
								Intellisense.ParserErrorData parserErrorData = array[num2];
								object[] nodeData = new object[]
								{
									parserErrorData[0],
									parserErrorData,
									parserErrorData[2],
									parserErrorData[3],
									parserErrorData[4]
								};
								this.DError.AppendNode(nodeData, -1);
								num2++;
							}
							while (num2 < array.Length);
						}
						this.DError.EndUnboundLoad();
					}
				}
			}
		}

		internal void SmartCheckFileGrammar()
		{
			if (this.ActiveProject != null && this.ActiveScript != null && this.ActivePart != null && this.DeriveScriptInfo() != null)
			{
				this.DError.BeginUnboundLoad();
				Intellisense.ParserGrammarErrorData[] array = Intellisense.VerboseGrammarErrors(this.ActivePart.Tree, this.DeriveScriptInfo());
				int num = 0;
				if (0 < array.Length)
				{
					do
					{
						Intellisense.ParserGrammarErrorData parserGrammarErrorData = array[num];
						object[] nodeData = new object[]
						{
							parserGrammarErrorData[0],
							parserGrammarErrorData,
							parserGrammarErrorData[2],
							parserGrammarErrorData[3],
							parserGrammarErrorData[4]
						};
						this.DError.AppendNode(nodeData, -1);
						num++;
					}
					while (num < array.Length);
				}
				this.DError.EndUnboundLoad();
			}
		}

		internal void SetProjectSpecificButtonsState([MarshalAs(UnmanagedType.U1)] bool A_0)
		{
			List<BarItem>.Enumerator enumerator = this.ProjectOnlyButtons.GetEnumerator();
			if (enumerator.MoveNext())
			{
				do
				{
					enumerator.Current.Enabled = A_0;
				}
				while (enumerator.MoveNext());
			}
			if (this.Platforms.Count > 0 && A_0)
			{
				this.InjectCurrentProjectButton.Enabled = true;
			}
			else if (this.Platforms.Count > 0 && !A_0)
			{
				this.InjectCurrentProjectButton.Enabled = false;
			}
		}

		internal void SetProjectDebug([MarshalAs(UnmanagedType.U1)] bool A_0)
		{
			GSXProject activeProject = this.ActiveProject;
			if (activeProject != null)
			{
				activeProject.Unsaved = true;
				this.ActiveProject.Debug = A_0;
			}
		}

		internal void LoadBuildItems()
		{
			GSXProject activeProject = this.ActiveProject;
			if (activeProject != null)
			{
				string editValue;
				if (activeProject.Debug)
				{
					editValue = "Debug";
				}
				else
				{
					editValue = "Release";
				}
				this.BuildMode.EditValue = editValue;
				this.TargetPlatform.EditValue = "Console";
			}
		}

		internal static List<byte> GetDefaultProjectData()
		{
			List<byte> list = new List<byte>();
			list.Add(1);
			list.Add(2);
			list.Add(1);
			list.AddRange(IDE.Utility.BytesFromString("Created in GSX Studio!"));
			return list;
		}

		internal void ProjectSettingsWindow()
		{
			GSXProject activeProject = this.ActiveProject;
			if (activeProject != null && new EditProjectSettings(activeProject).ShowDialog() == DialogResult.OK)
			{
				this.SaveProjectFile();
			}
		}

		internal void AddDefaultMethodAutoCompleteItem(string name, string Description, string TTTitle)
		{
			AutocompleteItem autocompleteItem = new AutocompleteItem();
			autocompleteItem.Text = name;
			autocompleteItem.ToolTipText = Description;
			autocompleteItem.ToolTipTitle = TTTitle;
			autocompleteItem.ImageIndex = 0;
			this.UniversalACItems.Add(autocompleteItem);
		}

		internal void AddDefaultKeywordAutoCompleteItem(string name, string Description, string TTTitle)
		{
			AutocompleteItem autocompleteItem = new AutocompleteItem();
			autocompleteItem.Text = name;
			autocompleteItem.ToolTipText = Description;
			autocompleteItem.ToolTipTitle = TTTitle;
			autocompleteItem.ImageIndex = 1;
			this.UniversalACItems.Add(autocompleteItem);
		}

		internal void AddDefaultAutoComplete()
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("defaultitems.txt");
			StreamReader streamReader = new StreamReader(manifestResourceStream);
			string[] array = streamReader.ReadToEnd().Split(new char[]
			{
				'\n',
				'\r'
			});
			int num = 0;
			if (0 < array.Length)
			{
				do
				{
					string[] array2 = array[num].Split(new char[]
					{
						':'
					});
					int num2 = array2.Length;
					if (num2 == 1)
					{
						string text = array2[0];
						this.AddDefaultMethodAutoCompleteItem(text, "Built in Method", text);
					}
					else if (num2 > 2)
					{
						this.AddDefaultMethodAutoCompleteItem(array2[0], array2[2], array2[1]);
					}
					num++;
				}
				while (num < array.Length);
			}
			streamReader.Close();
			manifestResourceStream.Close();
			Stream manifestResourceStream2 = Assembly.GetExecutingAssembly().GetManifestResourceStream("Keywords.txt");
			StreamReader streamReader2 = new StreamReader(manifestResourceStream2);
			string[] array3 = streamReader2.ReadToEnd().Split(new char[]
			{
				'\n',
				'\r'
			});
			int num3 = 0;
			if (0 < array3.Length)
			{
				do
				{
					string[] array4 = array3[num3].Split(new char[]
					{
						':'
					});
					int num4 = array4.Length;
					if (num4 == 1)
					{
						string text2 = array4[0];
						this.AddDefaultKeywordAutoCompleteItem(text2, "Keyword", text2);
					}
					else if (num4 > 2)
					{
						this.AddDefaultKeywordAutoCompleteItem(array4[0], array4[2], array4[1]);
					}
					num3++;
				}
				while (num3 < array3.Length);
			}
			streamReader2.Close();
			manifestResourceStream2.Close();
			if (streamReader2 != null)
			{
				((IDisposable)streamReader2).Dispose();
			}
			if (manifestResourceStream2 != null)
			{
				((IDisposable)manifestResourceStream2).Dispose();
			}
		}

		internal void SetUndockable(string panel)
		{
			this.Undockables.Add(panel);
		}

		internal void BuildProject([MarshalAs(UnmanagedType.U1)] bool debug, PlatformTarget target)
		{
			if (this.CompilationWorker.IsBusy || this.SyntaxWorker.IsBusy)
			{
				this.InjectPostBuild = false;
				IDE.Print("Build in progress", "Error", this.DOutput);
			}
			else
			{
				this.StatusLabel.Caption = "Build Started...";
				this.SDebug = debug;
				this.SCurrentTarget = target;
				this.ClearErrorConsole();
				this.DError.BeginUnboundLoad();
				this.ActiveScript.SyncEditorContents();
				this.errorscripts = new List<GSCScript>();
				List<GSCScript>.Enumerator enumerator = this.ActiveProject.ProjectFiles.GetEnumerator();
				if (enumerator.MoveNext())
				{
					do
					{
						GSCScript gscscript = enumerator.Current;
						gscscript.ScriptInfo.TypestrictState = (int)this.ActiveProject.TypeStrictState;
						gscscript.ScriptInfo.InlineState = (int)this.ActiveProject.InlineState;
						gscscript.ScriptInfo.Debug = this.ActiveProject.Debug;
					}
					while (enumerator.MoveNext());
				}
				this.SyntaxWorker.RunWorkerAsync();
			}
		}

		internal void DisplayBuildSettings()
		{
		}

		internal object RepairProject()
		{
			try
			{
				foreach (GSCScript gscscript in this.ActiveProject.ProjectFiles)
				{
					GSCScript activeScript = this.ActiveScript;
					if (activeScript != null && activeScript == gscscript && activeScript.Linked)
					{
						gscscript.SyncEditorContents();
					}
					foreach (GSCPart gscpart in gscscript.ScriptFiles)
					{
						string text = this.RepairSlashes(gscpart.Contents);
						gscpart.Contents = text;
						gscpart.Contents = this.RepairFunctionRefs(text);
						gscpart.Modified = true;
						if (gscscript.Linked && gscscript.Links.ContainsKey(gscpart))
						{
							gscscript.Links[gscpart].Editor.Clear();
							gscscript.Links[gscpart].Editor.AppendText(gscpart.Contents);
							gscscript.Links[gscpart].Editor.ClearUndo();
						}
					}
				}
				this.ActiveProject.Unsaved = true;
			}
			finally
			{
			}
			return 1;
		}

		internal void RepairProjectWrapper()
		{
			if (!this.RepairWorker.IsBusy)
			{
				this.StatusLabel.Caption = "Repairing Project...";
				this.RepairWorker.RunWorkerAsync();
			}
		}

		internal List<AutocompleteItem> GetDefaultAutoCompletes()
		{
			if (this.UniversalACItems.Count > 0)
			{
				return this.UniversalACItems;
			}
			this.AddDefaultAutoComplete();
			return this.UniversalACItems;
		}

		internal List<AutocompleteItem> LoadAutoCompleteItems()
		{
			this.GetDefaultAutoCompletes();
			this.ActiveScript.Autos.Clear();
			this.ActiveScript.Autos.AddRange(this.UniversalACItems);
			List<GSCPart>.Enumerator enumerator = this.ActiveScript.ScriptFiles.GetEnumerator();
			if (enumerator.MoveNext())
			{
				do
				{
					GSCPart gscpart = enumerator.Current;
					if (gscpart.Tree == null)
					{
						GSCCompiler.CheckSyntax(out gscpart.Tree, gscpart.Contents, gscpart.Name);
					}
					gscpart.GetFunctionsList();
					this.ActiveScript.Autos.AddRange(gscpart.FunctionsACList);
				}
				while (enumerator.MoveNext());
			}
			return this.ActiveScript.Autos;
		}

		internal string RepairSlashes(string A_0)
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Paths.txt");
			StreamReader streamReader = new StreamReader(manifestResourceStream);
			string text = streamReader.ReadToEnd();
			if (manifestResourceStream != null)
			{
				((IDisposable)manifestResourceStream).Dispose();
			}
			if (streamReader != null)
			{
				((IDisposable)streamReader).Dispose();
			}
			char[] separator = new char[]
			{
				'\n'
			};
			string[] array = text.Replace("\r", "").Split(separator);
			int num = 0;
			if (0 < array.Length)
			{
				do
				{
					array[num] = array[num].Replace("\\", "/");
					array[num] = array[num].Replace(".gsc", "");
					array[num] = array[num].Replace(".csc", "");
					num++;
				}
				while (num < array.Length);
			}
			int num2 = 0;
			if (0 < array.Length)
			{
				do
				{
					string text2 = array[num2];
					string newValue = text2.Replace("/", "\\");
					A_0 = A_0.Replace(text2, newValue);
					num2++;
				}
				while (num2 < array.Length);
			}
			return A_0;
		}

		internal string RepairFunctionRefs(string A_0)
		{
			return A_0;
		}

		private static bool TryReleasePlatforms(List<XPlatform> platforms, Action<XPlatform> restore,
			Func<XPlatform, bool> disconnect, out string error)
		{
			error = null;
			foreach (XPlatform platform in platforms)
			{
				if (platform == null)
				{
					error = "A previous target platform is missing.";
					return false;
				}
				try { restore(platform); }
				catch (Exception ex)
				{
					error = "Unable to restore scripts on " + platform.PlatformID + ": " + ex.Message;
					return false;
				}
			}
			foreach (XPlatform platform in platforms.ToArray())
			{
				try
				{
					if (!disconnect(platform))
					{
						error = "Unable to disconnect from " + platform.PlatformID + ".";
						return false;
					}
				}
				catch (Exception ex)
				{
					error = "Unable to disconnect from " + platform.PlatformID + ": " + ex.Message;
					return false;
				}
				platforms.Remove(platform);
			}
			return true;
		}

		internal void ConnectToPlatform(XPlatformType platformid)
		{
			if (this.CompilationWorker.IsBusy || this.SyntaxWorker.IsBusy)
			{
				IDE.Print("Wait for the current build to finish before changing the connection.", "Platform Connection Error", this.DOutput);
				return;
			}
			string releaseError;
			if (!TryReleasePlatforms(this.Platforms, GSXInjector.ResetScriptParseTree, p => p.Disconnect(), out releaseError))
			{
				IDE.Print(releaseError, "Platform Connection Error", this.DOutput);
				NotifyDialog releaseDialog = new NotifyDialog();
				releaseDialog.Message.Text = releaseError;
				releaseDialog.Text = "Platform Connection Error";
				releaseDialog.ShowDialog();
				((IDisposable)releaseDialog).Dispose();
				return;
			}
			XPlatform xplatform = new XPlatform();
			xplatform.PlatformID = platformid;
			if (xplatform.Connect())
			{
				this.Platforms.Add(xplatform);
				NotifyDialog notifyDialog = new NotifyDialog();
				notifyDialog.Message.Text = "Connected to the platform successfully!";
				notifyDialog.Text = "Platform Connection";
				notifyDialog.ShowDialog();
				List<BarItem>.Enumerator enumerator = this.InjectButtons.GetEnumerator();
				if (enumerator.MoveNext())
				{
					do
					{
						enumerator.Current.Enabled = true;
					}
					while (enumerator.MoveNext());
				}
				if (this.ActiveProject != null)
				{
					this.InjectCurrentProjectButton.Enabled = true;
				}
				if (notifyDialog != null)
				{
					((IDisposable)notifyDialog).Dispose();
				}
			}
			else
			{
				if (this.Platforms.Count == 0)
				{
					List<BarItem>.Enumerator enumerator2 = this.InjectButtons.GetEnumerator();
					if (enumerator2.MoveNext())
					{
						do
						{
							enumerator2.Current.Enabled = false;
						}
						while (enumerator2.MoveNext());
					}
					this.InjectCurrentProjectButton.Enabled = false;
				}
				NotifyDialog notifyDialog2 = new NotifyDialog();
				notifyDialog2.Message.Text = string.IsNullOrEmpty(xplatform.LastError)
					? "Unable to connect to platform!"
					: "Unable to connect to platform: " + xplatform.LastError;
				notifyDialog2.Text = "Platform Connection Error";
				notifyDialog2.ShowDialog();
				if (notifyDialog2 != null)
				{
					((IDisposable)notifyDialog2).Dispose();
				}
			}
		}

		internal void InjectExternalScripts()
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			folderBrowserDialog.Description = "Select a folder to inject (maps/mp/...)";
			folderBrowserDialog.ShowNewFolderButton = false;
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				string text = folderBrowserDialog.SelectedPath.ToLower().Replace('\\', '/');
				if (text.IndexOf("maps/mp") < 0)
				{
					if (Directory.Exists(Path.Combine(text, "maps/mp")))
					{
						text = Path.Combine(text, "maps/mp").ToLower().Replace('\\', '/');
					}
					else if (Directory.Exists(Path.Combine(text, "mp")))
					{
						text = Path.Combine(text, "mp").ToLower().Replace('\\', '/');
					}
				}
				if (text.IndexOf("maps/mp") >= 0)
				{
					List<string> gscfromDir = GSXInjector.GetGSCFromDir(text);
					List<GSXInjector.IGSCFile> list = new List<GSXInjector.IGSCFile>();
					List<string>.Enumerator enumerator = gscfromDir.GetEnumerator();
					if (enumerator.MoveNext())
					{
						do
						{
							string text2 = enumerator.Current;
							List<GSXInjector.IGSCFile> list2 = list;
							string text3 = text2;
							list2.Add(GSXInjector.GetIGSCFromInfo(text3, GSXInjector.ScriptNameFromPath(text3)));
						}
						while (enumerator.MoveNext());
					}
					this.InjectScriptsInternal(list.ToArray(), this.Platforms.ToArray());
				}
				else
				{
					IDE.Print("The selected folder is invalid. Please select a maps/mp folder to inject", "Injection Error", this.DOutput);
				}
			}
			else
			{
				IDE.Print("User canceled operation", "Failed to Inject", this.DOutput);
			}
		}

		internal void InjectPackage()
		{
		}

		internal void InjectCurrentProject([MarshalAs(UnmanagedType.U1)] bool debug)
		{
			this.InjectPostBuild = true;
			bool flag = false;
			bool flag2 = false;
			List<XPlatform>.Enumerator enumerator = this.Platforms.GetEnumerator();
			if (enumerator.MoveNext())
			{
				do
				{
					switch (enumerator.Current.PlatformID)
					{
					case XPlatformType.PLATFORM_PS3_CCAPI:
					case XPlatformType.PLATFORM_PS3_TMAPI:
					case XPlatformType.PLATFORM_XBOX360:
						flag2 = true;
						break;
					case XPlatformType.PLATFORM_PC_REDACTED:
					case XPlatformType.PLATFORM_PC_STEAM:
						flag = true;
						break;
					}
				}
				while (enumerator.MoveNext());
				if (flag)
				{
					if (flag2)
					{
						this.BuildProject(debug, PlatformTarget.Package);
						return;
					}
					this.BuildProject(debug, PlatformTarget.PC);
					return;
				}
				else if (flag2)
				{
					this.BuildProject(debug, PlatformTarget.Console);
					return;
				}
			}
			this.InjectPostBuild = false;
			IDE.Print("No platforms are connected... Stopping injection process.", "Injection", this.DOutput);
		}

		private static string InjectionPreflightError(GSXInjector.IGSCFile[] scripts, XPlatform[] platforms)
		{
			if (scripts == null || scripts.Length == 0)
				return "No compiled scripts were found; injection was stopped.";
			if (platforms == null || platforms.Length == 0)
				return "No platforms are connected; injection was stopped.";
			foreach (GSXInjector.IGSCFile script in scripts)
			{
				if (script == null || script.Bytes == null || script.Bytes.Length == 0 || string.IsNullOrEmpty(script.ScriptName))
					return "A compiled script could not be read; injection was stopped.";
			}
			bool hasXbox = false;
			bool hasOtherPlatform = false;
			foreach (XPlatform platform in platforms)
			{
				if (platform == null)
					return "A target platform is unavailable; injection was stopped.";
				if (platform.PlatformID == XPlatformType.PLATFORM_XBOX360)
					hasXbox = true;
				else
					hasOtherPlatform = true;
			}
			if (hasXbox && hasOtherPlatform)
				return "Inject into the Xbox separately from other platforms.";
			return null;
		}

		private static bool ConfirmXboxInjection(XPlatform[] platforms, Func<DialogResult> prompt, out bool allowUnverifiedXbox)
		{
			allowUnverifiedXbox = false;
			foreach (XPlatform platform in platforms)
			{
				if (platform.PlatformID == XPlatformType.PLATFORM_XBOX360)
				{
					allowUnverifiedXbox = prompt() == DialogResult.Yes;
					return allowUnverifiedXbox;
				}
			}
			return true;
		}

		internal void InjectScriptsInternal(GSXInjector.IGSCFile[] scripts, XPlatform[] platforms)
		{
			string preflightError = InjectionPreflightError(scripts, platforms);
			if (preflightError != null)
			{
				IDE.Print(preflightError, "Injection Error", this.DOutput);
				return;
			}
			bool allowUnverifiedXbox;
			if (!ConfirmXboxInjection(platforms, () => MessageBox.Show(
				"The Xbox game memory layout and injection region have not been verified. Injecting may crash the game or corrupt game memory. " +
				"Xbox custom and internal functions are unavailable, and string reduction will be skipped. Stay in the pregame lobby until injection finishes.\n\nDo you want to attempt script injection?",
				"Confirm Xbox injection", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2), out allowUnverifiedXbox))
			{
				IDE.Print("Xbox injection cancelled.", "Injection", this.DOutput);
				return;
			}
			IDE.Print("Injection Started", "Injection", this.DOutput);
			int num = 0;
			if (0 < platforms.Length)
			{
				do
				{
					XPlatform xplatform = platforms[num];
					if (!xplatform.IsOptimized())
					{
						if (xplatform.PlatformID == XPlatformType.PLATFORM_XBOX360)
							IDE.Print("Xbox string reduction is unavailable for this injection.", "Injection", this.DOutput);
						else
						{
							IDE.Print("(" + xplatform.PlatformID + ") Attempting string reduction...", "Injection", this.DOutput);
							xplatform.TryOptimize(scripts);
							IDE.Print("(" + xplatform.PlatformID + ") String reduction attempted; completion was not verified.", "Injection", this.DOutput);
						}
					}
					num++;
				}
				while (num < platforms.Length);
			}
			string[] array = GSXInjector.InjectGSCS(scripts, platforms, allowUnverifiedXbox).ToArray();
			int num2 = array.Length;
			if (num2 != 0)
			{
				int num3 = 0;
				if (0 < num2)
				{
					do
					{
						IDE.Print(array[num3], "Injection Error", this.DOutput);
						num3++;
					}
					while (num3 < array.Length);
				}
			}
			else
			{
				IDE.Print("Injection Successful", "Injection", this.DOutput);
			}
		}

		internal void InjectPackageInternal(string filename)
		{
		}

		internal GSXInjector.IGSCFile[] IGSCListFromDirectory(string TargetDirectory)
		{
			string text = TargetDirectory.Replace('\\', '/');
			if (text.IndexOf("maps/mp") < 0)
			{
				if (Directory.Exists(Path.Combine(text, "maps/mp")))
				{
					text = Path.Combine(text, "maps/mp").ToLower().Replace('\\', '/');
				}
				else if (Directory.Exists(Path.Combine(TargetDirectory, "mp")))
				{
					text = Path.Combine(text, "mp").ToLower().Replace('\\', '/');
				}
			}
			if (text.IndexOf("maps/mp") >= 0)
			{
				List<string> gscfromDir = GSXInjector.GetGSCFromDir(TargetDirectory);
				List<GSXInjector.IGSCFile> list = new List<GSXInjector.IGSCFile>();
				List<string>.Enumerator enumerator = gscfromDir.GetEnumerator();
				if (enumerator.MoveNext())
				{
					do
					{
						string text2 = enumerator.Current;
						List<GSXInjector.IGSCFile> list2 = list;
						string text3 = text2;
						list2.Add(GSXInjector.GetIGSCFromInfo(text3, GSXInjector.ScriptNameFromPath(text3)));
					}
					while (enumerator.MoveNext());
				}
				return list.ToArray();
			}
			IDE.Print("The selected folder is invalid. Please select a maps/mp folder to inject", "Injection Error", this.DOutput);
			return null;
		}

		internal Intellisense.ScriptInfo DeriveScriptInfo()
		{
			GSCScript activeScript = this.ActiveScript;
			if (activeScript == null)
			{
				return null;
			}
			activeScript.ScriptInfo.TypestrictState = (int)this.ActiveProject.TypeStrictState;
			this.ActiveScript.ScriptInfo.InlineState = (int)this.ActiveProject.InlineState;
			this.ActiveScript.ScriptInfo.Debug = this.ActiveProject.Debug;
			return this.ActiveScript.ScriptInfo;
		}

		internal GSCPart GetActivePart()
		{
			return null;
		}

		internal XEditor GetGSXEditor(string contents, IDE ths)
		{
			XEditor xeditor = new XEditor(this.EditorImagesList, this.GetDefaultAutoCompletes());
			xeditor.Editor.AppendText(contents);
			xeditor.Editor.TextChangedDelayed += this.OnXTextChangedDelayed;
			xeditor.Editor.ClearUndo();
			return xeditor;
		}

		internal OpenFileDialog GetGSXProjectSelectorHandle()
		{
			return this.GSXProjectSelector;
		}

		internal ParseTree ScriptParseTree(GSCScript script)
		{
			string text = "";
			List<GSCPart>.Enumerator enumerator = script.ScriptFiles.GetEnumerator();
			if (enumerator.MoveNext())
			{
				do
				{
					GSCPart gscpart = enumerator.Current;
					text += gscpart.Contents + "\n\n";
				}
				while (enumerator.MoveNext());
			}
			return this.GSXParser.Parse(text, script.Name);
		}

		internal void OnMouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.Explorer.ExpandAll();
			}
		}

		internal void OnDMDocumentActivated(object sender, DocumentEventArgs e)
		{
			if (!this.UnboundWindowTransition)
			{
				GSCScript activeScript = this.ActiveScript;
				if (activeScript != null)
				{
					this.UnboundWindowTransition = true;
					this.ActivePart = null;
					foreach (GSCPart gscpart in activeScript.ScriptFiles)
					{
						if (gscpart.Name.Replace(".gsx", "") == ((DockPanel)e.Document.Control).Text.Replace("*", ""))
						{
							this.ActivePart = gscpart;
							foreach (TreeListNode treeListNode in this.ActiveScript.Node.Nodes)
							{
								if (treeListNode.GetValue(0) != null && treeListNode.GetValue(0).GetType() == typeof(ExplorerPartWrapper) && ((ExplorerPartWrapper)treeListNode.GetValue(0)).Script == gscpart)
								{
									this.Explorer.FocusedNode = treeListNode;
									break;
								}
							}
							break;
						}
					}
					this.ResetTimerInterval();
					this.UnboundWindowTransition = false;
				}
			}
		}

		internal void OnFloatActivated(object sender, EventArgs e)
		{
		}

		internal void OnDocumentAdded(object sender, DocumentEventArgs e)
		{
			e.Document.Properties.AllowFloat = DefaultBoolean.False;
			try
			{
				if ((DockPanel)e.Document.Control != null)
				{
					((DockPanel)e.Document.Control).Options.AllowFloating = false;
				}
			}
			catch (Exception)
			{
			}
		}

		internal void OnXTextChangedDelayed(object sender, TextChangedEventArgs e)
		{
			if (this.ActiveProject != null)
			{
				GSCScript activeScript = this.ActiveScript;
				if (activeScript != null && activeScript.Linked && this.ActivePart != null && (!(e.ChangedRange.Text == ((FastColoredTextBox)sender).Text) || ((FastColoredTextBox)sender).Text.Length <= 0))
				{
					this.ResetTimerInterval();
					this.StatusLabel.Caption = "Ready";
					try
					{
						if (!this.ActivePart.Modified && this.ActivePart.Contents != ((FastColoredTextBox)sender).Text)
						{
							this.ActivePart.Modified = true;
							this.ActiveProject.UpdateModified();
							this.ActiveScript.WindowLinks[this.ActivePart].Text = this.ActivePart.Name.Substring(0, this.ActivePart.Name.Length - 4) + "*";
						}
						else if (this.ActivePart.Contents == ((FastColoredTextBox)sender).Text)
						{
							this.ActivePart.Modified = false;
							this.ActiveProject.UpdateModified();
							this.ActiveScript.WindowLinks[this.ActivePart].Text = this.ActivePart.Name.Substring(0, this.ActivePart.Name.Length - 4);
						}
					}
					catch (Exception)
					{
					}
				}
			}
		}

		internal void OnSyntaxTick(object sender, EventArgs e)
		{
			this.SyntaxTimer.Stop();
			if (this.ActiveProject != null)
			{
				GSCScript activeScript = this.ActiveScript;
				if (activeScript != null && activeScript.Linked)
				{
					GSCPart activePart = this.ActivePart;
					if (activePart != null && activeScript.Links.ContainsKey(activePart))
					{
						this.SmartCheckFileSyntax();
						if (this.ActivePart.Tree.ParserMessages.Count <= 0)
						{
							this.SmartCheckFileGrammar();
							this.ActiveScript.Links[this.ActivePart].SetAutoCompleteItems(this.LoadAutoCompleteItems());
						}
					}
				}
			}
		}

		internal void OnDMBeginDocking(object sender, DocumentCancelEventArgs e)
		{
			if (this.Undockables.Contains(e.Document.ControlName))
			{
				e.Cancel = true;
			}
		}

		internal void OnDMBeginDocumentsHostDocking(object sender, DocumentCancelEventArgs e)
		{
		}

		internal void OnCWDoWork(object sender, DoWorkEventArgs e)
		{
			e.Result = this.Compiler.CompileScripts();
			if (((BackgroundWorker)sender).CancellationPending)
			{
				e.Cancel = true;
			}
		}

		internal void SyntaxDoWork(object sender, DoWorkEventArgs e)
		{
			List<Intellisense.ParserErrorData> list = new List<Intellisense.ParserErrorData>();
			List<GSCScript>.Enumerator enumerator = this.ActiveProject.ProjectFiles.GetEnumerator();
			if (enumerator.MoveNext())
			{
				do
				{
					GSCScript gscscript = enumerator.Current;
					this.SyntaxWorker.ReportProgress(1, gscscript.Name);
					List<GSCPart>.Enumerator enumerator2 = gscscript.ScriptFiles.GetEnumerator();
					if (enumerator2.MoveNext())
					{
						do
						{
							GSCPart gscpart = enumerator2.Current;
							list.AddRange(GSCCompiler.CheckSyntax(out gscpart.Tree, gscpart.Contents, gscpart.Name));
						}
						while (enumerator2.MoveNext());
					}
				}
				while (enumerator.MoveNext());
			}
			this.SyntaxWorker.ReportProgress(0, list);
		}

		private static bool ShouldInjectAfterBuild(RunWorkerCompletedEventArgs e, int expectedScripts)
		{
			return e != null && e.Error == null && !e.Cancelled && expectedScripts > 0 &&
				e.Result is int && (int)e.Result == expectedScripts;
		}

		internal void OnCWRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.StatusLabel.Caption = "Ready";
			bool injectRequested = this.InjectPostBuild;
			this.InjectPostBuild = false;
			if (e.Error != null)
			{
				IDE.Print("Build failed: " + e.Error.GetBaseException().Message, "Build", this.DOutput);
				return;
			}
			if (e.Cancelled)
			{
				IDE.Print("Build cancelled; no scripts were injected.", "Build", this.DOutput);
				return;
			}
			if (!(e.Result is int) || this.Compiler == null || this.Compiler.Package == null)
			{
				IDE.Print("Build did not return a valid result; injection was stopped.", "Build", this.DOutput);
				return;
			}
			CompilationPackage package = this.Compiler.Package;
			int count = package.Scripts.Count;
			int succeeded = (int)e.Result;
			IDE.Print(succeeded + " succeeded, " + (count - succeeded) + " failed", "Build", this.DOutput);
			if (!injectRequested)
				return;
			if (!ShouldInjectAfterBuild(e, count))
			{
				IDE.Print("Build was incomplete; no scripts were injected.", "Injection Error", this.DOutput);
				return;
			}
			if (package.Target != PlatformTarget.Console && package.Target != PlatformTarget.PC)
			{
				IDE.Print("Package injection is not implemented.", "Injection Error", this.DOutput);
				return;
			}
			this.InjectScriptsInternal(this.IGSCListFromDirectory(Path.Combine(package.OutputDirectory, "maps", "mp")), this.Platforms.ToArray());
		}

		internal void OnSyntaxRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			if (e.Error != null || e.Cancelled)
			{
				this.InjectPostBuild = false;
				this.StatusLabel.Caption = "Ready";
				IDE.Print(e.Cancelled ? "Syntax check cancelled." : "Syntax check failed: " + e.Error.GetBaseException().Message, "Build", this.DOutput);
				return;
			}
			if (this.errorscripts.Count != 0)
			{
				this.InjectPostBuild = false;
				this.StatusLabel.Caption = "Ready";
				IDE.Print("Syntax check failed", "Build", this.DOutput);
			}
			else
			{
				CompilationPackage compilationPackage = new CompilationPackage();
				compilationPackage.Debug = this.SDebug;
				compilationPackage.Target = this.SCurrentTarget;
				compilationPackage.ProjectName = this.ActiveProject.ProjectName;
				compilationPackage.CreatorName = this.ActiveProject.CreatorName;
				compilationPackage.OutputDirectory = this.ProjectsLocation + Path.DirectorySeparatorChar + this.ActiveProject.ProjectName + Path.DirectorySeparatorChar + "Output" + Path.DirectorySeparatorChar;
				compilationPackage.Optimize = this.OptimizeScripts;
				compilationPackage.OptimizeChildren = this.OptimizeChildren;
				compilationPackage.Symbolize = this.Symbolize;
				if (!Directory.Exists(compilationPackage.OutputDirectory))
				{
					Directory.CreateDirectory(compilationPackage.OutputDirectory);
				}
				PlatformTarget scurrentTarget = this.SCurrentTarget;
				if (scurrentTarget != PlatformTarget.Console)
				{
					if (scurrentTarget != PlatformTarget.PC)
					{
						if (scurrentTarget == PlatformTarget.Package)
						{
							CompilationPackage compilationPackage2 = compilationPackage;
							compilationPackage2.OutputDirectory += "Package";
						}
					}
					else
					{
						CompilationPackage compilationPackage3 = compilationPackage;
						compilationPackage3.OutputDirectory += "PC";
					}
				}
				else
				{
					CompilationPackage compilationPackage4 = compilationPackage;
					compilationPackage4.OutputDirectory += "Console";
				}
				try
				{
					if (Directory.Exists(compilationPackage.OutputDirectory))
					{
						DirectoryInfo directoryInfo = new DirectoryInfo(compilationPackage.OutputDirectory);
						foreach (FileInfo fileInfo in directoryInfo.GetFiles())
						{
							fileInfo.Delete();
						}
						foreach (DirectoryInfo directoryInfo2 in directoryInfo.GetDirectories())
						{
							directoryInfo2.Delete(true);
						}
					}
					else
					{
						Directory.CreateDirectory(compilationPackage.OutputDirectory);
					}
				}
				catch (Exception)
				{
					this.StatusLabel.Caption = "Ready";
					this.InjectPostBuild = false;
					string a_ = "Build";
					IDE.Print("Error creating the output directory for compilation. Directory is in use", a_, this.DOutput);
					return;
				}
				compilationPackage.WaterMark = this.ActiveProject.Watermark;
				List<GSCScript>.Enumerator enumerator = this.ActiveProject.ProjectFiles.GetEnumerator();
				if (enumerator.MoveNext())
				{
					do
					{
						GSCScript gscscript = enumerator.Current;
						if (!this.errorscripts.Contains(gscscript))
						{
							CompilationScript compilationScript = new CompilationScript();
							compilationScript.ScriptName = gscscript.Name;
							compilationScript.ScriptContents = "";
							List<GSCPart>.Enumerator enumerator2 = gscscript.ScriptFiles.GetEnumerator();
							if (enumerator2.MoveNext())
							{
								do
								{
									GSCPart gscpart = enumerator2.Current;
									if (gscpart.Name.ToLower() == "main.gsx" || gscpart.Name.ToLower() == "main")
									{
										CompilationScript compilationScript2 = compilationScript;
										compilationScript2.ScriptContents += gscpart.Contents + "\n";
									}
								}
								while (enumerator2.MoveNext());
							}
							List<GSCPart>.Enumerator enumerator3 = gscscript.ScriptFiles.GetEnumerator();
							if (enumerator3.MoveNext())
							{
								do
								{
									GSCPart gscpart2 = enumerator3.Current;
									if (gscpart2.Name.ToLower() != "main.gsx" && gscpart2.Name.ToLower() != "main")
									{
										CompilationScript compilationScript3 = compilationScript;
										compilationScript3.ScriptContents += gscpart2.Contents + "\n";
									}
								}
								while (enumerator3.MoveNext());
							}
							compilationPackage.Scripts.Add(compilationScript);
						}
					}
					while (enumerator.MoveNext());
				}
				Compiler compiler = new Compiler(compilationPackage);
				this.Compiler = compiler;
				compiler.Worker = this.CompilationWorker;
				this.CompilationWorker.RunWorkerAsync();
			}
		}

		internal void OnCWProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			if (e.UserState != null)
			{
				string a_ = "Build";
				IDE.Print(e.UserState.ToString(), a_, this.DOutput);
			}
			this.StatusLabel.Caption = "Building... (" + e.ProgressPercentage + " of " + this.Compiler.Package.Scripts.Count + ")";
		}

		internal void SyntaxProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			int progressPercentage = e.ProgressPercentage;
			if (progressPercentage != 0)
			{
				if (progressPercentage == 1)
				{
					string a_ = "Build";
					IDE.Print("Checking Syntax of " + (string)e.UserState, a_, this.DOutput);
				}
			}
			else
			{
				List<Intellisense.ParserErrorData>.Enumerator enumerator = ((List<Intellisense.ParserErrorData>)e.UserState).GetEnumerator();
				if (enumerator.MoveNext())
				{
					do
					{
						Intellisense.ParserErrorData parserErrorData = enumerator.Current;
						object[] nodeData = new object[]
						{
							parserErrorData[0],
							parserErrorData,
							parserErrorData[2],
							parserErrorData[3],
							parserErrorData[4]
						};
						this.DError.AppendNode(nodeData, -1);
					}
					while (enumerator.MoveNext());
				}
				this.DError.EndUnboundLoad();
				List<GSCScript>.Enumerator enumerator2 = this.errorscripts.GetEnumerator();
				if (enumerator2.MoveNext())
				{
					do
					{
						GSCScript gscscript = enumerator2.Current;
						string a_2 = "Build";
						IDE.Print(gscscript.Name + " failed to build!", a_2, this.DOutput);
					}
					while (enumerator2.MoveNext());
				}
			}
		}

		internal void OnRWDoWork(object sender, DoWorkEventArgs e)
		{
			e.Result = this.RepairProject();
		}

		internal void OnRWRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			NotifyDialog notifyDialog = new NotifyDialog();
			notifyDialog.Text = "Project Repair Completed";
			notifyDialog.Message.Text = "Project Repair has completed sucessfully";
			notifyDialog.ShowDialog();
			if (notifyDialog != null)
			{
				((IDisposable)notifyDialog).Dispose();
			}
			this.StatusLabel.Caption = "Ready";
		}

		static IDE()
		{
			IDE.ICON_METHOD = 0;
		}

		public static int ICON_METHOD = 0;

		public static int ICON_KEYWORD = 1;

		public List<GSCScript> errorscripts;

		public bool OptimizeScripts = true;

		public bool OptimizeChildren = false;

		public bool Symbolize = true;

		public BarCheckItem Build_Scripts;

		public BarCheckItem Build_Children;

		public BarCheckItem Build_Symbolize;

		public RegistryKey GSXStudioRegistryKey;

		public BackgroundWorker SyntaxWorker;

		internal GSXProject ActiveProject;

		internal string ProjectsLocation;

		internal XParser ParserHandle;

		internal XParseLanguage LanguageDefinition;

		internal GSCScript ActiveScript;

		internal GSCPart ActivePart;

		internal Random r = new Random();

		internal DockManager DockingManager;

		internal PopupMenu ScriptRightClick;

		internal PopupMenu PartRightClick;

		internal PopupMenu SubgroupPopup;

		internal DockManager DManager;

		internal Control FormControl;

		internal Parser GSXParser;

		internal Timer SyntaxTimer;

		internal List<BarItem> ProjectOnlyButtons = new List<BarItem>();

		internal List<BarItem> InjectButtons = new List<BarItem>();

		internal BarItem InjectCurrentProjectButton;

		internal BarEditItem BuildMode;

		internal BarEditItem TargetPlatform;

		internal List<AutocompleteItem> UniversalACItems = new List<AutocompleteItem>();

		internal List<string> Undockables = new List<string>();

		internal BackgroundWorker CompilationWorker;

		internal BackgroundWorker RepairWorker;

		internal BarStaticItem StatusLabel;

		internal Compiler Compiler;

		internal PlatformTarget SCurrentTarget;

		internal bool SDebug;

		internal bool InjectPostBuild = false;

		internal List<XPlatform> Platforms;

		private OpenFileDialog GSXProjectSelector;

		private RichEditControl DOutput;

		private TreeList DError;

		private TreeList Explorer;

		private TabbedView DocumentManager;

		private ImageList EditorImagesList;

		private bool UnboundLoad = false;

		private bool UnboundWindowTransition = false;

		internal class Utility
		{
			[return: MarshalAs(UnmanagedType.U1)]
			public static bool ByteMatch(byte[] A_0, byte[] A_1)
			{
				int num = 0;
				int num2 = A_0.Length;
				int num3 = num2;
				if (0 < num3)
				{
					while (A_0[num] == A_1[num])
					{
						num++;
						if (num >= num3)
						{
							goto IL_1F;
						}
					}
					return false;
				}
				IL_1F:
				return ((num2 == A_1.Length) ? 1 : 0) != 0;
			}

			public static string StringFromBytes(List<byte> A_0, ref int A_1)
			{
				List<byte> list = new List<byte>();
				if (A_0[A_1] != 0)
				{
					int index;
					do
					{
						list.Add(A_0[A_1]);
						A_1++;
						index = A_1;
					}
					while (A_0[index] != 0);
				}
				string @string = Encoding.ASCII.GetString(list.ToArray());
				IDisposable disposable = list as IDisposable;
				if (disposable != null)
				{
					disposable.Dispose();
				}
				A_1++;
				return @string;
			}

			public static byte[] BytesFromString(string A_0)
			{
				List<byte> list = new List<byte>();
				int num = 0;
				if (0 < A_0.Length)
				{
					do
					{
						list.Add((byte)A_0[num]);
						num++;
					}
					while (num < A_0.Length);
				}
				list.Add(0);
				return list.ToArray();
			}

			public static void DeleteAllFilesAndDirectories(string path)
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(path);
				FileInfo[] files = directoryInfo.GetFiles();
				int num = 0;
				if (0 < files.Length)
				{
					do
					{
						files[num].Delete();
						num++;
					}
					while (num < files.Length);
				}
				DirectoryInfo[] directories = directoryInfo.GetDirectories();
				int num2 = 0;
				if (0 < directories.Length)
				{
					do
					{
						directories[num2].Delete(true);
						num2++;
					}
					while (num2 < directories.Length);
				}
				if (Directory.Exists(path))
				{
					Directory.Delete(path);
				}
			}
		}
	}
}
