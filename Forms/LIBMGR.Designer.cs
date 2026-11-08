namespace GSX_Studio
{
	public partial class LIBMGR : global::DevExpress.XtraEditors.XtraForm
	{
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.LibList = new DevExpress.XtraTab.XtraTabPage();
            this.ProjectsList = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn4 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.LibCreator = new DevExpress.XtraTab.XtraTabPage();
            this.DownloadLibs = new DevExpress.XtraTab.XtraTabPage();
            this.InstallRightClickMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.LibList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InstallRightClickMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.LibList;
            this.xtraTabControl1.Size = new System.Drawing.Size(764, 461);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.LibList,
            this.LibCreator,
            this.DownloadLibs});
            // 
            // LibList
            // 
            this.LibList.Controls.Add(this.ProjectsList);
            this.LibList.Name = "LibList";
            this.LibList.Size = new System.Drawing.Size(762, 434);
            this.LibList.Text = "Installed Libraries";
            // 
            // ProjectsList
            // 
            this.ProjectsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectsList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2,
            this.treeListColumn3,
            this.treeListColumn4});
            this.ProjectsList.Location = new System.Drawing.Point(10, 10);
            this.ProjectsList.Name = "ProjectsList";
            this.ProjectsList.OptionsBehavior.Editable = false;
            this.ProjectsList.OptionsBehavior.EditorShowMode = DevExpress.XtraTreeList.TreeListEditorShowMode.MouseDownFocused;
            this.ProjectsList.OptionsCustomization.AllowBandMoving = false;
            this.ProjectsList.OptionsCustomization.AllowColumnMoving = false;
            this.ProjectsList.OptionsCustomization.AllowQuickHideColumns = false;
            this.ProjectsList.OptionsCustomization.ShowBandsInCustomizationForm = false;
            this.ProjectsList.OptionsLayout.AddNewColumns = false;
            this.ProjectsList.OptionsMenu.EnableColumnMenu = false;
            this.ProjectsList.OptionsMenu.EnableFooterMenu = false;
            this.ProjectsList.OptionsMenu.ShowAutoFilterRowItem = false;
            this.ProjectsList.OptionsSelection.SelectNodesOnRightClick = true;
            this.ProjectsList.Size = new System.Drawing.Size(740, 411);
            this.ProjectsList.TabIndex = 13;
            this.ProjectsList.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.ProjectsList_FocusedNodeChanged);
            this.ProjectsList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ExplorerOnMouseClick);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Library Title";
            this.treeListColumn1.FieldName = "Project Name";
            this.treeListColumn1.MinWidth = 34;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.OptionsColumn.AllowEdit = false;
            this.treeListColumn1.OptionsColumn.AllowMove = false;
            this.treeListColumn1.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.treeListColumn1.OptionsColumn.AllowSort = false;
            this.treeListColumn1.OptionsColumn.ReadOnly = true;
            this.treeListColumn1.OptionsColumn.ShowInCustomizationForm = false;
            this.treeListColumn1.OptionsColumn.ShowInExpressionEditor = false;
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "Library Name";
            this.treeListColumn2.FieldName = "Library Name";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.OptionsColumn.AllowEdit = false;
            this.treeListColumn2.OptionsColumn.AllowMove = false;
            this.treeListColumn2.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.treeListColumn2.OptionsColumn.AllowSort = false;
            this.treeListColumn2.OptionsColumn.ReadOnly = true;
            this.treeListColumn2.OptionsColumn.ShowInCustomizationForm = false;
            this.treeListColumn2.OptionsColumn.ShowInExpressionEditor = false;
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "Creator Name";
            this.treeListColumn3.FieldName = "Creator Name";
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.OptionsColumn.AllowEdit = false;
            this.treeListColumn3.OptionsColumn.AllowMove = false;
            this.treeListColumn3.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.treeListColumn3.OptionsColumn.AllowSort = false;
            this.treeListColumn3.OptionsColumn.ReadOnly = true;
            this.treeListColumn3.OptionsColumn.ShowInCustomizationForm = false;
            this.treeListColumn3.OptionsColumn.ShowInExpressionEditor = false;
            this.treeListColumn3.Visible = true;
            this.treeListColumn3.VisibleIndex = 2;
            // 
            // treeListColumn4
            // 
            this.treeListColumn4.Caption = "Type of Library";
            this.treeListColumn4.FieldName = "Type of Library";
            this.treeListColumn4.Name = "treeListColumn4";
            this.treeListColumn4.Visible = true;
            this.treeListColumn4.VisibleIndex = 3;
            // 
            // LibCreator
            // 
            this.LibCreator.Name = "LibCreator";
            this.LibCreator.Size = new System.Drawing.Size(762, 436);
            this.LibCreator.Text = "Library Editor";
            // 
            // DownloadLibs
            // 
            this.DownloadLibs.Name = "DownloadLibs";
            this.DownloadLibs.Size = new System.Drawing.Size(762, 436);
            this.DownloadLibs.Text = "Get New Libraries";
            // 
            // InstallRightClickMenu
            // 
            this.InstallRightClickMenu.Manager = this.barManager1;
            this.InstallRightClickMenu.Name = "InstallRightClickMenu";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2});
            this.barManager1.MaxItemId = 2;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(764, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 461);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(764, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 461);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(764, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 461);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Import New Library";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Delete Selected Library";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // LIBMGR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 461);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "LIBMGR";
            this.Text = "Library Manager";
            this.Load += new System.EventHandler(this.LIBMGR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.LibList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProjectsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InstallRightClickMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		[global::System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
		protected override void Dispose([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)] bool A_0)
		{
			if (A_0)
			{
				try
				{
					this.CleanupManaged();
					return;
				}
				finally
				{
					base.Dispose(true);
				}
			}
			base.Dispose(false);
		}

		private global::DevExpress.XtraTab.XtraTabControl xtraTabControl1;

		private global::DevExpress.XtraTab.XtraTabPage LibList;

		private global::DevExpress.XtraTab.XtraTabPage LibCreator;

		private global::DevExpress.XtraTab.XtraTabPage DownloadLibs;

		private global::DevExpress.XtraTreeList.TreeList ProjectsList;

		private global::DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;

		private global::DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;

		private global::DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;

		private global::DevExpress.XtraBars.PopupMenu InstallRightClickMenu;

		private global::DevExpress.XtraBars.BarManager barManager1;

		private global::DevExpress.XtraBars.BarDockControl barDockControlTop;

		private global::DevExpress.XtraBars.BarDockControl barDockControlBottom;

		private global::DevExpress.XtraBars.BarDockControl barDockControlLeft;

		private global::DevExpress.XtraBars.BarDockControl barDockControlRight;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem1;

		private global::DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn4;

		private global::DevExpress.XtraBars.BarButtonItem barButtonItem2;

		private global::System.ComponentModel.IContainer components;
	}
}
