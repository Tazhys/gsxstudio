using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraWaitForm;

namespace GSX_Studio
{
	public partial class WaitForm1 : WaitForm
	{
		public void InitializeComponent()
		{
			this.progressPanel1 = new ProgressPanel();
			this.tableLayoutPanel1 = new TableLayoutPanel();
			this.tableLayoutPanel1.SuspendLayout();
			base.SuspendLayout();
			Color transparent = Color.Transparent;
			this.progressPanel1.Appearance.BackColor = transparent;
			this.progressPanel1.Appearance.Options.UseBackColor = true;
			this.progressPanel1.AppearanceCaption.Font = new Font("Microsoft Sans Serif", 12f);
			Color menu = SystemColors.Menu;
			this.progressPanel1.AppearanceCaption.ForeColor = menu;
			this.progressPanel1.AppearanceCaption.Options.UseFont = true;
			this.progressPanel1.AppearanceCaption.Options.UseForeColor = true;
			this.progressPanel1.AppearanceDescription.Font = new Font("Microsoft Sans Serif", 8.25f);
			Color menu2 = SystemColors.Menu;
			this.progressPanel1.AppearanceDescription.ForeColor = menu2;
			this.progressPanel1.AppearanceDescription.Options.UseFont = true;
			this.progressPanel1.AppearanceDescription.Options.UseForeColor = true;
			this.progressPanel1.BorderStyle = BorderStyles.NoBorder;
			this.progressPanel1.Dock = DockStyle.Fill;
			this.progressPanel1.ImageHorzOffset = 0x14;
			Point location = new Point(0, 0x11);
			this.progressPanel1.Location = location;
			this.progressPanel1.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
			this.progressPanel1.LookAndFeel.UseDefaultLookAndFeel = false;
			Padding margin = new Padding(0, 3, 0, 3);
			this.progressPanel1.Margin = margin;
			this.progressPanel1.Name = "progressPanel1";
			Size size = new Size(0xF6, 0x27);
			this.progressPanel1.Size = size;
			this.progressPanel1.TabIndex = 0;
			this.progressPanel1.Text = "progressPanel1";
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			Color transparent2 = Color.Transparent;
			this.tableLayoutPanel1.BackColor = transparent2;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel1.Controls.Add(this.progressPanel1, 0, 0);
			this.tableLayoutPanel1.Dock = DockStyle.Fill;
			Point location2 = new Point(0, 0);
			this.tableLayoutPanel1.Location = location2;
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			Padding padding = new Padding(0, 0xE, 0, 0xE);
			this.tableLayoutPanel1.Padding = padding;
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			Size size2 = new Size(0xF6, 0x49);
			this.tableLayoutPanel1.Size = size2;
			this.tableLayoutPanel1.TabIndex = 1;
			SizeF autoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleDimensions = autoScaleDimensions;
			base.AutoScaleMode = AutoScaleMode.Font;
			this.AutoSize = true;
			base.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			Size clientSize = new Size(0xF6, 0x49);
			base.ClientSize = clientSize;
			base.Controls.Add(this.tableLayoutPanel1);
			this.DoubleBuffered = true;
			base.Name = "WaitForm1";
			base.StartPosition = FormStartPosition.Manual;
			this.Text = "Form1";
			this.tableLayoutPanel1.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		public WaitForm1()
		{
			try
			{
				this.InitializeComponent();
				this.progressPanel1.AutoHeight = true;
			}
			catch
			{
				base.Dispose(true);
				throw;
			}
		}

		public override void SetCaption(string caption)
		{
			base.SetCaption(caption);
			this.progressPanel1.Caption = caption;
		}

		public override void SetDescription(string description)
		{
			base.SetDescription(description);
			this.progressPanel1.Description = description;
		}

		public void ProcessCommand(Enum __unnamed000, string arg)
		{
			base.ProcessCommand(__unnamed000, arg);
		}

		protected override UserLookAndFeel TargetLookAndFeel
		{
			get
			{
				if (this.mlookAndFeel == null)
				{
					UserLookAndFeel userLookAndFeel = new UserLookAndFeel(this);
					this.mlookAndFeel = userLookAndFeel;
					userLookAndFeel.UseDefaultLookAndFeel = false;
					this.mlookAndFeel.SkinName = "Visual Studio 2013 Dark";
				}
				return this.mlookAndFeel;
			}
		}

		private void CleanupManaged()
		{
			IContainer container = this.components;
			if (container != null)
			{
				container.Dispose();
			}
		}

		public UserLookAndFeel mlookAndFeel;

		private IContainer components = null;

		private ProgressPanel progressPanel1;

		private TableLayoutPanel tableLayoutPanel1;
	}
}
