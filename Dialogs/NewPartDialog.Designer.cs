namespace GSX_Studio
{
	public partial class NewPartDialog : global::DevExpress.XtraEditors.XtraForm
	{
		private void InitializeComponent()
		{
			this.label1 = new global::System.Windows.Forms.Label();
			this.FileName = new global::DevExpress.XtraEditors.TextEdit();
			this.Description = new global::DevExpress.XtraEditors.TextEdit();
			this.label2 = new global::System.Windows.Forms.Label();
			this.simpleButton1 = new global::DevExpress.XtraEditors.SimpleButton();
			this.DefaultCode = new global::DevExpress.XtraEditors.CheckEdit();
			((global::System.ComponentModel.ISupportInitialize)this.FileName.Properties).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.Description.Properties).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.DefaultCode.Properties).BeginInit();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0xC, 0xF);
			this.label1.Location = location;
			this.label1.Name = "label1";
			global::System.Drawing.Size size = new global::System.Drawing.Size(0x39, 0xD);
			this.label1.Size = size;
			this.label1.TabIndex = 0;
			this.label1.Text = "File Name:";
			this.label1.Click += new global::System.EventHandler(this.label1_Click);
			global::System.Drawing.Point location2 = new global::System.Drawing.Point(0x66, 0xC);
			this.FileName.Location = location2;
			this.FileName.Name = "FileName";
			global::System.Drawing.Size size2 = new global::System.Drawing.Size(0x111, 0x14);
			this.FileName.Size = size2;
			this.FileName.TabIndex = 1;
			this.FileName.EditValueChanged += new global::System.EventHandler(this.textEdit1_EditValueChanged);
			global::System.Drawing.Point location3 = new global::System.Drawing.Point(0x66, 0x26);
			this.Description.Location = location3;
			this.Description.Name = "Description";
			global::System.Drawing.Size size3 = new global::System.Drawing.Size(0x111, 0x14);
			this.Description.Size = size3;
			this.Description.TabIndex = 3;
			this.label2.AutoSize = true;
			global::System.Drawing.Point location4 = new global::System.Drawing.Point(0xC, 0x29);
			this.label2.Location = location4;
			this.label2.Name = "label2";
			global::System.Drawing.Size size4 = new global::System.Drawing.Size(0x40, 0xD);
			this.label2.Size = size4;
			this.label2.TabIndex = 2;
			this.label2.Text = "Description:";
			global::System.Drawing.Point location5 = new global::System.Drawing.Point(0x66, 0x40);
			this.simpleButton1.Location = location5;
			this.simpleButton1.Name = "simpleButton1";
			global::System.Drawing.Size size5 = new global::System.Drawing.Size(0x71, 0x24);
			this.simpleButton1.Size = size5;
			this.simpleButton1.TabIndex = 4;
			this.simpleButton1.Text = "Create";
			this.simpleButton1.Click += new global::System.EventHandler(this.simpleButton1_Click);
			this.DefaultCode.EditValue = true;
			global::System.Drawing.Point location6 = new global::System.Drawing.Point(0xEC, 0x48);
			this.DefaultCode.Location = location6;
			this.DefaultCode.Name = "DefaultCode";
			this.DefaultCode.Properties.Caption = "Include Default Code";
			this.DefaultCode.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			global::System.Drawing.Size size6 = new global::System.Drawing.Size(0x81, 0x13);
			this.DefaultCode.Size = size6;
			this.DefaultCode.TabIndex = 5;
			this.DefaultCode.CheckedChanged += new global::System.EventHandler(this.checkEdit1_CheckedChanged);
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleDimensions = autoScaleDimensions;
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			global::System.Drawing.Size clientSize = new global::System.Drawing.Size(0x183, 0x70);
			base.ClientSize = clientSize;
			base.Controls.Add(this.DefaultCode);
			base.Controls.Add(this.simpleButton1);
			base.Controls.Add(this.Description);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.FileName);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
			base.LookAndFeel.UseDefaultLookAndFeel = false;
			base.Name = "NewPartDialog";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "New Script File";
			base.Load += new global::System.EventHandler(this.NewPartDialog_Load);
			((global::System.ComponentModel.ISupportInitialize)this.FileName.Properties).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.Description.Properties).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.DefaultCode.Properties).EndInit();
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

		private global::System.Windows.Forms.Label label1;

		public global::DevExpress.XtraEditors.TextEdit FileName;

		public global::DevExpress.XtraEditors.TextEdit Description;

		private global::System.Windows.Forms.Label label2;

		private global::DevExpress.XtraEditors.SimpleButton simpleButton1;

		public global::DevExpress.XtraEditors.CheckEdit DefaultCode;
	}
}
