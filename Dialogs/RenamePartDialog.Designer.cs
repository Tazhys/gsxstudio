namespace GSX_Studio
{
	public partial class RenamePartDialog : global::DevExpress.XtraEditors.XtraForm
	{
		private void InitializeComponent()
		{
			this.labelControl1 = new global::DevExpress.XtraEditors.LabelControl();
			this.CValue = new global::DevExpress.XtraEditors.TextEdit();
			this.simpleButton1 = new global::DevExpress.XtraEditors.SimpleButton();
			this.simpleButton2 = new global::DevExpress.XtraEditors.SimpleButton();
			((global::System.ComponentModel.ISupportInitialize)this.CValue.Properties).BeginInit();
			base.SuspendLayout();
			this.labelControl1.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Drawing.Point location = new global::System.Drawing.Point(0xC, 0xC);
			this.labelControl1.Location = location;
			this.labelControl1.Name = "labelControl1";
			global::System.Drawing.Size size = new global::System.Drawing.Size(0x3E, 0x10);
			this.labelControl1.Size = size;
			this.labelControl1.TabIndex = 0;
			this.labelControl1.Text = "File Name:";
			this.CValue.EditValue = "main.gsx";
			global::System.Drawing.Point location2 = new global::System.Drawing.Point(0x77, 0xC);
			this.CValue.Location = location2;
			this.CValue.Name = "CValue";
			this.CValue.Properties.Mask.EditMask = "[^\\.]+\\.gsx";
			this.CValue.Properties.Mask.MaskType = global::DevExpress.XtraEditors.Mask.MaskType.RegEx;
			this.CValue.Properties.Mask.ShowPlaceHolders = false;
			global::System.Drawing.Size size2 = new global::System.Drawing.Size(0xD6, 0x14);
			this.CValue.Size = size2;
			this.CValue.TabIndex = 1;
			global::System.Drawing.Point location3 = new global::System.Drawing.Point(0x77, 0x26);
			this.simpleButton1.Location = location3;
			this.simpleButton1.Name = "simpleButton1";
			global::System.Drawing.Size size3 = new global::System.Drawing.Size(0x68, 0x1D);
			this.simpleButton1.Size = size3;
			this.simpleButton1.TabIndex = 2;
			this.simpleButton1.Text = "OK";
			this.simpleButton1.Click += new global::System.EventHandler(this.simpleButton1_Click);
			global::System.Drawing.Point location4 = new global::System.Drawing.Point(0xE5, 0x26);
			this.simpleButton2.Location = location4;
			this.simpleButton2.Name = "simpleButton2";
			global::System.Drawing.Size size4 = new global::System.Drawing.Size(0x68, 0x1D);
			this.simpleButton2.Size = size4;
			this.simpleButton2.TabIndex = 3;
			this.simpleButton2.Text = "Cancel";
			this.simpleButton2.Click += new global::System.EventHandler(this.simpleButton2_Click);
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleDimensions = autoScaleDimensions;
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			global::System.Drawing.Size clientSize = new global::System.Drawing.Size(0x160, 0x53);
			base.ClientSize = clientSize;
			base.Controls.Add(this.simpleButton2);
			base.Controls.Add(this.simpleButton1);
			base.Controls.Add(this.CValue);
			base.Controls.Add(this.labelControl1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
			base.LookAndFeel.UseDefaultLookAndFeel = false;
			base.Name = "RenamePartDialog";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Rename File";
			((global::System.ComponentModel.ISupportInitialize)this.CValue.Properties).EndInit();
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

		public global::DevExpress.XtraEditors.TextEdit CValue;

		private global::DevExpress.XtraEditors.SimpleButton simpleButton1;

		private global::DevExpress.XtraEditors.SimpleButton simpleButton2;
	}
}
