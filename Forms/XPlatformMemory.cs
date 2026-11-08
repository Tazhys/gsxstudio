using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;

namespace GSX_Studio
{
	public partial class XPlatformMemory : XtraForm
	{
		public XPlatformMemory()
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

		private void CleanupManaged()
		{
			Container container = this.components;
			if (container != null)
			{
				((IDisposable)container).Dispose();
			}
		}

		private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private Container components;
	}
}
