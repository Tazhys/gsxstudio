namespace GSX_Studio
{
	public partial class XPlatformMemory : global::DevExpress.XtraEditors.XtraForm
	{
		private void InitializeComponent()
		{
			this.groupControl1 = new global::DevExpress.XtraEditors.GroupControl();
			this.groupControl2 = new global::DevExpress.XtraEditors.GroupControl();
			this.SetTarget = new global::DevExpress.XtraEditors.TextEdit();
			this.labelControl1 = new global::DevExpress.XtraEditors.LabelControl();
			this.textEdit2 = new global::DevExpress.XtraEditors.TextEdit();
			this.labelControl2 = new global::DevExpress.XtraEditors.LabelControl();
			this.SetTargetValue = new global::DevExpress.XtraEditors.TextEdit();
			this.SetType = new global::DevExpress.XtraEditors.ComboBoxEdit();
			this.labelControl3 = new global::DevExpress.XtraEditors.LabelControl();
			this.labelControl4 = new global::DevExpress.XtraEditors.LabelControl();
			this.simpleButton1 = new global::DevExpress.XtraEditors.SimpleButton();
			((global::System.ComponentModel.ISupportInitialize)this.groupControl1).BeginInit();
			this.groupControl1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.groupControl2).BeginInit();
			this.groupControl2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.SetTarget.Properties).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.textEdit2.Properties).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.SetTargetValue.Properties).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.SetType.Properties).BeginInit();
			base.SuspendLayout();
			this.groupControl1.Controls.Add(this.textEdit2);
			this.groupControl1.Controls.Add(this.labelControl2);
			global::System.Drawing.Point location = new global::System.Drawing.Point(0xC, 0xC);
			this.groupControl1.Location = location;
			this.groupControl1.Name = "groupControl1";
			global::System.Drawing.Size size = new global::System.Drawing.Size(0x230, 0xDE);
			this.groupControl1.Size = size;
			this.groupControl1.TabIndex = 1;
			this.groupControl1.Text = "Get";
			this.groupControl2.Controls.Add(this.simpleButton1);
			this.groupControl2.Controls.Add(this.labelControl4);
			this.groupControl2.Controls.Add(this.labelControl3);
			this.groupControl2.Controls.Add(this.SetType);
			this.groupControl2.Controls.Add(this.SetTargetValue);
			this.groupControl2.Controls.Add(this.SetTarget);
			this.groupControl2.Controls.Add(this.labelControl1);
			global::System.Drawing.Point location2 = new global::System.Drawing.Point(0xC, 0xF0);
			this.groupControl2.Location = location2;
			this.groupControl2.Name = "groupControl2";
			global::System.Drawing.Size size2 = new global::System.Drawing.Size(0x230, 0x6D);
			this.groupControl2.Size = size2;
			this.groupControl2.TabIndex = 2;
			this.groupControl2.Text = "Set";
			global::System.Drawing.Point location3 = new global::System.Drawing.Point(0x9F, 0x15);
			this.SetTarget.Location = location3;
			this.SetTarget.Name = "SetTarget";
			this.SetTarget.Properties.AllowNullInput = global::DevExpress.Utils.DefaultBoolean.False;
			this.SetTarget.Properties.Appearance.Font = new global::System.Drawing.Font("Consolas", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.SetTarget.Properties.Appearance.Options.UseFont = true;
			this.SetTarget.Properties.Appearance.Options.UseTextOptions = true;
			this.SetTarget.Properties.Appearance.TextOptions.HAlignment = global::DevExpress.Utils.HorzAlignment.Center;
			this.SetTarget.Properties.Appearance.TextOptions.VAlignment = global::DevExpress.Utils.VertAlignment.Center;
			this.SetTarget.Properties.DisplayFormat.FormatString = "0x[0-9A-F]{8}";
			this.SetTarget.Properties.DisplayFormat.FormatType = global::DevExpress.Utils.FormatType.Custom;
			this.SetTarget.Properties.EditFormat.FormatString = "0x[0-9A-F]{8}";
			this.SetTarget.Properties.EditFormat.FormatType = global::DevExpress.Utils.FormatType.Custom;
			this.SetTarget.Properties.Mask.BeepOnError = true;
			this.SetTarget.Properties.Mask.EditMask = "0x[0-9A-Fa-f]{8}";
			this.SetTarget.Properties.Mask.MaskType = global::DevExpress.XtraEditors.Mask.MaskType.RegEx;
			this.SetTarget.Properties.MaxLength = 0xA;
			this.SetTarget.Properties.NullText = "0x00000000";
			this.SetTarget.Properties.ValidateOnEnterKey = true;
			global::System.Drawing.Size size3 = new global::System.Drawing.Size(0x98, 0x16);
			this.SetTarget.Size = size3;
			this.SetTarget.TabIndex = 1;
			this.labelControl1.Appearance.Font = new global::System.Drawing.Font("Consolas", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Drawing.Point location4 = new global::System.Drawing.Point(0x10, 0x18);
			this.labelControl1.Location = location4;
			this.labelControl1.Name = "labelControl1";
			global::System.Drawing.Size size4 = new global::System.Drawing.Size(0x62, 0xF);
			this.labelControl1.Size = size4;
			this.labelControl1.TabIndex = 0;
			this.labelControl1.Text = "Target Address";
			global::System.Drawing.Point location5 = new global::System.Drawing.Point(0x12, 0x2D);
			this.textEdit2.Location = location5;
			this.textEdit2.Name = "textEdit2";
			this.textEdit2.Properties.AllowNullInput = global::DevExpress.Utils.DefaultBoolean.False;
			this.textEdit2.Properties.Appearance.Font = new global::System.Drawing.Font("Consolas", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.textEdit2.Properties.Appearance.Options.UseFont = true;
			this.textEdit2.Properties.Appearance.Options.UseTextOptions = true;
			this.textEdit2.Properties.Appearance.TextOptions.HAlignment = global::DevExpress.Utils.HorzAlignment.Center;
			this.textEdit2.Properties.Appearance.TextOptions.VAlignment = global::DevExpress.Utils.VertAlignment.Center;
			this.textEdit2.Properties.DisplayFormat.FormatString = "0x[0-9A-F]{8}";
			this.textEdit2.Properties.DisplayFormat.FormatType = global::DevExpress.Utils.FormatType.Custom;
			this.textEdit2.Properties.EditFormat.FormatString = "0x[0-9A-F]{8}";
			this.textEdit2.Properties.EditFormat.FormatType = global::DevExpress.Utils.FormatType.Custom;
			this.textEdit2.Properties.Mask.BeepOnError = true;
			this.textEdit2.Properties.Mask.EditMask = "0x[0-9A-Fa-f]{8}";
			this.textEdit2.Properties.Mask.MaskType = global::DevExpress.XtraEditors.Mask.MaskType.RegEx;
			this.textEdit2.Properties.MaxLength = 0xA;
			this.textEdit2.Properties.NullText = "0x00000000";
			this.textEdit2.Properties.ValidateOnEnterKey = true;
			global::System.Drawing.Size size5 = new global::System.Drawing.Size(0x64, 0x16);
			this.textEdit2.Size = size5;
			this.textEdit2.TabIndex = 3;
			this.labelControl2.Appearance.Font = new global::System.Drawing.Font("Consolas", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Drawing.Point location6 = new global::System.Drawing.Point(0x14, 0x18);
			this.labelControl2.Location = location6;
			this.labelControl2.Name = "labelControl2";
			global::System.Drawing.Size size6 = new global::System.Drawing.Size(0x62, 0xF);
			this.labelControl2.Size = size6;
			this.labelControl2.TabIndex = 2;
			this.labelControl2.Text = "Target Address";
			this.SetTargetValue.EditValue = "0x0000000000000000";
			global::System.Drawing.Point location7 = new global::System.Drawing.Point(0x9F, 0x31);
			this.SetTargetValue.Location = location7;
			this.SetTargetValue.Name = "SetTargetValue";
			this.SetTargetValue.Properties.AllowNullInput = global::DevExpress.Utils.DefaultBoolean.False;
			this.SetTargetValue.Properties.Appearance.Font = new global::System.Drawing.Font("Consolas", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.SetTargetValue.Properties.Appearance.Options.UseFont = true;
			this.SetTargetValue.Properties.Appearance.Options.UseTextOptions = true;
			this.SetTargetValue.Properties.Appearance.TextOptions.HAlignment = global::DevExpress.Utils.HorzAlignment.Center;
			this.SetTargetValue.Properties.Appearance.TextOptions.VAlignment = global::DevExpress.Utils.VertAlignment.Center;
			this.SetTargetValue.Properties.DisplayFormat.FormatString = "0x[0-9A-F]{8}";
			this.SetTargetValue.Properties.DisplayFormat.FormatType = global::DevExpress.Utils.FormatType.Custom;
			this.SetTargetValue.Properties.EditFormat.FormatString = "0x[0-9A-F]{8}";
			this.SetTargetValue.Properties.EditFormat.FormatType = global::DevExpress.Utils.FormatType.Custom;
			this.SetTargetValue.Properties.Mask.BeepOnError = true;
			this.SetTargetValue.Properties.Mask.EditMask = "0x[0-9A-Fa-f]{8}";
			this.SetTargetValue.Properties.Mask.MaskType = global::DevExpress.XtraEditors.Mask.MaskType.RegEx;
			this.SetTargetValue.Properties.MaxLength = 0xA;
			this.SetTargetValue.Properties.NullText = "0x00000000";
			this.SetTargetValue.Properties.ValidateOnEnterKey = true;
			global::System.Drawing.Size size7 = new global::System.Drawing.Size(0x98, 0x16);
			this.SetTargetValue.Size = size7;
			this.SetTargetValue.TabIndex = 2;
			this.SetType.EditValue = "DWORD";
			global::System.Drawing.Point location8 = new global::System.Drawing.Point(0x9F, 0x4D);
			this.SetType.Location = location8;
			this.SetType.Name = "SetType";
			this.SetType.Properties.Appearance.Font = new global::System.Drawing.Font("Consolas", 9.75f);
			this.SetType.Properties.Appearance.Options.UseFont = true;
			this.SetType.Properties.Appearance.Options.UseTextOptions = true;
			this.SetType.Properties.Appearance.TextOptions.HAlignment = global::DevExpress.Utils.HorzAlignment.Center;
			this.SetType.Properties.Appearance.TextOptions.VAlignment = global::DevExpress.Utils.VertAlignment.Center;
			global::DevExpress.XtraEditors.Controls.EditorButton[] buttons = new global::DevExpress.XtraEditors.Controls.EditorButton[]
			{
				new global::DevExpress.XtraEditors.Controls.EditorButton() { Kind = global::DevExpress.XtraEditors.Controls.ButtonPredefines.Combo }
			};
			this.SetType.Properties.Buttons.AddRange(buttons);
			object[] items = new object[]
			{
				"BYTE",
				"WORD",
				"DWORD",
				"QWORD",
				"LOAD"
			};
			this.SetType.Properties.Items.AddRange(items);
			this.SetType.Properties.TextEditStyle = global::DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			global::System.Drawing.Size size8 = new global::System.Drawing.Size(0x98, 0x16);
			this.SetType.Size = size8;
			this.SetType.TabIndex = 3;
			this.SetType.SelectedIndexChanged += new global::System.EventHandler(this.comboBoxEdit1_SelectedIndexChanged);
			this.labelControl3.Appearance.Font = new global::System.Drawing.Font("Consolas", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Drawing.Point location9 = new global::System.Drawing.Point(0x10, 0x34);
			this.labelControl3.Location = location9;
			this.labelControl3.Name = "labelControl3";
			global::System.Drawing.Size size9 = new global::System.Drawing.Size(0x54, 0xF);
			this.labelControl3.Size = size9;
			this.labelControl3.TabIndex = 4;
			this.labelControl3.Text = "Target Value";
			this.labelControl4.Appearance.Font = new global::System.Drawing.Font("Consolas", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Drawing.Point location10 = new global::System.Drawing.Point(0x10, 0x50);
			this.labelControl4.Location = location10;
			this.labelControl4.Name = "labelControl4";
			global::System.Drawing.Size size10 = new global::System.Drawing.Size(0x4D, 0xF);
			this.labelControl4.Size = size10;
			this.labelControl4.TabIndex = 5;
			this.labelControl4.Text = "Target Type";
			global::System.Drawing.Point location11 = new global::System.Drawing.Point(0x1E0, 0x4C);
			this.simpleButton1.Location = location11;
			this.simpleButton1.Name = "simpleButton1";
			global::System.Drawing.Size size11 = new global::System.Drawing.Size(0x4B, 0x17);
			this.simpleButton1.Size = size11;
			this.simpleButton1.TabIndex = 6;
			this.simpleButton1.Text = "simpleButton1";
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleDimensions = autoScaleDimensions;
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			global::System.Drawing.Size clientSize = new global::System.Drawing.Size(0x248, 0x169);
			base.ClientSize = clientSize;
			base.Controls.Add(this.groupControl2);
			base.Controls.Add(this.groupControl1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
			base.LookAndFeel.UseDefaultLookAndFeel = false;
			base.Name = "XPlatformMemory";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Memory Editing";
			((global::System.ComponentModel.ISupportInitialize)this.groupControl1).EndInit();
			this.groupControl1.ResumeLayout(false);
			this.groupControl1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.groupControl2).EndInit();
			this.groupControl2.ResumeLayout(false);
			this.groupControl2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.SetTarget.Properties).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.textEdit2.Properties).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.SetTargetValue.Properties).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.SetType.Properties).EndInit();
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

		private global::DevExpress.XtraEditors.GroupControl groupControl1;

		private global::DevExpress.XtraEditors.GroupControl groupControl2;

		private global::DevExpress.XtraEditors.TextEdit SetTarget;

		private global::DevExpress.XtraEditors.LabelControl labelControl1;

		private global::DevExpress.XtraEditors.TextEdit textEdit2;

		private global::DevExpress.XtraEditors.LabelControl labelControl2;

		private global::DevExpress.XtraEditors.ComboBoxEdit SetType;

		private global::DevExpress.XtraEditors.TextEdit SetTargetValue;

		private global::DevExpress.XtraEditors.LabelControl labelControl3;

		private global::DevExpress.XtraEditors.LabelControl labelControl4;

		private global::DevExpress.XtraEditors.SimpleButton simpleButton1;
	}
}
