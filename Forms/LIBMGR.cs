using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using GSXCompilerLib;

namespace GSX_Studio
{
	public partial class LIBMGR : XtraForm
	{
		public LIBMGR(string TargetMode)
		{
			try
			{
				SkinManager.EnableFormSkins();
				BonusSkins.Register();
				this.InitializeComponent();
			}
			catch
			{
				base.Dispose(true);
				throw;
			}
		}

		public void ExplorerOnMouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right && this.ProjectsList.Selection[0] != null && this.ProjectsList.Selection[0].GetValue(0).GetType() == typeof(GSXLibraries.GSXLibraryConfig))
			{
				Point location = e.Location;
				Point p = ((Control)sender).PointToScreen(location);
				this.InstallRightClickMenu.ShowPopup(p);
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

		private void ProjectsList_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
		{
		}

        private void LIBMGR_Load(object sender, EventArgs e)
        {

        }
    }
}
