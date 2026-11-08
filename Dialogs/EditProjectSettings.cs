using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace GSX_Studio
{
	public partial class EditProjectSettings : XtraForm
	{
		public EditProjectSettings(GSXProject project)
		{
			try
			{
				this.InitializeComponent();
				this.CreatorName.Text = project.CreatorName;
				this.Watermark.Text = project.Watermark;
				this.InlineMode.SelectedIndex = (int)project.InlineState;
				this.TypestrictMode.SelectedIndex = (int)project.TypeStrictState;
				this.Project = project;
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
			this.Project.CreatorName = this.CreatorName.Text;
			this.Project.Watermark = this.Watermark.Text;
			byte selectedIndex = (byte)this.InlineMode.SelectedIndex;
			this.Project.InlineState = selectedIndex;
			byte selectedIndex2 = (byte)this.TypestrictMode.SelectedIndex;
			this.Project.TypeStrictState = selectedIndex2;
			base.Close();
		}

		public GSXProject Project;

		private Container components;
	}
}
