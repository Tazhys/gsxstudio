using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;

namespace GSX_Studio
{
	public partial class RenamePartDialog : XtraForm
	{
		public RenamePartDialog()
		{
			try
			{
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

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		private void simpleButton2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		private Container components;
	}
}
