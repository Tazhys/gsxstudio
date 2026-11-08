namespace GSX_Studio
{
	public partial class NotifyDialog : global::DevExpress.XtraEditors.XtraForm
	{
		private void InitializeComponent()
		{
			this.Message = new global::System.Windows.Forms.RichTextBox();
			this.simpleButton1 = new global::DevExpress.XtraEditors.SimpleButton();
			base.SuspendLayout();
			global::System.Drawing.Color backColor = global::System.Drawing.Color.FromArgb(0x2D, 0x2D, 0x30);
			this.Message.BackColor = backColor;
			this.Message.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.Message.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Drawing.Color window = global::System.Drawing.SystemColors.Window;
			this.Message.ForeColor = window;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0xC, 0xC);
			this.Message.Location = location;
			this.Message.Name = "Message";
			this.Message.ReadOnly = true;
			global::System.Drawing.Size size = new global::System.Drawing.Size(0x162, 0x89);
			this.Message.Size = size;
			this.Message.TabIndex = 0;
			this.Message.Text = "";
			global::System.Drawing.Point location2 = new global::System.Drawing.Point(0x88, 0x9B);
			this.simpleButton1.Location = location2;
			this.simpleButton1.Name = "simpleButton1";
			global::System.Drawing.Size size2 = new global::System.Drawing.Size(0x6A, 0x22);
			this.simpleButton1.Size = size2;
			this.simpleButton1.TabIndex = 1;
			this.simpleButton1.Text = "OK";
			this.simpleButton1.Click += new global::System.EventHandler(this.simpleButton1_Click);
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleDimensions = autoScaleDimensions;
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			global::System.Drawing.Size clientSize = new global::System.Drawing.Size(0x17A, 0xC9);
			base.ClientSize = clientSize;
			base.Controls.Add(this.simpleButton1);
			base.Controls.Add(this.Message);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
			base.LookAndFeel.UseDefaultLookAndFeel = false;
			base.Name = "NotifyDialog";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Message";
			base.ResumeLayout(false);
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

		public global::System.Windows.Forms.RichTextBox Message;

		private global::DevExpress.XtraEditors.SimpleButton simpleButton1;
	}
}
