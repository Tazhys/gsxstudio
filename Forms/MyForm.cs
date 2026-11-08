using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraRichEdit;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraTab;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using GSXCompilerLib;
using Microsoft.Win32;

namespace GSX_Studio
{
	public partial class MyForm : XtraForm
	{
		public void AddDefaultProject(IDE A_0)
		{
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
			RichEditControl newDefaultEditor = A_0.GetNewDefaultEditor(text.Replace("{VERSION}", FileVersionInfo.GetVersionInfo(Application.ExecutablePath).FileVersion.ToString()), A_0);
			newDefaultEditor.ReadOnly = true;
			this.dockPanel2_Container.Controls.Add(newDefaultEditor);
		}

        private bool initializingPreferences = true;

        public void InitUserProjects()
        {
            const string settingsPath = @"Software\Serious\GSX Studio";
            bool canSave = false;
            try
            {
                using (RegistryKey existing = Registry.CurrentUser.OpenSubKey(settingsPath, false))
                {
                    if (existing != null)
                    {
                        string location = existing.GetValue("Projects Location") as string;
                        if (!string.IsNullOrEmpty(location)) Manager.ProjectsLocation = location;
                        Manager.OptimizeScripts = ReadPreference(existing, "Optimize", Manager.OptimizeScripts);
                        Manager.OptimizeChildren = ReadPreference(existing, "OptimizeChildren", Manager.OptimizeChildren);
                        Manager.Symbolize = ReadPreference(existing, "Symbolize", Manager.Symbolize);
                    }
                }
            }
            catch (UnauthorizedAccessException) { }
            catch (System.Security.SecurityException) { }
            catch (IOException) { }

            try
            {
                RegistryKey writable = Registry.CurrentUser.CreateSubKey(settingsPath);
                if (writable != null)
                {
                    Manager.GSXStudioRegistryKey = writable;
                    if (writable.GetValue("Projects Location") == null)
                        writable.SetValue("Projects Location", Manager.ProjectsLocation);
                    if (writable.GetValue("Optimize") == null)
                        writable.SetValue("Optimize", Manager.OptimizeScripts ? 1 : 0, RegistryValueKind.DWord);
                    if (writable.GetValue("OptimizeChildren") == null)
                        writable.SetValue("OptimizeChildren", Manager.OptimizeChildren ? 1 : 0, RegistryValueKind.DWord);
                    if (writable.GetValue("Symbolize") == null)
                        writable.SetValue("Symbolize", Manager.Symbolize ? 1 : 0, RegistryValueKind.DWord);
                    canSave = true;
                }
            }
            catch (UnauthorizedAccessException) { }
            catch (System.Security.SecurityException) { }
            catch (IOException) { }

            Build_Scripts.Checked = Manager.OptimizeScripts;
            Build_Children.Checked = Manager.OptimizeChildren;
            Build_Symbolize.Checked = Manager.Symbolize;
            initializingPreferences = false;
            if (!canSave)
                IDE.Print("Settings cannot be saved in this session.", "Notification", Output);
        }

        private static bool ReadPreference(RegistryKey key, string name, bool fallback)
        {
            object value = key.GetValue(name);
            return value is int ? (int)value != 0 : fallback;
        }

        private void SavePreference(string name, bool value)
        {
            if (initializingPreferences || Manager.GSXStudioRegistryKey == null) return;
            try { Manager.GSXStudioRegistryKey.SetValue(name, value ? 1 : 0, RegistryValueKind.DWord); }
            catch (UnauthorizedAccessException) { }
            catch (System.Security.SecurityException) { }
            catch (IOException) { }
            catch (ObjectDisposedException) { }
        }

		public void InitializeForm(string[] args)
		{
			this.Output.MouseClick += this.OnOutputMouseClick;
			IDE.Print("Version " + FileVersionInfo.GetVersionInfo(Application.ExecutablePath).FileVersion, "Notification", this.Output);
			IDE ide = new IDE(this.Output, this.ErrorConsole, this.ProjectExplorer, this.tabbedView1, this.dockManager1);
			this.Manager = ide;
			this.AddDefaultProject(ide);
			this.Manager.ScriptRightClick = this.SRightClick;
			this.Manager.PartRightClick = this.PRightClick;
			this.Manager.FormControl = this;
			this.Manager.SubgroupPopup = this.SubgroupPopup;
			this.Manager.DManager = this.dockManager1;
			this.Manager.SyntaxTimer = this.SyntaxTimer;
			this.Manager.SetUpSyntaxTimer();
			this.Manager.InjectButtons.Add(this.barButtonItem21);
			this.Manager.InjectButtons.Add(this.barButtonItem68);
			this.Manager.InjectButtons.Add(this.barSubItem24);
			this.Manager.InjectCurrentProjectButton = this.barButtonItem27;
			this.Manager.ProjectOnlyButtons.Add(this.Toolbar_Save);
			this.Manager.ProjectOnlyButtons.Add(this.Toolbar_SaveAll);
			this.Manager.ProjectOnlyButtons.Add(this.DropDown_NewScript);
			this.Manager.ProjectOnlyButtons.Add(this.DropDown_Save);
			this.Manager.ProjectOnlyButtons.Add(this.DropDown_SaveAll);
			this.Manager.ProjectOnlyButtons.Add(this.DropDown_Close);
			this.Manager.ProjectOnlyButtons.Add(this.DropDown_PSettings);
			this.Manager.ProjectOnlyButtons.Add(this.DropDown_ConvertZ);
			this.Manager.ProjectOnlyButtons.Add(this.DropDown_ConvertM);
			this.Manager.ProjectOnlyButtons.Add(this.DropDown_BuildC);
			this.Manager.ProjectOnlyButtons.Add(this.DropDown_BuildPC);
			this.Manager.ProjectOnlyButtons.Add(this.DropDown_ProjectSub);
			this.Manager.ProjectOnlyButtons.Add(this.BuildMode);
			this.Manager.ProjectOnlyButtons.Add(this.BuildTarget);
			this.Manager.ProjectOnlyButtons.Add(this.ToolbarBuildProject);
			this.Manager.ProjectOnlyButtons.Add(this.ToolbarPSettings);
			this.Manager.ProjectOnlyButtons.Add(this.Tools_ProjectRepair);
			this.Manager.ProjectOnlyButtons.Add(this.Build_Scripts);
			this.Manager.ProjectOnlyButtons.Add(this.Build_Children);
			this.Manager.ProjectOnlyButtons.Add(this.Build_Symbolize);
			this.Manager.Build_Scripts = this.Build_Scripts;
			this.Manager.Build_Children = this.Build_Children;
			this.Manager.Build_Symbolize = this.Build_Symbolize;
			this.Manager.SetUndockable(this.ProjectPanel.Name);
			this.Manager.SetUndockable(this.OutputPanel.Name);
			this.Manager.SetUndockable(this.ErrorPanel.Name);
			this.Manager.BuildMode = this.BuildMode;
			this.Manager.TargetPlatform = this.BuildTarget;
			this.Manager.StatusLabel = this.StatusLabel;
			this.BuildMode.Edit.EditValueChanged += this.OnBuildEditValueChanged;
			this.BuildModeCombo.SelectedValueChanged += this.OnBuildSelectedValueChanged;
			this.InitUserProjects();
			if (args.Length > 0 && !(args[0].Substring(args[0].Length - 4) != ".gsxp"))
			{
				try
				{
					this.Manager.ActiveProject = GSXProject.LoadProject(args[0]);
					IDE manager = this.Manager;
					if (manager.ActiveProject == null)
					{
						manager.Print("Invalid filename.", "Error");
					}
					else
					{
						manager.ClearProjectWindows();
						this.Manager.LoadExplorerTree();
						this.Manager.SetProjectSpecificButtonsState(true);
						this.Manager.LoadBuildItems();
						manager = this.Manager;
						IDE ide2 = manager;
						ide2.Print(ide2.ActiveProject.ProjectName, "Loaded Project");
					}
				}
				catch (Exception ex)
				{
					IDE.Print("Failed to load project", "Error", this.Output);
				}
			}
		}

		public MyForm(string[] args)
		{
			try
			{
				SkinManager.EnableFormSkins();
				BonusSkins.Register();
				this.InitializeComponent();
				this.SyntaxTimer.Stop();
				this.InitializeForm(args);
				base.Closing += this.OnThisClosing;
				this.ErrorConsole.Click += this.OnGClick;
			}
			catch
			{
				base.Dispose(true);
				throw;
			}
		}

		// Used by the Visual Studio designer only: without a parameterless constructor it falls back
		// to the base XtraForm, which skips the skin setup above and draws a plain window frame.
		public MyForm()
		{
			SkinManager.EnableFormSkins();
			BonusSkins.Register();
			this.InitializeComponent();
		}

		private void CleanupManaged()
		{
			try
			{
				IContainer container = this.components;
				if (container != null)
				{
					IContainer container2 = container;
					container2.Dispose();
				}
			}
			catch (Exception)
			{
			}
		}

		private void barButtonItem29_ItemClick(object sender, ItemClickEventArgs e)
		{
		}

		private void treeList1_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
		{
		}

		private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
		{
			this.Manager.ConnectToPlatform(XPlatformType.PLATFORM_PS3_CCAPI);
		}

		private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
		{
			this.Manager.BuildProject(this.BuildMode.EditValue.ToString() == "Debug", PlatformTarget.Package);
		}

		private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
		{
			this.Manager.NewProject();
		}

		private void barCheckItem2_CheckedChanged(object sender, ItemClickEventArgs e)
		{
			if (!this.barCheckItem2.Checked)
			{
				IDE.Print("Disabling source protection will allow other users to obtain your work without permission. If this is a release build, please consider re-enabling this option.", "Warning", this.Output);
			}
		}

		private void dockPanel4_Click(object sender, EventArgs e)
		{
		}

		private void dockPanel2_Click(object sender, EventArgs e)
		{
		}

		private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
		{
			this.Manager.OpenProject();
		}

		private void barButtonItem33_ItemClick(object sender, ItemClickEventArgs e)
		{
			IDE.ClearConsole(this.Output);
		}

		private void barButtonItem35_ItemClick(object sender, ItemClickEventArgs e)
		{
			this.Manager.RenameScriptFired();
		}

		private void barButtonItem38_ItemClick(object sender, ItemClickEventArgs e)
		{
			this.Manager.RenameFileFired();
		}

		private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
		{
			this.Manager.SaveProject();
		}

		private void barButtonItem39_ItemClick(object sender, ItemClickEventArgs e)
		{
			this.Manager.AddScriptFile();
		}

		private void barButtonItem41_ItemClick(object sender, ItemClickEventArgs e)
		{
			this.Manager.AddNewScript();
		}

		private void barButtonItem34_ItemClick(object sender, ItemClickEventArgs e)
		{
			this.Manager.UnloadProject();
		}

		private void barButtonItem36_ItemClick(object sender, ItemClickEventArgs e)
		{
			this.Manager.DeleteScriptFired();
		}

		private void barButtonItem37_ItemClick(object sender, ItemClickEventArgs e)
		{
			this.Manager.DeleteFileFired();
		}

		private void OnOutputMouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				Point location = e.Location;
				Point p = ((Control)sender).PointToScreen(location);
				this.OutputPopup.ShowPopup(p);
			}
		}

		private void barButtonItem45_ItemClick(object sender, ItemClickEventArgs e)
		{
			IDE.ClearConsole(this.Output);
		}

		private void barButtonItem46_ItemClick(object sender, ItemClickEventArgs e)
		{
			this.Manager.DeleteSubgroupFired();
		}

		private void barButtonItem30_ItemClick(object sender, ItemClickEventArgs e)
		{
			this.Manager.LoadImportsWindow();
		}

		private void ReportClicked(object sender, ItemClickEventArgs e)
		{
			this.Manager.ReportClicked();
		}

		private void barButtonItem32_ItemClick(object sender, ItemClickEventArgs e)
		{
			this.Manager.SaveActiveFile();
		}

		private void OnThisClosing(object sender, CancelEventArgs e)
		{
			IDE manager = this.Manager;
			GSXProject activeProject = manager.ActiveProject;
			if (activeProject != null && activeProject.Unsaved && !manager.AskToSave())
			{
				e.Cancel = true;
			}
		}

		private void barButtonItem49_ItemClick(object sender, ItemClickEventArgs e)
		{
			this.Manager.AddNewScript();
		}

		private void barButtonItem50_ItemClick(object sender, ItemClickEventArgs e)
		{
			this.ColorTool.ShowDialog();
			decimal num = decimal.Round((decimal)(this.ColorTool.Color.B / 255.0), 3);
			decimal num2 = decimal.Round((decimal)(this.ColorTool.Color.G / 255.0), 3);
			decimal num3 = decimal.Round((decimal)(this.ColorTool.Color.R / 255.0), 3);
			string str = ", ";
			IDE.Print("(" + num3 + str + num2 + str + num + ")", "Color Picked", this.Output);
		}

		private void Output_Click(object sender, EventArgs e)
		{
		}

		private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
		{
			this.Manager.CheckScriptSyntax();
		}

		private void barButtonItem51_ItemClick(object sender, ItemClickEventArgs e)
		{
			this.Manager.CheckCurrentFileSyntax();
		}

		private void ErrorConsole_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
		{
		}

		private void OnGClick(object sender, EventArgs e)
		{
			this.Manager.NavigateToSyntaxError(this.ErrorConsole.FocusedNode);
		}

		private void barStaticItem4_ItemClick(object sender, ItemClickEventArgs e)
		{
		}

		private void barEditItem2_ItemClick(object sender, ItemClickEventArgs e)
		{
		}

		private void barButtonItem58_ItemClick(object sender, ItemClickEventArgs e)
		{
			this.Manager.NewProject();
		}

		private void barButtonItem59_ItemClick(object sender, ItemClickEventArgs e)
		{
			this.Manager.OpenProject();
		}

		private void OnBuildEditValueChanged(object sender, EventArgs e)
		{
		}

		private void OnBuildSelectedValueChanged(object sender, EventArgs e)
		{
			this.Manager.SetProjectDebug(!Equals(this.BuildMode.EditValue, "Debug"));
		}

		private void Toolbar_Save_ItemClick(object sender, ItemClickEventArgs e)
		{
			this.Manager.SaveActiveFile();
		}

		private void Toolbar_SaveAll_ItemClick(object sender, ItemClickEventArgs e)
		{
			this.Manager.SaveProject();
		}

		private void ToolbarPSettings_ItemClick(object sender, ItemClickEventArgs e)
		{
			this.Manager.ProjectSettingsWindow();
		}

		private void DropDown_PSettings_ItemClick(object sender, ItemClickEventArgs e)
		{
			this.Manager.ProjectSettingsWindow();
		}

		private void ToolbarBuildProject_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (this.BuildTarget.EditValue.ToString() == "Console")
			{
				this.Manager.BuildProject(this.BuildMode.EditValue.ToString() == "Debug", PlatformTarget.Console);
			}
			if (this.BuildTarget.EditValue.ToString() == "PC")
			{
				this.Manager.BuildProject(this.BuildMode.EditValue.ToString() == "Debug", PlatformTarget.PC);
			}
			if (this.BuildTarget.EditValue.ToString() == "Package")
			{
				this.Manager.BuildProject(this.BuildMode.EditValue.ToString() == "Debug", PlatformTarget.Package);
			}
		}

		private void DropDown_BuildC_ItemClick(object sender, ItemClickEventArgs e)
		{
			this.Manager.BuildProject(this.BuildMode.EditValue.ToString() == "Debug", PlatformTarget.Console);
		}

		private void DropDown_BuildPC_ItemClick(object sender, ItemClickEventArgs e)
		{
			this.Manager.BuildProject(this.BuildMode.EditValue.ToString() == "Debug", PlatformTarget.PC);
		}

		private void barButtonItem13_ItemClick_1(object sender, ItemClickEventArgs e)
		{
			this.Manager.RepairProjectWrapper();
		}

		private void BuildSettingsButton_ItemClick(object sender, ItemClickEventArgs e)
		{
			this.Manager.DisplayBuildSettings();
		}

		private void barCheckItem4_CheckedChanged(object sender, ItemClickEventArgs e)
		{
            if (initializingPreferences) return;
            Manager.OptimizeScripts = Build_Scripts.Checked;
            SavePreference("Optimize", Manager.OptimizeScripts);
		}

		private void barButtonItem13_ItemClick_2(object sender, ItemClickEventArgs e)
		{
		}

		private void barCheckItem5_CheckedChanged(object sender, ItemClickEventArgs e)
		{
            if (initializingPreferences) return;
            Manager.OptimizeChildren = Build_Children.Checked;
            SavePreference("OptimizeChildren", Manager.OptimizeChildren);
		}

		private void barCheckItem6_CheckedChanged(object sender, ItemClickEventArgs e)
		{
            if (initializingPreferences) return;
            Manager.Symbolize = Build_Symbolize.Checked;
            SavePreference("Symbolize", Manager.Symbolize);
		}

		private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
		{
			this.Manager.ConnectToPlatform(XPlatformType.PLATFORM_PS3_TMAPI);
		}

		private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
		{
			this.Manager.ConnectToPlatform(XPlatformType.PLATFORM_XBOX360);
		}

		private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
		{
			this.Manager.ConnectToPlatform(XPlatformType.PLATFORM_PC_REDACTED);
		}

		private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
		{
			this.Manager.ConnectToPlatform(XPlatformType.PLATFORM_PC_STEAM);
		}

		private void InjectPackage(object sender, ItemClickEventArgs e)
		{
			this.Manager.InjectPackage();
		}

		private void InjectCurrentProject(object sender, ItemClickEventArgs e)
		{
			this.Manager.InjectCurrentProject(this.BuildMode.EditValue.ToString() == "Debug");
		}

		private void InjectGSX(object sender, ItemClickEventArgs e)
		{
			this.Manager.InjectExternalScripts();
		}

		private void barButtonItem43_ItemClick(object sender, ItemClickEventArgs e)
		{
		}

		private void barButtonItem67_ItemClick(object sender, ItemClickEventArgs e)
		{
			this.Manager.PlatformMemClicked();
		}

		private void barButtonItem68_ItemClick(object sender, ItemClickEventArgs e)
		{
			this.Manager.ResetParseTree();
		}

		private void barButtonItem69_ItemClick(object sender, ItemClickEventArgs e)
		{
			MessageBox.Show("The XRPC connection backend is unavailable in this recovered compiler. Use the JRPC2 connection instead.", "XRPC unavailable", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private IDE Manager;

        private void MyForm_Load(object sender, EventArgs e)
        {

        }
    }
}
