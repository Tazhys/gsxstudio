namespace GSX_Studio
{
	public partial class EditProjectSettings : global::DevExpress.XtraEditors.XtraForm
	{
		private void InitializeComponent()
		{
			this.label1 = new global::System.Windows.Forms.Label();
			this.InlineMode = new global::DevExpress.XtraEditors.ComboBoxEdit();
			this.TypestrictMode = new global::DevExpress.XtraEditors.ComboBoxEdit();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.CreatorName = new global::DevExpress.XtraEditors.TextEdit();
			this.label4 = new global::System.Windows.Forms.Label();
			this.Watermark = new global::System.Windows.Forms.RichTextBox();
			this.simpleButton1 = new global::DevExpress.XtraEditors.SimpleButton();
			((global::System.ComponentModel.ISupportInitialize)this.InlineMode.Properties).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.TypestrictMode.Properties).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.CreatorName.Properties).BeginInit();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Drawing.Point location = new global::System.Drawing.Point(0xC, 0xF);
			this.label1.Location = location;
			this.label1.Name = "label1";
			global::System.Drawing.Size size = new global::System.Drawing.Size(0x4F, 0x10);
			this.label1.Size = size;
			this.label1.TabIndex = 0;
			this.label1.Text = "Inline Mode:";
			this.InlineMode.EditValue = "Inline when possible";
			global::System.Drawing.Point location2 = new global::System.Drawing.Point(0x9A, 0xE);
			this.InlineMode.Location = location2;
			this.InlineMode.Name = "InlineMode";
            global::DevExpress.XtraEditors.Controls.EditorButton[] buttons = new global::DevExpress.XtraEditors.Controls.EditorButton[]
            {
    new global::DevExpress.XtraEditors.Controls.EditorButton()
    {
        Kind = global::DevExpress.XtraEditors.Controls.ButtonPredefines.Combo
    }
            };
            this.InlineMode.Properties.Buttons.AddRange(buttons);

            object[] items = new object[]
			{
				"Inline never",
				"Inline when speficied",
				"Inline when possible"
			};
			this.InlineMode.Properties.Items.AddRange(items);
			this.InlineMode.Properties.TextEditStyle = global::DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			global::System.Drawing.Size size2 = new global::System.Drawing.Size(0xFD, 0x14);
			this.InlineMode.Size = size2;
			this.InlineMode.TabIndex = 1;
			this.TypestrictMode.EditValue = "Context mode";
			global::System.Drawing.Point location3 = new global::System.Drawing.Point(0x9A, 0x28);
			this.TypestrictMode.Location = location3;
			this.TypestrictMode.Name = "TypestrictMode";
            global::DevExpress.XtraEditors.Controls.EditorButton[] buttons2 = new global::DevExpress.XtraEditors.Controls.EditorButton[]
            {
    // Use parameterless constructor and assign the enum directly to the Kind property
    new global::DevExpress.XtraEditors.Controls.EditorButton()
    {
        Kind = global::DevExpress.XtraEditors.Controls.ButtonPredefines.Combo
    }
            };
            this.TypestrictMode.Properties.Buttons.AddRange(buttons2);

            object[] items2 = new object[]
			{
				"Never force types",
				"Context Mode",
				"All Returns",
				"All Declarations"
			};
			this.TypestrictMode.Properties.Items.AddRange(items2);
			this.TypestrictMode.Properties.TextEditStyle = global::DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			global::System.Drawing.Size size3 = new global::System.Drawing.Size(0xFD, 0x14);
			this.TypestrictMode.Size = size3;
			this.TypestrictMode.TabIndex = 3;
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Drawing.Point location4 = new global::System.Drawing.Point(0xC, 0x29);
			this.label2.Location = location4;
			this.label2.Name = "label2";
			global::System.Drawing.Size size4 = new global::System.Drawing.Size(0x68, 0x10);
			this.label2.Size = size4;
			this.label2.TabIndex = 2;
			this.label2.Text = "Typestrict Mode:";
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Drawing.Point location5 = new global::System.Drawing.Point(0xC, 0x43);
			this.label3.Location = location5;
			this.label3.Name = "label3";
			global::System.Drawing.Size size5 = new global::System.Drawing.Size(0x5D, 0x10);
			this.label3.Size = size5;
			this.label3.TabIndex = 4;
			this.label3.Text = "Creator Name:";
			global::System.Drawing.Point location6 = new global::System.Drawing.Point(0x9A, 0x42);
			this.CreatorName.Location = location6;
			this.CreatorName.Name = "CreatorName";
			global::System.Drawing.Size size6 = new global::System.Drawing.Size(0xFD, 0x14);
			this.CreatorName.Size = size6;
			this.CreatorName.TabIndex = 5;
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Drawing.Point location7 = new global::System.Drawing.Point(0xC, 0x5D);
			this.label4.Location = location7;
			this.label4.Name = "label4";
			global::System.Drawing.Size size7 = new global::System.Drawing.Size(0x4D, 0x10);
			this.label4.Size = size7;
			this.label4.TabIndex = 6;
			this.label4.Text = "Watermark:";
			global::System.Drawing.Color backColor = global::System.Drawing.Color.FromArgb(0x1E, 0x1E, 0x1E);
			this.Watermark.BackColor = backColor;
			this.Watermark.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			global::System.Drawing.Color gainsboro = global::System.Drawing.Color.Gainsboro;
			this.Watermark.ForeColor = gainsboro;
			global::System.Drawing.Point location8 = new global::System.Drawing.Point(0x9A, 0x5C);
			this.Watermark.Location = location8;
			global::System.Windows.Forms.Padding margin = new global::System.Windows.Forms.Padding(9, 9, 3, 3);
			this.Watermark.Margin = margin;
			this.Watermark.Name = "Watermark";
			global::System.Drawing.Size size8 = new global::System.Drawing.Size(0xFD, 0x62);
			this.Watermark.Size = size8;
			this.Watermark.TabIndex = 7;
			this.Watermark.Text = "%projectname% by %creatorname%";
			global::System.Drawing.Point location9 = new global::System.Drawing.Point(0x9A, 0xC5);
			this.simpleButton1.Location = location9;
			this.simpleButton1.Name = "simpleButton1";
			global::System.Drawing.Size size9 = new global::System.Drawing.Size(0xFD, 0x1C);
			this.simpleButton1.Size = size9;
			this.simpleButton1.TabIndex = 8;
			this.simpleButton1.Text = "Save Settings";
			this.simpleButton1.Click += new global::System.EventHandler(this.simpleButton1_Click);
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleDimensions = autoScaleDimensions;
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			global::System.Drawing.Size clientSize = new global::System.Drawing.Size(0x1A3, 0xED);
			base.ClientSize = clientSize;
			base.Controls.Add(this.simpleButton1);
			base.Controls.Add(this.Watermark);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.CreatorName);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.TypestrictMode);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.InlineMode);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
			base.LookAndFeel.UseDefaultLookAndFeel = false;
			base.Name = "EditProjectSettings";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Project Settings";
			((global::System.ComponentModel.ISupportInitialize)this.InlineMode.Properties).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.TypestrictMode.Properties).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.CreatorName.Properties).EndInit();
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

		private global::DevExpress.XtraEditors.ComboBoxEdit InlineMode;

		private global::DevExpress.XtraEditors.ComboBoxEdit TypestrictMode;

		private global::System.Windows.Forms.Label label2;

		private global::System.Windows.Forms.Label label3;

		private global::DevExpress.XtraEditors.TextEdit CreatorName;

		private global::System.Windows.Forms.Label label4;

		private global::System.Windows.Forms.RichTextBox Watermark;

		private global::DevExpress.XtraEditors.SimpleButton simpleButton1;
	}
}
