namespace GSX_Studio
{
	public partial class MyForm : global::DevExpress.XtraEditors.XtraForm
	{
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, null, true, true, true);
            DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer dockingContainer2 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyForm));
            this.documentGroup2 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(this.components);
            this.document1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(this.components);
            this.Toolbars = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem6 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem8 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem69 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem9 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.DropDown_NewScript = new DevExpress.XtraBars.BarButtonItem();
            this.DropDown_Save = new DevExpress.XtraBars.BarButtonItem();
            this.DropDown_SaveAll = new DevExpress.XtraBars.BarButtonItem();
            this.DropDown_Close = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem30 = new DevExpress.XtraBars.BarButtonItem();
            this.DropDown_ProjectSub = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem16 = new DevExpress.XtraBars.BarSubItem();
            this.DropDown_ConvertZ = new DevExpress.XtraBars.BarButtonItem();
            this.DropDown_ConvertM = new DevExpress.XtraBars.BarButtonItem();
            this.DropDown_PSettings = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem11 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem27 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem21 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem20 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem68 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            this.DropDown_BuildC = new DevExpress.XtraBars.BarButtonItem();
            this.DropDown_BuildPC = new DevExpress.XtraBars.BarButtonItem();
            this.DropDown_BuildPK = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem17 = new DevExpress.XtraBars.BarSubItem();
            this.Build_Scripts = new DevExpress.XtraBars.BarCheckItem();
            this.Build_Children = new DevExpress.XtraBars.BarCheckItem();
            this.Build_Symbolize = new DevExpress.XtraBars.BarCheckItem();
            this.barSubItem20 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem56 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem64 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem63 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem65 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem23 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem13 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem50 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem22 = new DevExpress.XtraBars.BarButtonItem();
            this.Tools_ProjectRepair = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem24 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem67 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem5 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem25 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem24 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem23 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem26 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.StatusLabel = new DevExpress.XtraBars.BarStaticItem();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItem58 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem59 = new DevExpress.XtraBars.BarButtonItem();
            this.Toolbar_Save = new DevExpress.XtraBars.BarButtonItem();
            this.Toolbar_SaveAll = new DevExpress.XtraBars.BarButtonItem();
            this.BuildMode = new DevExpress.XtraBars.BarEditItem();
            this.BuildModeCombo = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.BuildTarget = new DevExpress.XtraBars.BarEditItem();
            this.BuildTargetCombo = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.ToolbarBuildProject = new DevExpress.XtraBars.BarButtonItem();
            this.ToolbarPSettings = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.panelContainer1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.ErrorPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel3_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.ErrorConsole = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn5 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn6 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn4 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.OutputPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel4_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.Output = new DevExpress.XtraRichEdit.RichEditControl();
            this.ProjectPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.ProjectExplorer = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.dockPanel2 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem4 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem7 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem14 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem15 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem16 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem10 = new DevExpress.XtraBars.BarSubItem();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.barButtonItem28 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem29 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem12 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem31 = new DevExpress.XtraBars.BarButtonItem();
            this.barCheckItem2 = new DevExpress.XtraBars.BarCheckItem();
            this.barSubItem14 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem33 = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItem35 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem36 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem37 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem38 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem39 = new DevExpress.XtraBars.BarButtonItem();
            this.barCheckItem3 = new DevExpress.XtraBars.BarCheckItem();
            this.barButtonItem40 = new DevExpress.XtraBars.BarButtonItem();
            this.ZombiesToggle = new DevExpress.XtraBars.BarCheckItem();
            this.barSubItem15 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem42 = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem3 = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItem45 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem46 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem47 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem48 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem49 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem51 = new DevExpress.XtraBars.BarButtonItem();
            this.DebugToggleSwitch = new DevExpress.XtraBars.BarCheckItem();
            this.barToggleSwitchItem1 = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barStaticItem4 = new DevExpress.XtraBars.BarStaticItem();
            this.barLargeButtonItem1 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barEditItem3 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barButtonItem52 = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem4 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barEditItem5 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barButtonItem53 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem55 = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem6 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox4 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.Bar_BuildSettings = new DevExpress.XtraBars.BarButtonItem();
            this.BuildSettingsButton = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem17 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem18 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem18 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem19 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem19 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem32 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem34 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem41 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem43 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem44 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem21 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem54 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem57 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem22 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem60 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem61 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem62 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem66 = new DevExpress.XtraBars.BarButtonItem();
            this.Toolbarsmanager = new DevExpress.XtraBars.DefaultBarAndDockingController(this.components);
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.SRightClick = new DevExpress.XtraBars.PopupMenu(this.components);
            this.PRightClick = new DevExpress.XtraBars.PopupMenu(this.components);
            this.OutputPopup = new DevExpress.XtraBars.PopupMenu(this.components);
            this.SubgroupPopup = new DevExpress.XtraBars.PopupMenu(this.components);
            this.ColorTool = new System.Windows.Forms.ColorDialog();
            this.SyntaxTimer = new System.Windows.Forms.Timer(this.components);
            this.documentGroup1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toolbars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuildModeCombo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuildTargetCombo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.panelContainer1.SuspendLayout();
            this.ErrorPanel.SuspendLayout();
            this.dockPanel3_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorConsole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            this.OutputPanel.SuspendLayout();
            this.dockPanel4_Container.SuspendLayout();
            this.ProjectPanel.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectExplorer)).BeginInit();
            this.dockPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toolbarsmanager.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SRightClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRightClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputPopup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubgroupPopup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup1)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager
            // 
            splashScreenManager.ClosingDelay = 500;
            // 
            // documentGroup2
            // 
            this.documentGroup2.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document[] {
            this.document1});
            // 
            // document1
            // 
            this.document1.Caption = "README";
            this.document1.ControlName = "dockPanel2";
            this.document1.ControlTypeName = null;
            this.document1.FloatLocation = new System.Drawing.Point(612, 346);
            this.document1.FloatSize = new System.Drawing.Size(200, 200);
            this.document1.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.True;
            this.document1.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.True;
            this.document1.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
            // 
            // Toolbars
            // 
            this.Toolbars.AllowCustomization = false;
            this.Toolbars.AllowQuickCustomization = false;
            this.Toolbars.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3,
            this.bar1});
            this.Toolbars.DockControls.Add(this.barDockControlTop);
            this.Toolbars.DockControls.Add(this.barDockControlBottom);
            this.Toolbars.DockControls.Add(this.barDockControlLeft);
            this.Toolbars.DockControls.Add(this.barDockControlRight);
            this.Toolbars.DockManager = this.dockManager1;
            this.Toolbars.Form = this;
            this.Toolbars.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.StatusLabel,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barSubItem1,
            this.barSubItem2,
            this.barSubItem3,
            this.barSubItem4,
            this.barSubItem5,
            this.barSubItem6,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barSubItem7,
            this.barSubItem8,
            this.barButtonItem8,
            this.barSubItem9,
            this.barButtonItem9,
            this.barButtonItem10,
            this.barButtonItem11,
            this.barButtonItem12,
            this.DropDown_SaveAll,
            this.barButtonItem14,
            this.barButtonItem15,
            this.barButtonItem16,
            this.barSubItem10,
            this.DropDown_BuildC,
            this.DropDown_BuildPC,
            this.DropDown_BuildPK,
            this.barSubItem11,
            this.barButtonItem20,
            this.barButtonItem21,
            this.barButtonItem22,
            this.barCheckItem1,
            this.barButtonItem23,
            this.barButtonItem24,
            this.barButtonItem25,
            this.barButtonItem26,
            this.barButtonItem27,
            this.barButtonItem28,
            this.barButtonItem29,
            this.barSubItem12,
            this.barButtonItem30,
            this.barButtonItem31,
            this.barCheckItem2,
            this.DropDown_Save,
            this.barSubItem13,
            this.barSubItem14,
            this.barButtonItem33,
            this.DropDown_Close,
            this.barStaticItem2,
            this.barButtonItem35,
            this.barButtonItem36,
            this.barButtonItem37,
            this.barButtonItem38,
            this.barButtonItem39,
            this.barCheckItem3,
            this.barButtonItem40,
            this.ZombiesToggle,
            this.barSubItem15,
            this.DropDown_NewScript,
            this.barButtonItem42,
            this.barSubItem16,
            this.DropDown_ConvertZ,
            this.DropDown_ConvertM,
            this.barStaticItem3,
            this.barButtonItem45,
            this.barButtonItem46,
            this.DropDown_ProjectSub,
            this.barButtonItem47,
            this.barButtonItem48,
            this.barButtonItem49,
            this.barButtonItem50,
            this.barButtonItem51,
            this.DebugToggleSwitch,
            this.barToggleSwitchItem1,
            this.BuildMode,
            this.barEditItem2,
            this.barStaticItem4,
            this.barLargeButtonItem1,
            this.barEditItem3,
            this.barButtonItem52,
            this.barEditItem4,
            this.barEditItem5,
            this.barButtonItem53,
            this.ToolbarBuildProject,
            this.barButtonItem55,
            this.Toolbar_Save,
            this.Toolbar_SaveAll,
            this.barButtonItem58,
            this.barButtonItem59,
            this.barEditItem6,
            this.BuildTarget,
            this.DropDown_PSettings,
            this.ToolbarPSettings,
            this.barEditItem1,
            this.Tools_ProjectRepair,
            this.Bar_BuildSettings,
            this.BuildSettingsButton,
            this.barSubItem17,
            this.Build_Scripts,
            this.barButtonItem13,
            this.barButtonItem17,
            this.Build_Children,
            this.Build_Symbolize,
            this.barButtonItem18,
            this.barSubItem18,
            this.barButtonItem19,
            this.barSubItem19,
            this.barButtonItem32,
            this.barButtonItem34,
            this.barButtonItem41,
            this.barSubItem20,
            this.barButtonItem43,
            this.barButtonItem44,
            this.barSubItem21,
            this.barButtonItem54,
            this.barButtonItem56,
            this.barButtonItem57,
            this.barSubItem22,
            this.barButtonItem60,
            this.barButtonItem61,
            this.barButtonItem62,
            this.barButtonItem63,
            this.barButtonItem64,
            this.barButtonItem65,
            this.barSubItem23,
            this.barButtonItem66,
            this.barSubItem24,
            this.barButtonItem67,
            this.barButtonItem68,
            this.barButtonItem69});
            this.Toolbars.MainMenu = this.bar2;
            this.Toolbars.MaxItemId = 133;
            this.Toolbars.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.BuildModeCombo,
            this.repositoryItemComboBox2,
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2,
            this.repositoryItemComboBox3,
            this.repositoryItemComboBox4,
            this.BuildTargetCombo,
            this.repositoryItemProgressBar1});
            this.Toolbars.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem11),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem20),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem23),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem13),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem5)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Connect";
            this.barSubItem1.Id = 4;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem6),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem8),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem9)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barSubItem6
            // 
            this.barSubItem6.Caption = "PS3";
            this.barSubItem6.Id = 9;
            this.barSubItem6.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem5)});
            this.barSubItem6.Name = "barSubItem6";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "CCAPI";
            this.barButtonItem4.Id = 10;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "TMAPI";
            this.barButtonItem5.Id = 11;
            this.barButtonItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // barSubItem8
            // 
            this.barSubItem8.Caption = "XBOX 360";
            this.barSubItem8.Id = 15;
            this.barSubItem8.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem8),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem69)});
            this.barSubItem8.Name = "barSubItem8";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Default Console (JRPC2)";
            this.barButtonItem8.Id = 16;
            this.barButtonItem8.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.Image")));
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem8.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem8_ItemClick);
            // 
            // barButtonItem69
            // 
            this.barButtonItem69.Caption = "Default Console (XRPC)";
            this.barButtonItem69.Id = 132;
            this.barButtonItem69.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem69.ImageOptions.Image")));
            this.barButtonItem69.Name = "barButtonItem69";
            this.barButtonItem69.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem69.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem69_ItemClick);
            // 
            // barSubItem9
            // 
            this.barSubItem9.Caption = "PC";
            this.barSubItem9.Id = 17;
            this.barSubItem9.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem9),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem10)});
            this.barSubItem9.Name = "barSubItem9";
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Redacted";
            this.barButtonItem9.Id = 18;
            this.barButtonItem9.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.ImageOptions.Image")));
            this.barButtonItem9.Name = "barButtonItem9";
            this.barButtonItem9.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem9.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem9_ItemClick);
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "Steam";
            this.barButtonItem10.Id = 19;
            this.barButtonItem10.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem10.ImageOptions.Image")));
            this.barButtonItem10.Name = "barButtonItem10";
            this.barButtonItem10.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem10.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem10_ItemClick);
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "Project";
            this.barSubItem2.Id = 5;
            this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem11),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem12),
            new DevExpress.XtraBars.LinkPersistInfo(this.DropDown_NewScript, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.DropDown_Save, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.DropDown_SaveAll),
            new DevExpress.XtraBars.LinkPersistInfo(this.DropDown_Close, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem30, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.DropDown_ProjectSub)});
            this.barSubItem2.Name = "barSubItem2";
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "New Project";
            this.barButtonItem11.Id = 20;
            this.barButtonItem11.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem11.ImageOptions.Image")));
            this.barButtonItem11.Name = "barButtonItem11";
            this.barButtonItem11.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem11.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem11_ItemClick);
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "Open Project";
            this.barButtonItem12.Id = 21;
            this.barButtonItem12.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem12.ImageOptions.Image")));
            this.barButtonItem12.Name = "barButtonItem12";
            this.barButtonItem12.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem12.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem12_ItemClick);
            // 
            // DropDown_NewScript
            // 
            this.DropDown_NewScript.Caption = "New Script File";
            this.DropDown_NewScript.Enabled = false;
            this.DropDown_NewScript.Id = 61;
            this.DropDown_NewScript.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DropDown_NewScript.ImageOptions.Image")));
            this.DropDown_NewScript.Name = "DropDown_NewScript";
            this.DropDown_NewScript.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.DropDown_NewScript.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem41_ItemClick);
            // 
            // DropDown_Save
            // 
            this.DropDown_Save.Caption = "Save File";
            this.DropDown_Save.Enabled = false;
            this.DropDown_Save.Id = 46;
            this.DropDown_Save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DropDown_Save.ImageOptions.Image")));
            this.DropDown_Save.Name = "DropDown_Save";
            this.DropDown_Save.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.DropDown_Save.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem32_ItemClick);
            // 
            // DropDown_SaveAll
            // 
            this.DropDown_SaveAll.Caption = "Save Project";
            this.DropDown_SaveAll.Enabled = false;
            this.DropDown_SaveAll.Id = 22;
            this.DropDown_SaveAll.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DropDown_SaveAll.ImageOptions.Image")));
            this.DropDown_SaveAll.Name = "DropDown_SaveAll";
            this.DropDown_SaveAll.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.DropDown_SaveAll.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem13_ItemClick);
            // 
            // DropDown_Close
            // 
            this.DropDown_Close.Caption = "Close Project";
            this.DropDown_Close.Enabled = false;
            this.DropDown_Close.Id = 50;
            this.DropDown_Close.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DropDown_Close.ImageOptions.Image")));
            this.DropDown_Close.Name = "DropDown_Close";
            this.DropDown_Close.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.DropDown_Close.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem34_ItemClick);
            // 
            // barButtonItem30
            // 
            this.barButtonItem30.Caption = "Import Project";
            this.barButtonItem30.Id = 43;
            this.barButtonItem30.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem30.ImageOptions.Image")));
            this.barButtonItem30.Name = "barButtonItem30";
            this.barButtonItem30.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem30.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem30_ItemClick);
            // 
            // DropDown_ProjectSub
            // 
            this.DropDown_ProjectSub.Caption = "Project Properties";
            this.DropDown_ProjectSub.Id = 69;
            this.DropDown_ProjectSub.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem16),
            new DevExpress.XtraBars.LinkPersistInfo(this.DropDown_PSettings)});
            this.DropDown_ProjectSub.Name = "DropDown_ProjectSub";
            // 
            // barSubItem16
            // 
            this.barSubItem16.Caption = "Convert Project";
            this.barSubItem16.Enabled = false;
            this.barSubItem16.Id = 63;
            this.barSubItem16.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.DropDown_ConvertZ),
            new DevExpress.XtraBars.LinkPersistInfo(this.DropDown_ConvertM)});
            this.barSubItem16.Name = "barSubItem16";
            // 
            // DropDown_ConvertZ
            // 
            this.DropDown_ConvertZ.Caption = "Zombies";
            this.DropDown_ConvertZ.Enabled = false;
            this.DropDown_ConvertZ.Id = 64;
            this.DropDown_ConvertZ.Name = "DropDown_ConvertZ";
            // 
            // DropDown_ConvertM
            // 
            this.DropDown_ConvertM.Caption = "Multiplayer";
            this.DropDown_ConvertM.Enabled = false;
            this.DropDown_ConvertM.Id = 65;
            this.DropDown_ConvertM.Name = "DropDown_ConvertM";
            // 
            // DropDown_PSettings
            // 
            this.DropDown_PSettings.Caption = "Project Settings";
            this.DropDown_PSettings.Enabled = false;
            this.DropDown_PSettings.Id = 94;
            this.DropDown_PSettings.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DropDown_PSettings.ImageOptions.Image")));
            this.DropDown_PSettings.Name = "DropDown_PSettings";
            this.DropDown_PSettings.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.DropDown_PSettings.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DropDown_PSettings_ItemClick);
            // 
            // barSubItem11
            // 
            this.barSubItem11.Caption = "Inject";
            this.barSubItem11.Id = 30;
            this.barSubItem11.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem27),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem21),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem20),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem68)});
            this.barSubItem11.Name = "barSubItem11";
            // 
            // barButtonItem27
            // 
            this.barButtonItem27.Caption = "Inject Current Project";
            this.barButtonItem27.Enabled = false;
            this.barButtonItem27.Id = 39;
            this.barButtonItem27.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem27.ImageOptions.Image")));
            this.barButtonItem27.Name = "barButtonItem27";
            this.barButtonItem27.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem27.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.InjectCurrentProject);
            // 
            // barButtonItem21
            // 
            this.barButtonItem21.Caption = "Inject GSC";
            this.barButtonItem21.Enabled = false;
            this.barButtonItem21.Id = 32;
            this.barButtonItem21.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem21.ImageOptions.Image")));
            this.barButtonItem21.Name = "barButtonItem21";
            this.barButtonItem21.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem21.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.InjectGSX);
            // 
            // barButtonItem20
            // 
            this.barButtonItem20.Caption = "Inject Package";
            this.barButtonItem20.Enabled = false;
            this.barButtonItem20.Id = 31;
            this.barButtonItem20.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem20.ImageOptions.Image")));
            this.barButtonItem20.Name = "barButtonItem20";
            this.barButtonItem20.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem20.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.InjectPackage);
            // 
            // barButtonItem68
            // 
            this.barButtonItem68.Caption = "Reset Script Parse Tree";
            this.barButtonItem68.Enabled = false;
            this.barButtonItem68.Id = 131;
            this.barButtonItem68.Name = "barButtonItem68";
            this.barButtonItem68.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem68_ItemClick);
            // 
            // barSubItem3
            // 
            this.barSubItem3.Caption = "Build";
            this.barSubItem3.Id = 6;
            this.barSubItem3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.DropDown_BuildC),
            new DevExpress.XtraBars.LinkPersistInfo(this.DropDown_BuildPC),
            new DevExpress.XtraBars.LinkPersistInfo(this.DropDown_BuildPK),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem17, true)});
            this.barSubItem3.Name = "barSubItem3";
            // 
            // DropDown_BuildC
            // 
            this.DropDown_BuildC.Caption = "Build Console";
            this.DropDown_BuildC.Enabled = false;
            this.DropDown_BuildC.Id = 27;
            this.DropDown_BuildC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DropDown_BuildC.ImageOptions.Image")));
            this.DropDown_BuildC.Name = "DropDown_BuildC";
            this.DropDown_BuildC.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.DropDown_BuildC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DropDown_BuildC_ItemClick);
            // 
            // DropDown_BuildPC
            // 
            this.DropDown_BuildPC.Caption = "Build PC";
            this.DropDown_BuildPC.Enabled = false;
            this.DropDown_BuildPC.Id = 28;
            this.DropDown_BuildPC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DropDown_BuildPC.ImageOptions.Image")));
            this.DropDown_BuildPC.Name = "DropDown_BuildPC";
            this.DropDown_BuildPC.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.DropDown_BuildPC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DropDown_BuildPC_ItemClick);
            // 
            // DropDown_BuildPK
            // 
            this.DropDown_BuildPK.Caption = "Build Package";
            this.DropDown_BuildPK.Enabled = false;
            this.DropDown_BuildPK.Id = 29;
            this.DropDown_BuildPK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DropDown_BuildPK.ImageOptions.Image")));
            this.DropDown_BuildPK.Name = "DropDown_BuildPK";
            this.DropDown_BuildPK.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.DropDown_BuildPK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem19_ItemClick);
            // 
            // barSubItem17
            // 
            this.barSubItem17.Caption = "Build Settings";
            this.barSubItem17.Id = 100;
            this.barSubItem17.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.Build_Scripts),
            new DevExpress.XtraBars.LinkPersistInfo(this.Build_Children),
            new DevExpress.XtraBars.LinkPersistInfo(this.Build_Symbolize)});
            this.barSubItem17.Name = "barSubItem17";
            // 
            // Build_Scripts
            // 
            this.Build_Scripts.BindableChecked = true;
            this.Build_Scripts.Caption = "Optimize Scripts";
            this.Build_Scripts.Checked = true;
            this.Build_Scripts.Id = 101;
            this.Build_Scripts.Name = "Build_Scripts";
            this.Build_Scripts.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckItem4_CheckedChanged);
            // 
            // Build_Children
            // 
            this.Build_Children.Caption = "Optimize Children";
            this.Build_Children.Id = 104;
            this.Build_Children.Name = "Build_Children";
            this.Build_Children.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckItem5_CheckedChanged);
            // 
            // Build_Symbolize
            // 
            this.Build_Symbolize.BindableChecked = true;
            this.Build_Symbolize.Caption = "Symbolize Variables";
            this.Build_Symbolize.Checked = true;
            this.Build_Symbolize.Id = 105;
            this.Build_Symbolize.Name = "Build_Symbolize";
            this.Build_Symbolize.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckItem6_CheckedChanged);
            // 
            // barSubItem20
            // 
            this.barSubItem20.Caption = "Libraries";
            this.barSubItem20.Enabled = false;
            this.barSubItem20.Id = 113;
            this.barSubItem20.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem56),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem64, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem63),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem65, true)});
            this.barSubItem20.Name = "barSubItem20";
            // 
            // barButtonItem56
            // 
            this.barButtonItem56.Caption = "Export Project";
            this.barButtonItem56.Id = 118;
            this.barButtonItem56.Name = "barButtonItem56";
            // 
            // barButtonItem64
            // 
            this.barButtonItem64.Caption = "Share Project";
            this.barButtonItem64.Id = 125;
            this.barButtonItem64.Name = "barButtonItem64";
            // 
            // barButtonItem63
            // 
            this.barButtonItem63.Caption = "Get New Libraries";
            this.barButtonItem63.Id = 124;
            this.barButtonItem63.Name = "barButtonItem63";
            // 
            // barButtonItem65
            // 
            this.barButtonItem65.Caption = "Library Manager";
            this.barButtonItem65.Id = 126;
            this.barButtonItem65.Name = "barButtonItem65";
            // 
            // barSubItem23
            // 
            this.barSubItem23.Caption = "Fast Files";
            this.barSubItem23.Enabled = false;
            this.barSubItem23.Id = 127;
            this.barSubItem23.Name = "barSubItem23";
            // 
            // barSubItem13
            // 
            this.barSubItem13.Caption = "Tools";
            this.barSubItem13.Id = 47;
            this.barSubItem13.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem50),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem22, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.Tools_ProjectRepair, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem24, true)});
            this.barSubItem13.Name = "barSubItem13";
            // 
            // barButtonItem50
            // 
            this.barButtonItem50.Caption = "RGB Color Picker";
            this.barButtonItem50.Id = 73;
            this.barButtonItem50.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem50.ImageOptions.Image")));
            this.barButtonItem50.Name = "barButtonItem50";
            this.barButtonItem50.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem50_ItemClick);
            // 
            // barButtonItem22
            // 
            this.barButtonItem22.Caption = "Edit Preferences";
            this.barButtonItem22.Enabled = false;
            this.barButtonItem22.Id = 33;
            this.barButtonItem22.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem22.ImageOptions.Image")));
            this.barButtonItem22.Name = "barButtonItem22";
            this.barButtonItem22.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // Tools_ProjectRepair
            // 
            this.Tools_ProjectRepair.Caption = "Project Repair";
            this.Tools_ProjectRepair.Enabled = false;
            this.Tools_ProjectRepair.Id = 97;
            this.Tools_ProjectRepair.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Tools_ProjectRepair.ImageOptions.Image")));
            this.Tools_ProjectRepair.Name = "Tools_ProjectRepair";
            this.Tools_ProjectRepair.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.Tools_ProjectRepair.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem13_ItemClick_1);
            // 
            // barSubItem24
            // 
            this.barSubItem24.Caption = "Platform Tools";
            this.barSubItem24.Enabled = false;
            this.barSubItem24.Id = 129;
            this.barSubItem24.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem67)});
            this.barSubItem24.Name = "barSubItem24";
            // 
            // barButtonItem67
            // 
            this.barButtonItem67.Caption = "Memory Editing";
            this.barButtonItem67.Enabled = false;
            this.barButtonItem67.Id = 130;
            this.barButtonItem67.Name = "barButtonItem67";
            this.barButtonItem67.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem67_ItemClick);
            // 
            // barSubItem5
            // 
            this.barSubItem5.Caption = "About";
            this.barSubItem5.Id = 8;
            this.barSubItem5.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem25),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem24, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem23),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem26, true)});
            this.barSubItem5.Name = "barSubItem5";
            // 
            // barButtonItem25
            // 
            this.barButtonItem25.Caption = "Donate";
            this.barButtonItem25.Enabled = false;
            this.barButtonItem25.Id = 37;
            this.barButtonItem25.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem25.ImageOptions.Image")));
            this.barButtonItem25.Name = "barButtonItem25";
            this.barButtonItem25.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem24
            // 
            this.barButtonItem24.Caption = "Update GSX Studio";
            this.barButtonItem24.Enabled = false;
            this.barButtonItem24.Id = 36;
            this.barButtonItem24.Name = "barButtonItem24";
            // 
            // barButtonItem23
            // 
            this.barButtonItem23.Caption = "About GSX Studio";
            this.barButtonItem23.Enabled = false;
            this.barButtonItem23.Id = 35;
            this.barButtonItem23.Name = "barButtonItem23";
            // 
            // barButtonItem26
            // 
            this.barButtonItem26.Caption = "Report a Bug";
            this.barButtonItem26.Id = 38;
            this.barButtonItem26.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem26.ImageOptions.Image")));
            this.barButtonItem26.Name = "barButtonItem26";
            this.barButtonItem26.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem26.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ReportClicked);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.StatusLabel, true)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Caption = "Ready";
            this.StatusLabel.Id = 0;
            this.StatusLabel.Name = "StatusLabel";
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 4";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(80, 157);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem58, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem59),
            new DevExpress.XtraBars.LinkPersistInfo(this.Toolbar_Save),
            new DevExpress.XtraBars.LinkPersistInfo(this.Toolbar_SaveAll),
            new DevExpress.XtraBars.LinkPersistInfo(this.BuildMode, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.BuildTarget),
            new DevExpress.XtraBars.LinkPersistInfo(this.ToolbarBuildProject),
            new DevExpress.XtraBars.LinkPersistInfo(this.ToolbarPSettings, true)});
            this.bar1.Text = "Custom 4";
            // 
            // barButtonItem58
            // 
            this.barButtonItem58.Caption = "New Project";
            this.barButtonItem58.Id = 90;
            this.barButtonItem58.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem58.ImageOptions.Image")));
            this.barButtonItem58.Name = "barButtonItem58";
            this.barButtonItem58.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem58_ItemClick);
            // 
            // barButtonItem59
            // 
            this.barButtonItem59.Caption = "Open Project";
            this.barButtonItem59.Id = 91;
            this.barButtonItem59.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem59.ImageOptions.Image")));
            this.barButtonItem59.Name = "barButtonItem59";
            this.barButtonItem59.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem59_ItemClick);
            // 
            // Toolbar_Save
            // 
            this.Toolbar_Save.Caption = "Save File";
            this.Toolbar_Save.Enabled = false;
            this.Toolbar_Save.Id = 88;
            this.Toolbar_Save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Toolbar_Save.ImageOptions.Image")));
            this.Toolbar_Save.Name = "Toolbar_Save";
            this.Toolbar_Save.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Toolbar_Save_ItemClick);
            // 
            // Toolbar_SaveAll
            // 
            this.Toolbar_SaveAll.Caption = "Save All";
            this.Toolbar_SaveAll.Enabled = false;
            this.Toolbar_SaveAll.Id = 89;
            this.Toolbar_SaveAll.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Toolbar_SaveAll.ImageOptions.Image")));
            this.Toolbar_SaveAll.Name = "Toolbar_SaveAll";
            this.Toolbar_SaveAll.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Toolbar_SaveAll_ItemClick);
            // 
            // BuildMode
            // 
            this.BuildMode.Caption = "Build Mode";
            this.BuildMode.Edit = this.BuildModeCombo;
            this.BuildMode.EditWidth = 74;
            this.BuildMode.Enabled = false;
            this.BuildMode.Id = 77;
            this.BuildMode.Name = "BuildMode";
            // 
            // BuildModeCombo
            // 
            this.BuildModeCombo.AutoComplete = false;
            this.BuildModeCombo.AutoHeight = false;
            this.BuildModeCombo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.BuildModeCombo.Items.AddRange(new object[] {
            "Debug",
            "Release"});
            this.BuildModeCombo.Name = "BuildModeCombo";
            this.BuildModeCombo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // BuildTarget
            // 
            this.BuildTarget.Caption = "Platform";
            this.BuildTarget.Edit = this.BuildTargetCombo;
            this.BuildTarget.EditWidth = 101;
            this.BuildTarget.Enabled = false;
            this.BuildTarget.Id = 93;
            this.BuildTarget.Name = "BuildTarget";
            // 
            // BuildTargetCombo
            // 
            this.BuildTargetCombo.AutoHeight = false;
            this.BuildTargetCombo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.BuildTargetCombo.Items.AddRange(new object[] {
            "Console",
            "PC",
            "Package"});
            this.BuildTargetCombo.Name = "BuildTargetCombo";
            this.BuildTargetCombo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // ToolbarBuildProject
            // 
            this.ToolbarBuildProject.Caption = "Build Project";
            this.ToolbarBuildProject.Enabled = false;
            this.ToolbarBuildProject.Id = 86;
            this.ToolbarBuildProject.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ToolbarBuildProject.ImageOptions.Image")));
            this.ToolbarBuildProject.Name = "ToolbarBuildProject";
            this.ToolbarBuildProject.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.ToolbarBuildProject.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ToolbarBuildProject_ItemClick);
            // 
            // ToolbarPSettings
            // 
            this.ToolbarPSettings.Caption = "Project Settings";
            this.ToolbarPSettings.Enabled = false;
            this.ToolbarPSettings.Id = 95;
            this.ToolbarPSettings.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ToolbarPSettings.ImageOptions.Image")));
            this.ToolbarPSettings.Name = "ToolbarPSettings";
            this.ToolbarPSettings.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ToolbarPSettings_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.Toolbars;
            this.barDockControlTop.Size = new System.Drawing.Size(984, 50);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 557);
            this.barDockControlBottom.Manager = this.Toolbars;
            this.barDockControlBottom.Size = new System.Drawing.Size(984, 24);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 50);
            this.barDockControlLeft.Manager = this.Toolbars;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 507);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(984, 50);
            this.barDockControlRight.Manager = this.Toolbars;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 507);
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.MenuManager = this.Toolbars;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.panelContainer1,
            this.ProjectPanel,
            this.dockPanel2});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane"});
            // 
            // panelContainer1
            // 
            this.panelContainer1.Controls.Add(this.ErrorPanel);
            this.panelContainer1.Controls.Add(this.OutputPanel);
            this.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.panelContainer1.FloatVertical = true;
            this.panelContainer1.ID = new System.Guid("89e852f3-c187-4fa6-bd62-ebed63e042f1");
            this.panelContainer1.Location = new System.Drawing.Point(0, 383);
            this.panelContainer1.Name = "panelContainer1";
            this.panelContainer1.OriginalSize = new System.Drawing.Size(200, 174);
            this.panelContainer1.Size = new System.Drawing.Size(984, 174);
            this.panelContainer1.Text = "panelContainer1";
            // 
            // ErrorPanel
            // 
            this.ErrorPanel.Controls.Add(this.dockPanel3_Container);
            this.ErrorPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.ErrorPanel.FloatVertical = true;
            this.ErrorPanel.ID = new System.Guid("b8e78239-e295-4136-b505-67fcc7a8f67d");
            this.ErrorPanel.Location = new System.Drawing.Point(0, 0);
            this.ErrorPanel.Name = "ErrorPanel";
            this.ErrorPanel.Options.ShowCloseButton = false;
            this.ErrorPanel.OriginalSize = new System.Drawing.Size(200, 200);
            this.ErrorPanel.Size = new System.Drawing.Size(492, 174);
            this.ErrorPanel.Text = "Error List";
            // 
            // dockPanel3_Container
            // 
            this.dockPanel3_Container.Controls.Add(this.ErrorConsole);
            this.dockPanel3_Container.Location = new System.Drawing.Point(3, 26);
            this.dockPanel3_Container.Name = "dockPanel3_Container";
            this.dockPanel3_Container.Size = new System.Drawing.Size(485, 145);
            this.dockPanel3_Container.TabIndex = 0;
            // 
            // ErrorConsole
            // 
            this.ErrorConsole.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ErrorConsole.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn5,
            this.treeListColumn2,
            this.treeListColumn3,
            this.treeListColumn6,
            this.treeListColumn4});
            this.ErrorConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ErrorConsole.Location = new System.Drawing.Point(0, 0);
            this.ErrorConsole.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            this.ErrorConsole.LookAndFeel.UseDefaultLookAndFeel = false;
            this.ErrorConsole.Name = "ErrorConsole";
            this.ErrorConsole.OptionsBehavior.AllowExpandOnDblClick = false;
            this.ErrorConsole.OptionsBehavior.AutoChangeParent = false;
            this.ErrorConsole.OptionsBehavior.AutoSelectAllInEditor = false;
            this.ErrorConsole.OptionsBehavior.Editable = false;
            this.ErrorConsole.OptionsBehavior.EditorShowMode = DevExpress.XtraTreeList.TreeListEditorShowMode.MouseDownFocused;
            this.ErrorConsole.OptionsBehavior.PopulateServiceColumns = true;
            this.ErrorConsole.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.False;
            this.ErrorConsole.OptionsClipboard.CopyNodeHierarchy = DevExpress.Utils.DefaultBoolean.False;
            this.ErrorConsole.OptionsCustomization.AllowBandMoving = false;
            this.ErrorConsole.OptionsCustomization.AllowColumnMoving = false;
            this.ErrorConsole.OptionsCustomization.AllowQuickHideColumns = false;
            this.ErrorConsole.OptionsCustomization.ShowBandsInCustomizationForm = false;
            this.ErrorConsole.OptionsFilter.AllowColumnMRUFilterList = false;
            this.ErrorConsole.OptionsFilter.AllowFilterEditor = false;
            this.ErrorConsole.OptionsFilter.AllowMRUFilterList = false;
            this.ErrorConsole.OptionsLayout.AddNewColumns = false;
            this.ErrorConsole.OptionsMenu.EnableColumnMenu = false;
            this.ErrorConsole.OptionsMenu.EnableFooterMenu = false;
            this.ErrorConsole.OptionsMenu.ShowAutoFilterRowItem = false;
            this.ErrorConsole.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.ErrorConsole.OptionsSelection.SelectNodesOnRightClick = true;
            this.ErrorConsole.OptionsView.ShowRoot = false;
            this.ErrorConsole.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.ErrorConsole.Size = new System.Drawing.Size(485, 145);
            this.ErrorConsole.TabIndex = 0;
            this.ErrorConsole.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.ErrorConsole_FocusedNodeChanged);
            // 
            // treeListColumn5
            // 
            this.treeListColumn5.ColumnEdit = this.repositoryItemPictureEdit1;
            this.treeListColumn5.Name = "treeListColumn5";
            this.treeListColumn5.OptionsColumn.AllowEdit = false;
            this.treeListColumn5.Visible = true;
            this.treeListColumn5.VisibleIndex = 0;
            this.treeListColumn5.Width = 20;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "Code";
            this.treeListColumn2.FieldName = "Code";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            this.treeListColumn2.Width = 24;
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "Description";
            this.treeListColumn3.FieldName = "Description";
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.Visible = true;
            this.treeListColumn3.VisibleIndex = 2;
            this.treeListColumn3.Width = 281;
            // 
            // treeListColumn6
            // 
            this.treeListColumn6.Caption = "File";
            this.treeListColumn6.FieldName = "File";
            this.treeListColumn6.Name = "treeListColumn6";
            this.treeListColumn6.Visible = true;
            this.treeListColumn6.VisibleIndex = 3;
            this.treeListColumn6.Width = 89;
            // 
            // treeListColumn4
            // 
            this.treeListColumn4.Caption = "Line";
            this.treeListColumn4.FieldName = "Line";
            this.treeListColumn4.Name = "treeListColumn4";
            this.treeListColumn4.Visible = true;
            this.treeListColumn4.VisibleIndex = 4;
            this.treeListColumn4.Width = 53;
            // 
            // OutputPanel
            // 
            this.OutputPanel.Controls.Add(this.dockPanel4_Container);
            this.OutputPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.OutputPanel.ID = new System.Guid("21f65035-ef2e-4a7f-9c5b-bc8aaadc1c66");
            this.OutputPanel.Location = new System.Drawing.Point(492, 0);
            this.OutputPanel.Name = "OutputPanel";
            this.OutputPanel.Options.ShowCloseButton = false;
            this.OutputPanel.OriginalSize = new System.Drawing.Size(978, 121);
            this.OutputPanel.Size = new System.Drawing.Size(492, 174);
            this.OutputPanel.Text = "Output";
            this.OutputPanel.Click += new System.EventHandler(this.dockPanel4_Click);
            // 
            // dockPanel4_Container
            // 
            this.dockPanel4_Container.Controls.Add(this.Output);
            this.dockPanel4_Container.Location = new System.Drawing.Point(3, 26);
            this.dockPanel4_Container.Name = "dockPanel4_Container";
            this.dockPanel4_Container.Size = new System.Drawing.Size(486, 145);
            this.dockPanel4_Container.TabIndex = 0;
            // 
            // Output
            // 
            this.Output.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.Output.Appearance.Text.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.Appearance.Text.Options.UseFont = true;
            this.Output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Output.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            this.Output.Location = new System.Drawing.Point(0, 0);
            this.Output.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            this.Output.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Output.MenuManager = this.Toolbars;
            this.Output.Name = "Output";
            this.Output.Options.Behavior.ShowPopupMenu = DevExpress.XtraRichEdit.DocumentCapability.Disabled;
            this.Output.Options.DocumentCapabilities.Bookmarks = DevExpress.XtraRichEdit.DocumentCapability.Disabled;
            this.Output.Options.DocumentCapabilities.CharacterFormatting = DevExpress.XtraRichEdit.DocumentCapability.Enabled;
            this.Output.Options.DocumentCapabilities.EndNotes = DevExpress.XtraRichEdit.DocumentCapability.Disabled;
            this.Output.Options.DocumentCapabilities.FloatingObjects = DevExpress.XtraRichEdit.DocumentCapability.Disabled;
            this.Output.ReadOnly = true;
            this.Output.Size = new System.Drawing.Size(486, 145);
            this.Output.TabIndex = 7;
            this.Output.Views.SimpleView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.Output.Click += new System.EventHandler(this.Output_Click);
            // 
            // ProjectPanel
            // 
            this.ProjectPanel.Controls.Add(this.dockPanel1_Container);
            this.ProjectPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.ProjectPanel.ID = new System.Guid("8756d4fd-d028-4641-853f-c06b6762460e");
            this.ProjectPanel.Location = new System.Drawing.Point(0, 50);
            this.ProjectPanel.Name = "ProjectPanel";
            this.ProjectPanel.Options.ShowCloseButton = false;
            this.ProjectPanel.OriginalSize = new System.Drawing.Size(200, 200);
            this.ProjectPanel.Size = new System.Drawing.Size(200, 333);
            this.ProjectPanel.Text = "Project Explorer";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.ProjectExplorer);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 25);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(193, 305);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // ProjectExplorer
            // 
            this.ProjectExplorer.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(117)))), ((int)(((byte)(196)))));
            this.ProjectExplorer.Appearance.FocusedCell.Options.UseBackColor = true;
            this.ProjectExplorer.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(117)))), ((int)(((byte)(196)))));
            this.ProjectExplorer.Appearance.FocusedRow.Options.UseBackColor = true;
            this.ProjectExplorer.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(117)))), ((int)(((byte)(196)))));
            this.ProjectExplorer.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.ProjectExplorer.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(117)))), ((int)(((byte)(196)))));
            this.ProjectExplorer.Appearance.SelectedRow.Options.UseBackColor = true;
            this.ProjectExplorer.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1});
            this.ProjectExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectExplorer.Location = new System.Drawing.Point(0, 0);
            this.ProjectExplorer.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            this.ProjectExplorer.LookAndFeel.UseDefaultLookAndFeel = false;
            this.ProjectExplorer.Name = "ProjectExplorer";
            this.ProjectExplorer.BeginUnboundLoad();
            this.ProjectExplorer.AppendNode(new object[] {
            "README"}, -1);
            this.ProjectExplorer.EndUnboundLoad();
            this.ProjectExplorer.OptionsBehavior.AutoChangeParent = false;
            this.ProjectExplorer.OptionsBehavior.Editable = false;
            this.ProjectExplorer.OptionsCustomization.AllowBandMoving = false;
            this.ProjectExplorer.OptionsCustomization.AllowColumnMoving = false;
            this.ProjectExplorer.OptionsCustomization.AllowQuickHideColumns = false;
            this.ProjectExplorer.OptionsFilter.AllowFilterEditor = false;
            this.ProjectExplorer.OptionsLayout.AddNewColumns = false;
            this.ProjectExplorer.OptionsMenu.EnableColumnMenu = false;
            this.ProjectExplorer.OptionsMenu.EnableFooterMenu = false;
            this.ProjectExplorer.OptionsMenu.ShowAutoFilterRowItem = false;
            this.ProjectExplorer.OptionsSelection.SelectNodesOnRightClick = true;
            this.ProjectExplorer.Size = new System.Drawing.Size(193, 305);
            this.ProjectExplorer.TabIndex = 0;
            this.ProjectExplorer.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeList1_FocusedNodeChanged);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "GSC Scripts";
            this.treeListColumn1.FieldName = "GSC_Name";
            this.treeListColumn1.MinWidth = 88;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 88;
            // 
            // dockPanel2
            // 
            this.dockPanel2.Controls.Add(this.dockPanel2_Container);
            this.dockPanel2.DockedAsTabbedDocument = true;
            this.dockPanel2.FloatLocation = new System.Drawing.Point(612, 346);
            this.dockPanel2.ID = new System.Guid("5fc036f9-3aec-44c8-94e1-61544f73c388");
            this.dockPanel2.Name = "dockPanel2";
            this.dockPanel2.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel2.SavedIndex = 2;
            this.dockPanel2.SavedMdiDocument = true;
            this.dockPanel2.Text = "README";
            this.dockPanel2.Click += new System.EventHandler(this.dockPanel2_Click);
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Location = new System.Drawing.Point(0, 0);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(778, 306);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Connect";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Project";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Build";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barSubItem4
            // 
            this.barSubItem4.Caption = "Settings";
            this.barSubItem4.Id = 7;
            this.barSubItem4.Name = "barSubItem4";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "XBOX 360";
            this.barButtonItem6.Id = 12;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "XBOX 360";
            this.barButtonItem7.Id = 13;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barSubItem7
            // 
            this.barSubItem7.Caption = "Redacted";
            this.barSubItem7.Id = 14;
            this.barSubItem7.Name = "barSubItem7";
            // 
            // barButtonItem14
            // 
            this.barButtonItem14.Caption = "Add New Script";
            this.barButtonItem14.Id = 23;
            this.barButtonItem14.Name = "barButtonItem14";
            // 
            // barButtonItem15
            // 
            this.barButtonItem15.Caption = "Check Script Syntax";
            this.barButtonItem15.Id = 24;
            this.barButtonItem15.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.barButtonItem15.Name = "barButtonItem15";
            this.barButtonItem15.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem15_ItemClick);
            // 
            // barButtonItem16
            // 
            this.barButtonItem16.Caption = "Compile";
            this.barButtonItem16.Id = 25;
            this.barButtonItem16.Name = "barButtonItem16";
            // 
            // barSubItem10
            // 
            this.barSubItem10.Caption = "Compile to GSC";
            this.barSubItem10.Id = 26;
            this.barSubItem10.Name = "barSubItem10";
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.BindableChecked = true;
            this.barCheckItem1.Caption = "Auto-Update";
            this.barCheckItem1.Checked = true;
            this.barCheckItem1.Id = 34;
            this.barCheckItem1.Name = "barCheckItem1";
            // 
            // barButtonItem28
            // 
            this.barButtonItem28.Caption = "barButtonItem28";
            this.barButtonItem28.Id = 40;
            this.barButtonItem28.Name = "barButtonItem28";
            // 
            // barButtonItem29
            // 
            this.barButtonItem29.Caption = "Import";
            this.barButtonItem29.Id = 41;
            this.barButtonItem29.Name = "barButtonItem29";
            this.barButtonItem29.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem29_ItemClick);
            // 
            // barSubItem12
            // 
            this.barSubItem12.Caption = "Import";
            this.barSubItem12.Id = 42;
            this.barSubItem12.Name = "barSubItem12";
            // 
            // barButtonItem31
            // 
            this.barButtonItem31.Caption = "Export to GSC Studio Project";
            this.barButtonItem31.Id = 44;
            this.barButtonItem31.Name = "barButtonItem31";
            // 
            // barCheckItem2
            // 
            this.barCheckItem2.BindableChecked = true;
            this.barCheckItem2.Caption = "Protect My Source";
            this.barCheckItem2.Checked = true;
            this.barCheckItem2.Id = 45;
            this.barCheckItem2.Name = "barCheckItem2";
            this.barCheckItem2.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckItem2_CheckedChanged);
            // 
            // barSubItem14
            // 
            this.barSubItem14.Caption = "Output Window";
            this.barSubItem14.Id = 48;
            this.barSubItem14.Name = "barSubItem14";
            // 
            // barButtonItem33
            // 
            this.barButtonItem33.Caption = "Clear Console";
            this.barButtonItem33.Id = 49;
            this.barButtonItem33.Name = "barButtonItem33";
            this.barButtonItem33.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem33_ItemClick);
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "barStaticItem2";
            this.barStaticItem2.Id = 51;
            this.barStaticItem2.Name = "barStaticItem2";
            // 
            // barButtonItem35
            // 
            this.barButtonItem35.Caption = "Rename";
            this.barButtonItem35.Id = 52;
            this.barButtonItem35.Name = "barButtonItem35";
            this.barButtonItem35.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem35_ItemClick);
            // 
            // barButtonItem36
            // 
            this.barButtonItem36.Caption = "Delete Script";
            this.barButtonItem36.Id = 53;
            this.barButtonItem36.Name = "barButtonItem36";
            this.barButtonItem36.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem36_ItemClick);
            // 
            // barButtonItem37
            // 
            this.barButtonItem37.Caption = "Delete File";
            this.barButtonItem37.Id = 54;
            this.barButtonItem37.Name = "barButtonItem37";
            this.barButtonItem37.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem37_ItemClick);
            // 
            // barButtonItem38
            // 
            this.barButtonItem38.Caption = "Edit File Name";
            this.barButtonItem38.Id = 55;
            this.barButtonItem38.Name = "barButtonItem38";
            this.barButtonItem38.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem38_ItemClick);
            // 
            // barButtonItem39
            // 
            this.barButtonItem39.Caption = "Add New File";
            this.barButtonItem39.Id = 56;
            this.barButtonItem39.Name = "barButtonItem39";
            this.barButtonItem39.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem39_ItemClick);
            // 
            // barCheckItem3
            // 
            this.barCheckItem3.Caption = "Zombies Project";
            this.barCheckItem3.Id = 57;
            this.barCheckItem3.Name = "barCheckItem3";
            // 
            // barButtonItem40
            // 
            this.barButtonItem40.Caption = "Toggle Zombies Project";
            this.barButtonItem40.Id = 58;
            this.barButtonItem40.Name = "barButtonItem40";
            // 
            // ZombiesToggle
            // 
            this.ZombiesToggle.Caption = "Zombies Project";
            this.ZombiesToggle.Id = 59;
            this.ZombiesToggle.Name = "ZombiesToggle";
            // 
            // barSubItem15
            // 
            this.barSubItem15.Caption = "Project Options";
            this.barSubItem15.Id = 60;
            this.barSubItem15.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.ZombiesToggle)});
            this.barSubItem15.Name = "barSubItem15";
            // 
            // barButtonItem42
            // 
            this.barButtonItem42.Caption = "barButtonItem42";
            this.barButtonItem42.Id = 62;
            this.barButtonItem42.Name = "barButtonItem42";
            // 
            // barStaticItem3
            // 
            this.barStaticItem3.Caption = "GSX Studio by Serious";
            this.barStaticItem3.Id = 66;
            this.barStaticItem3.Name = "barStaticItem3";
            // 
            // barButtonItem45
            // 
            this.barButtonItem45.Caption = "Clear Output Window";
            this.barButtonItem45.Id = 67;
            this.barButtonItem45.Name = "barButtonItem45";
            this.barButtonItem45.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem45_ItemClick);
            // 
            // barButtonItem46
            // 
            this.barButtonItem46.Caption = "Delete Subgroup";
            this.barButtonItem46.Id = 68;
            this.barButtonItem46.Name = "barButtonItem46";
            this.barButtonItem46.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem46_ItemClick);
            // 
            // barButtonItem47
            // 
            this.barButtonItem47.Caption = "Set Project Name";
            this.barButtonItem47.Id = 70;
            this.barButtonItem47.Name = "barButtonItem47";
            // 
            // barButtonItem48
            // 
            this.barButtonItem48.Caption = "Set Creator Name";
            this.barButtonItem48.Id = 71;
            this.barButtonItem48.Name = "barButtonItem48";
            // 
            // barButtonItem49
            // 
            this.barButtonItem49.Caption = "New Script File";
            this.barButtonItem49.Id = 72;
            this.barButtonItem49.Name = "barButtonItem49";
            this.barButtonItem49.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem49_ItemClick);
            // 
            // barButtonItem51
            // 
            this.barButtonItem51.Caption = "Check File Syntax";
            this.barButtonItem51.Id = 74;
            this.barButtonItem51.Name = "barButtonItem51";
            this.barButtonItem51.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem51_ItemClick);
            // 
            // DebugToggleSwitch
            // 
            this.DebugToggleSwitch.BindableChecked = true;
            this.DebugToggleSwitch.Caption = "Debug Mode";
            this.DebugToggleSwitch.Checked = true;
            this.DebugToggleSwitch.Id = 75;
            this.DebugToggleSwitch.Name = "DebugToggleSwitch";
            // 
            // barToggleSwitchItem1
            // 
            this.barToggleSwitchItem1.Caption = "hhhh";
            this.barToggleSwitchItem1.Id = 76;
            this.barToggleSwitchItem1.Name = "barToggleSwitchItem1";
            // 
            // barEditItem2
            // 
            this.barEditItem2.Caption = "Inline";
            this.barEditItem2.Edit = this.repositoryItemComboBox2;
            this.barEditItem2.EditWidth = 87;
            this.barEditItem2.Enabled = false;
            this.barEditItem2.Id = 78;
            this.barEditItem2.Name = "barEditItem2";
            this.barEditItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barEditItem2_ItemClick);
            // 
            // repositoryItemComboBox2
            // 
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemComboBox2.Items.AddRange(new object[] {
            "Inline on",
            "Smart inline",
            "Inline off"});
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            this.repositoryItemComboBox2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // barStaticItem4
            // 
            this.barStaticItem4.Caption = "Inline";
            this.barStaticItem4.Id = 79;
            this.barStaticItem4.Name = "barStaticItem4";
            this.barStaticItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barStaticItem4_ItemClick);
            // 
            // barLargeButtonItem1
            // 
            this.barLargeButtonItem1.Caption = "barLargeButtonItem1";
            this.barLargeButtonItem1.Id = 80;
            this.barLargeButtonItem1.Name = "barLargeButtonItem1";
            // 
            // barEditItem3
            // 
            this.barEditItem3.Caption = "barEditItem3";
            this.barEditItem3.Edit = this.repositoryItemTextEdit1;
            this.barEditItem3.Id = 81;
            this.barEditItem3.Name = "barEditItem3";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // barButtonItem52
            // 
            this.barButtonItem52.Caption = "barButtonItem52";
            this.barButtonItem52.Id = 82;
            this.barButtonItem52.Name = "barButtonItem52";
            // 
            // barEditItem4
            // 
            this.barEditItem4.Caption = "barEditItem4";
            this.barEditItem4.Edit = this.repositoryItemTextEdit2;
            this.barEditItem4.Id = 83;
            this.barEditItem4.Name = "barEditItem4";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // barEditItem5
            // 
            this.barEditItem5.Caption = "typestrict";
            this.barEditItem5.Edit = this.repositoryItemComboBox3;
            this.barEditItem5.EditWidth = 75;
            this.barEditItem5.Id = 84;
            this.barEditItem5.Name = "barEditItem5";
            // 
            // repositoryItemComboBox3
            // 
            this.repositoryItemComboBox3.AutoHeight = false;
            this.repositoryItemComboBox3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemComboBox3.Name = "repositoryItemComboBox3";
            // 
            // barButtonItem53
            // 
            this.barButtonItem53.Caption = "Build";
            this.barButtonItem53.Id = 85;
            this.barButtonItem53.ImageOptions.ImageUri.Uri = "Zoom2";
            this.barButtonItem53.Name = "barButtonItem53";
            // 
            // barButtonItem55
            // 
            this.barButtonItem55.Caption = "Save File";
            this.barButtonItem55.Id = 87;
            this.barButtonItem55.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem55.ImageOptions.Image")));
            this.barButtonItem55.Name = "barButtonItem55";
            // 
            // barEditItem6
            // 
            this.barEditItem6.Caption = "barEditItem6";
            this.barEditItem6.Edit = this.repositoryItemComboBox4;
            this.barEditItem6.Id = 92;
            this.barEditItem6.Name = "barEditItem6";
            // 
            // repositoryItemComboBox4
            // 
            this.repositoryItemComboBox4.AutoHeight = false;
            this.repositoryItemComboBox4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemComboBox4.Name = "repositoryItemComboBox4";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "Progress";
            this.barEditItem1.Edit = this.repositoryItemProgressBar1;
            this.barEditItem1.Id = 96;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemProgressBar1
            // 
            this.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
            // 
            // Bar_BuildSettings
            // 
            this.Bar_BuildSettings.Caption = "Build Settings";
            this.Bar_BuildSettings.Id = 98;
            this.Bar_BuildSettings.Name = "Bar_BuildSettings";
            // 
            // BuildSettingsButton
            // 
            this.BuildSettingsButton.Caption = "Build Settings";
            this.BuildSettingsButton.Id = 99;
            this.BuildSettingsButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BuildSettingsButton.ImageOptions.Image")));
            this.BuildSettingsButton.Name = "BuildSettingsButton";
            this.BuildSettingsButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BuildSettingsButton_ItemClick);
            // 
            // barButtonItem13
            // 
            this.barButtonItem13.Caption = "Optimize Child Variables";
            this.barButtonItem13.Id = 102;
            this.barButtonItem13.Name = "barButtonItem13";
            this.barButtonItem13.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem13_ItemClick_2);
            // 
            // barButtonItem17
            // 
            this.barButtonItem17.Caption = "barButtonItem17";
            this.barButtonItem17.Id = 103;
            this.barButtonItem17.Name = "barButtonItem17";
            // 
            // barButtonItem18
            // 
            this.barButtonItem18.Caption = "Connect Using JRPC";
            this.barButtonItem18.Id = 106;
            this.barButtonItem18.Name = "barButtonItem18";
            // 
            // barSubItem18
            // 
            this.barSubItem18.Caption = "Share";
            this.barSubItem18.Id = 107;
            this.barSubItem18.Name = "barSubItem18";
            // 
            // barButtonItem19
            // 
            this.barButtonItem19.Caption = "Publish Project";
            this.barButtonItem19.Id = 108;
            this.barButtonItem19.Name = "barButtonItem19";
            // 
            // barSubItem19
            // 
            this.barSubItem19.Caption = "Share";
            this.barSubItem19.Id = 109;
            this.barSubItem19.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem32),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem34),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem41)});
            this.barSubItem19.Name = "barSubItem19";
            // 
            // barButtonItem32
            // 
            this.barButtonItem32.Caption = "Share Project Source";
            this.barButtonItem32.Id = 110;
            this.barButtonItem32.Name = "barButtonItem32";
            // 
            // barButtonItem34
            // 
            this.barButtonItem34.Caption = "Share Package";
            this.barButtonItem34.Id = 111;
            this.barButtonItem34.Name = "barButtonItem34";
            // 
            // barButtonItem41
            // 
            this.barButtonItem41.Caption = "Share Project as Library";
            this.barButtonItem41.Id = 112;
            this.barButtonItem41.Name = "barButtonItem41";
            // 
            // barButtonItem43
            // 
            this.barButtonItem43.Caption = "Fast Files";
            this.barButtonItem43.Id = 114;
            this.barButtonItem43.Name = "barButtonItem43";
            this.barButtonItem43.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem43_ItemClick);
            // 
            // barButtonItem44
            // 
            this.barButtonItem44.Caption = "Manage Your Libraries";
            this.barButtonItem44.Id = 115;
            this.barButtonItem44.Name = "barButtonItem44";
            // 
            // barSubItem21
            // 
            this.barSubItem21.Caption = "Manage";
            this.barSubItem21.Id = 116;
            this.barSubItem21.Name = "barSubItem21";
            // 
            // barButtonItem54
            // 
            this.barButtonItem54.Caption = "Project";
            this.barButtonItem54.Id = 117;
            this.barButtonItem54.Name = "barButtonItem54";
            // 
            // barButtonItem57
            // 
            this.barButtonItem57.Caption = "Share Project";
            this.barButtonItem57.Id = 119;
            this.barButtonItem57.Name = "barButtonItem57";
            // 
            // barSubItem22
            // 
            this.barSubItem22.Caption = "Manage";
            this.barSubItem22.Id = 120;
            this.barSubItem22.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem60),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem61),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem62)});
            this.barSubItem22.Name = "barSubItem22";
            // 
            // barButtonItem60
            // 
            this.barButtonItem60.Caption = "Import Libraries";
            this.barButtonItem60.Id = 121;
            this.barButtonItem60.Name = "barButtonItem60";
            // 
            // barButtonItem61
            // 
            this.barButtonItem61.Caption = "Reload Libraries";
            this.barButtonItem61.Id = 122;
            this.barButtonItem61.Name = "barButtonItem61";
            // 
            // barButtonItem62
            // 
            this.barButtonItem62.Caption = "Library Manager";
            this.barButtonItem62.Id = 123;
            this.barButtonItem62.Name = "barButtonItem62";
            // 
            // barButtonItem66
            // 
            this.barButtonItem66.Caption = "Platform Tools";
            this.barButtonItem66.Id = 128;
            this.barButtonItem66.Name = "barButtonItem66";
            // 
            // Toolbarsmanager
            // 
            this.Toolbarsmanager.Controller.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            this.Toolbarsmanager.Controller.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Toolbarsmanager.Controller.PaintStyleName = "Skin";
            // 
            // documentManager1
            // 
            this.documentManager1.ContainerControl = this;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // tabbedView1
            // 
            this.tabbedView1.DocumentGroupProperties.HeaderButtons = DevExpress.XtraTab.TabButtons.None;
            this.tabbedView1.DocumentGroupProperties.HeaderButtonsShowMode = DevExpress.XtraTab.TabButtonShowMode.Never;
            this.tabbedView1.DocumentGroups.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup[] {
            this.documentGroup2});
            this.tabbedView1.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseDocument[] {
            this.document1});
            dockingContainer2.Element = this.documentGroup2;
            this.tabbedView1.RootContainer.Nodes.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer[] {
            dockingContainer2});
            // 
            // SRightClick
            // 
            this.SRightClick.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem39),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem35),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem36)});
            this.SRightClick.Manager = this.Toolbars;
            this.SRightClick.MenuCaption = "Edit Script";
            this.SRightClick.Name = "SRightClick";
            // 
            // PRightClick
            // 
            this.PRightClick.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem38),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem37)});
            this.PRightClick.Manager = this.Toolbars;
            this.PRightClick.Name = "PRightClick";
            // 
            // OutputPopup
            // 
            this.OutputPopup.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem45)});
            this.OutputPopup.Manager = this.Toolbars;
            this.OutputPopup.Name = "OutputPopup";
            // 
            // SubgroupPopup
            // 
            this.SubgroupPopup.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem49),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem46)});
            this.SubgroupPopup.Manager = this.Toolbars;
            this.SubgroupPopup.Name = "SubgroupPopup";
            // 
            // ColorTool
            // 
            this.ColorTool.FullOpen = true;
            // 
            // SyntaxTimer
            // 
            this.SyntaxTimer.Interval = 1500;
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 581);
            this.Controls.Add(this.ProjectPanel);
            this.Controls.Add(this.panelContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "MyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Black Ops II - GSX Studio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toolbars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuildModeCombo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuildTargetCombo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.panelContainer1.ResumeLayout(false);
            this.ErrorPanel.ResumeLayout(false);
            this.dockPanel3_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorConsole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            this.OutputPanel.ResumeLayout(false);
            this.dockPanel4_Container.ResumeLayout(false);
            this.ProjectPanel.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProjectExplorer)).EndInit();
            this.dockPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toolbarsmanager.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SRightClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRightClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputPopup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubgroupPopup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		[global::System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		protected override void Dispose([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool A_0)
		{
            if (A_0)
            {
                try { this.CleanupManaged(); }
                finally { base.Dispose(true); }
                return;
            }
            base.Dispose(false);
		}

		private global::DevExpress.XtraBars.BarSubItem barSubItem13;

		private global::DevExpress.XtraBars.BarSubItem barSubItem14;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem33;

		private global::DevExpress.XtraBars.BarButtonItem DropDown_Close;

		private global::DevExpress.XtraBars.BarStaticItem barStaticItem2;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem35;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem36;

		private global::DevExpress.XtraBars.PopupMenu SRightClick;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem37;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem38;

		private global::DevExpress.XtraBars.PopupMenu PRightClick;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem39;

		private global::DevExpress.XtraBars.BarButtonItem DropDown_NewScript;

		private global::DevExpress.XtraBars.BarSubItem barSubItem15;

		private global::DevExpress.XtraBars.BarCheckItem ZombiesToggle;

		private global::DevExpress.XtraBars.BarCheckItem barCheckItem3;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem40;

		private global::DevExpress.XtraBars.BarSubItem barSubItem16;

		private global::DevExpress.XtraBars.BarButtonItem DropDown_ConvertZ;

		private global::DevExpress.XtraBars.BarButtonItem DropDown_ConvertM;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem42;

		private global::DevExpress.XtraBars.BarStaticItem barStaticItem3;

		private global::DevExpress.XtraBars.PopupMenu OutputPopup;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem45;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem46;

		private global::DevExpress.XtraBars.PopupMenu SubgroupPopup;

		private global::DevExpress.XtraBars.BarSubItem DropDown_ProjectSub;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem47;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem48;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem49;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem50;

		private global::System.Windows.Forms.ColorDialog ColorTool;

		private global::DevExpress.XtraTreeList.TreeList ErrorConsole;

		private global::DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn5;

		private global::DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;

		private global::DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;

		private global::DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn4;

		private global::DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn6;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem51;

		private global::DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;

		private global::System.Windows.Forms.Timer SyntaxTimer;

		private global::DevExpress.XtraBars.Bar bar1;

		private global::DevExpress.XtraBars.BarEditItem BuildMode;

		private global::DevExpress.XtraEditors.Repository.RepositoryItemComboBox BuildModeCombo;

		private global::DevExpress.XtraBars.BarCheckItem DebugToggleSwitch;

		private global::DevExpress.XtraBars.BarToggleSwitchItem barToggleSwitchItem1;

		private global::DevExpress.XtraBars.BarStaticItem barStaticItem4;

		private global::DevExpress.XtraBars.BarEditItem barEditItem2;

		private global::DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;

		private global::DevExpress.XtraBars.BarButtonItem ToolbarBuildProject;

		private global::DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem1;

		private global::DevExpress.XtraBars.BarEditItem barEditItem3;

		private global::DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem52;

		private global::DevExpress.XtraBars.BarEditItem barEditItem4;

		private global::DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;

		private global::DevExpress.XtraBars.BarEditItem barEditItem5;

		private global::DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox3;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem53;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem55;

		private global::DevExpress.XtraBars.BarButtonItem Toolbar_Save;

		private global::DevExpress.XtraBars.BarButtonItem Toolbar_SaveAll;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem58;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem59;

		private global::DevExpress.XtraBars.BarEditItem barEditItem6;

		private global::DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox4;

		private global::DevExpress.XtraBars.BarEditItem BuildTarget;

		private global::DevExpress.XtraEditors.Repository.RepositoryItemComboBox BuildTargetCombo;

		private global::DevExpress.XtraBars.BarButtonItem DropDown_PSettings;

		private global::DevExpress.XtraBars.BarButtonItem ToolbarPSettings;

		private global::DevExpress.XtraBars.Docking.DockPanel panelContainer1;

		private global::DevExpress.XtraBars.BarEditItem barEditItem1;

		private global::DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar1;

		private global::DevExpress.XtraBars.BarButtonItem Tools_ProjectRepair;

		private global::DevExpress.XtraBars.BarButtonItem BuildSettingsButton;

		private global::DevExpress.XtraBars.BarButtonItem Bar_BuildSettings;

		private global::DevExpress.XtraBars.BarSubItem barSubItem17;

		private global::DevExpress.XtraBars.BarCheckItem Build_Scripts;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem13;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem17;

		private global::DevExpress.XtraBars.BarCheckItem Build_Children;

		private global::DevExpress.XtraBars.BarCheckItem Build_Symbolize;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem18;

		private global::DevExpress.XtraBars.BarSubItem barSubItem18;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem19;

		private global::DevExpress.XtraBars.BarSubItem barSubItem19;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem32;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem34;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem41;

		private global::DevExpress.XtraBars.BarSubItem barSubItem20;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem43;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem56;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem64;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem63;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem65;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem44;

		private global::DevExpress.XtraBars.BarSubItem barSubItem21;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem54;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem57;

		private global::DevExpress.XtraBars.BarSubItem barSubItem22;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem60;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem61;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem62;

		private global::DevExpress.XtraBars.BarSubItem barSubItem23;

		private global::DevExpress.XtraBars.BarSubItem barSubItem24;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem67;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem66;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem68;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem69;

		private global::DevExpress.XtraBars.BarManager Toolbars;

		private global::DevExpress.XtraBars.Bar bar2;

		private global::DevExpress.XtraBars.Bar bar3;

		private global::DevExpress.XtraBars.BarDockControl barDockControlTop;

		private global::DevExpress.XtraBars.BarDockControl barDockControlBottom;

		private global::DevExpress.XtraBars.BarDockControl barDockControlLeft;

		private global::DevExpress.XtraBars.BarDockControl barDockControlRight;

		private global::DevExpress.XtraBars.BarSubItem barSubItem1;

		private global::DevExpress.XtraBars.BarSubItem barSubItem2;

		private global::DevExpress.XtraBars.BarSubItem barSubItem3;

		private global::DevExpress.XtraBars.BarSubItem barSubItem4;

		private global::DevExpress.XtraBars.BarSubItem barSubItem5;

		private global::DevExpress.XtraBars.BarStaticItem StatusLabel;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem1;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem2;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem3;

		private global::DevExpress.XtraBars.DefaultBarAndDockingController Toolbarsmanager;

		private global::DevExpress.XtraBars.BarSubItem barSubItem6;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem4;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem5;

		private global::DevExpress.XtraBars.BarSubItem barSubItem8;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem8;

		private global::DevExpress.XtraBars.BarSubItem barSubItem9;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem9;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem10;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem11;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem12;

		private global::DevExpress.XtraBars.BarButtonItem DropDown_SaveAll;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem15;

		private global::DevExpress.XtraBars.BarSubItem barSubItem10;

		private global::DevExpress.XtraBars.BarButtonItem DropDown_BuildC;

		private global::DevExpress.XtraBars.BarButtonItem DropDown_BuildPC;

		private global::DevExpress.XtraBars.BarButtonItem DropDown_BuildPK;

		private global::DevExpress.XtraBars.BarSubItem barSubItem11;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem20;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem21;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem22;

		private global::DevExpress.XtraBars.BarCheckItem barCheckItem1;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem6;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem7;

		private global::DevExpress.XtraBars.BarSubItem barSubItem7;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem14;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem16;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem23;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem24;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem25;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem26;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem27;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem29;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem28;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem30;

		private global::DevExpress.XtraBars.BarCheckItem barCheckItem2;

		private global::DevExpress.XtraBars.BarSubItem barSubItem12;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem31;

		private global::DevExpress.XtraBars.Docking.DockManager dockManager1;

		private global::DevExpress.XtraBars.Docking.DockPanel ProjectPanel;

		private global::DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;

		private global::DevExpress.XtraBars.Docking.DockPanel dockPanel2;

		private global::DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;

		private global::DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;

		private global::DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;

		private global::DevExpress.XtraBars.Docking2010.Views.Tabbed.Document document1;

		private global::DevExpress.XtraTreeList.TreeList ProjectExplorer;

		private global::DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;

		private global::DevExpress.XtraBars.BarButtonItem DropDown_Save;

		private global::DevExpress.XtraBars.Docking.DockPanel ErrorPanel;

		private global::DevExpress.XtraBars.Docking.ControlContainer dockPanel3_Container;

		private global::DevExpress.XtraBars.Docking.DockPanel OutputPanel;

		private global::DevExpress.XtraBars.Docking.ControlContainer dockPanel4_Container;

		private global::DevExpress.XtraRichEdit.RichEditControl Output;

		private global::System.ComponentModel.IContainer components;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup documentGroup2;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup documentGroup1;
    }
}
