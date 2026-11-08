namespace GSX_Studio
{
	public partial class AskToSaveDialog : global::DevExpress.XtraEditors.XtraForm
	{
		private void InitializeComponent()
		{
			this.labelControl1 = new global::DevExpress.XtraEditors.LabelControl();
			this.simpleButton1 = new global::DevExpress.XtraEditors.SimpleButton();
			this.simpleButton2 = new global::DevExpress.XtraEditors.SimpleButton();
			this.simpleButton3 = new global::DevExpress.XtraEditors.SimpleButton();
			base.SuspendLayout();
			this.labelControl1.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Drawing.Point location = new global::System.Drawing.Point(0xC, 0x19);
			this.labelControl1.Location = location;
			this.labelControl1.Name = "labelControl1";
			global::System.Drawing.Size size = new global::System.Drawing.Size(0x13B, 0x10);
			this.labelControl1.Size = size;
			this.labelControl1.TabIndex = 0;
			this.labelControl1.Text = "Save current project? All unsaved progress will be lost!";
			global::System.Drawing.Point location2 = new global::System.Drawing.Point(0xC, 0x49);
			this.simpleButton1.Location = location2;
			this.simpleButton1.Name = "simpleButton1";
			global::System.Drawing.Size size2 = new global::System.Drawing.Size(0x68, 0x20);
			this.simpleButton1.Size = size2;
			this.simpleButton1.TabIndex = 1;
			this.simpleButton1.Text = "Yes";
			this.simpleButton1.Click += new global::System.EventHandler(this.simpleButton1_Click);
			global::System.Drawing.Point location3 = new global::System.Drawing.Point(0x7A, 0x49);
			this.simpleButton2.Location = location3;
			this.simpleButton2.Name = "simpleButton2";
			global::System.Drawing.Size size3 = new global::System.Drawing.Size(0x68, 0x20);
			this.simpleButton2.Size = size3;
			this.simpleButton2.TabIndex = 2;
			this.simpleButton2.Text = "No";
			this.simpleButton2.Click += new global::System.EventHandler(this.simpleButton2_Click);
			global::System.Drawing.Point location4 = new global::System.Drawing.Point(0xE8, 0x49);
			this.simpleButton3.Location = location4;
			this.simpleButton3.Name = "simpleButton3";
			global::System.Drawing.Size size4 = new global::System.Drawing.Size(0x68, 0x20);
			this.simpleButton3.Size = size4;
			this.simpleButton3.TabIndex = 3;
			this.simpleButton3.Text = "Cancel";
			this.simpleButton3.Click += new global::System.EventHandler(this.simpleButton3_Click);
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleDimensions = autoScaleDimensions;
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			global::System.Drawing.Size clientSize = new global::System.Drawing.Size(0x15C, 0x75);
			base.ClientSize = clientSize;
			base.Controls.Add(this.simpleButton3);
			base.Controls.Add(this.simpleButton2);
			base.Controls.Add(this.simpleButton1);
			base.Controls.Add(this.labelControl1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
			base.LookAndFeel.UseDefaultLookAndFeel = false;
			base.Name = "AskToSaveDialog";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Save Current Project?";
			base.ResumeLayout(false);
			base.PerformLayout();
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

		private global::DevExpress.XtraEditors.LabelControl labelControl1;

		private global::DevExpress.XtraEditors.SimpleButton simpleButton1;

		private global::DevExpress.XtraEditors.SimpleButton simpleButton2;

		private global::DevExpress.XtraEditors.SimpleButton simpleButton3;
	}
}
