using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace GSX_Studio
{
	public partial class NewPartDialog : XtraForm
	{
		public NewPartDialog()
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

		private void NewPartDialog_Load(object sender, EventArgs e)
		{
		}

		private void label1_Click(object sender, EventArgs e)
		{
		}

		private void textEdit1_EditValueChanged(object sender, EventArgs e)
		{
		}

		private void checkEdit1_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		private Container components;
	}
}
