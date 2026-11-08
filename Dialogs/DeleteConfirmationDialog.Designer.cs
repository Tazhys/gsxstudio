namespace GSX_Studio
{
	public partial class DeleteConfirmationDialog : global::DevExpress.XtraEditors.XtraForm
	{
		private void InitializeComponent()
		{
			this.Message = new global::DevExpress.XtraEditors.LabelControl();
			this.DeleteFile = new global::DevExpress.XtraEditors.CheckEdit();
			this.simpleButton1 = new global::DevExpress.XtraEditors.SimpleButton();
			this.simpleButton2 = new global::DevExpress.XtraEditors.SimpleButton();
			this.simpleButton3 = new global::DevExpress.XtraEditors.SimpleButton();
			((global::System.ComponentModel.ISupportInitialize)this.DeleteFile.Properties).BeginInit();
			base.SuspendLayout();
			this.Message.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Drawing.Point location = new global::System.Drawing.Point(0xC, 0xC);
			this.Message.Location = location;
			this.Message.Name = "Message";
			global::System.Drawing.Size size = new global::System.Drawing.Size(0x153, 0x10);
			this.Message.Size = size;
			this.Message.TabIndex = 0;
			this.Message.Text = "Are you sure you want to remove this file from the project?";
			this.DeleteFile.EditValue = true;
			global::System.Drawing.Point location2 = new global::System.Drawing.Point(0x114, 0x5B);
			this.DeleteFile.Location = location2;
			this.DeleteFile.Name = "DeleteFile";
			this.DeleteFile.Properties.Caption = "Delete File";
			global::System.Drawing.Size size2 = new global::System.Drawing.Size(0x4B, 0x13);
			this.DeleteFile.Size = size2;
			this.DeleteFile.TabIndex = 1;
			global::System.Drawing.Point location3 = new global::System.Drawing.Point(0x1A, 0x31);
			this.simpleButton1.Location = location3;
			this.simpleButton1.Name = "simpleButton1";
			global::System.Drawing.Size size3 = new global::System.Drawing.Size(0x62, 0x24);
			this.simpleButton1.Size = size3;
			this.simpleButton1.TabIndex = 2;
			this.simpleButton1.Text = "Yes";
			this.simpleButton1.Click += new global::System.EventHandler(this.simpleButton1_Click);
			global::System.Drawing.Point location4 = new global::System.Drawing.Point(0x82, 0x31);
			this.simpleButton2.Location = location4;
			this.simpleButton2.Name = "simpleButton2";
			global::System.Drawing.Size size4 = new global::System.Drawing.Size(0x62, 0x24);
			this.simpleButton2.Size = size4;
			this.simpleButton2.TabIndex = 3;
			this.simpleButton2.Text = "No";
			this.simpleButton2.Click += new global::System.EventHandler(this.simpleButton2_Click);
			global::System.Drawing.Point location5 = new global::System.Drawing.Point(0xEA, 0x31);
			this.simpleButton3.Location = location5;
			this.simpleButton3.Name = "simpleButton3";
			global::System.Drawing.Size size5 = new global::System.Drawing.Size(0x62, 0x24);
			this.simpleButton3.Size = size5;
			this.simpleButton3.TabIndex = 4;
			this.simpleButton3.Text = "Cancel";
			this.simpleButton3.Click += new global::System.EventHandler(this.simpleButton3_Click);
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleDimensions = autoScaleDimensions;
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			global::System.Drawing.Size clientSize = new global::System.Drawing.Size(0x16D, 0x78);
			base.ClientSize = clientSize;
			base.Controls.Add(this.simpleButton3);
			base.Controls.Add(this.simpleButton2);
			base.Controls.Add(this.simpleButton1);
			base.Controls.Add(this.DeleteFile);
			base.Controls.Add(this.Message);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
			base.LookAndFeel.UseDefaultLookAndFeel = false;
			base.Name = "DeleteConfirmationDialog";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Confirm";
			base.Load += new global::System.EventHandler(this.DeleteConfirmationDialog_Load);
			((global::System.ComponentModel.ISupportInitialize)this.DeleteFile.Properties).EndInit();
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

		public global::DevExpress.XtraEditors.LabelControl Message;

		public global::DevExpress.XtraEditors.CheckEdit DeleteFile;

		private global::DevExpress.XtraEditors.SimpleButton simpleButton1;

		private global::DevExpress.XtraEditors.SimpleButton simpleButton2;

		private global::DevExpress.XtraEditors.SimpleButton simpleButton3;
	}
}
