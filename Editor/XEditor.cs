using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using FastColoredTextBoxNS;

namespace GSX_Studio
{
	public class XEditor : XtraUserControl
	{
		public void AdjustScrollbars()
		{
			Size clientSize = this.Editor.ClientSize;
			this.AdjustVScrollbar(this.VScroller, this.Editor.VerticalScroll.Maximum, this.Editor.VerticalScroll.Value, clientSize.Height);
			Size clientSize2 = this.Editor.ClientSize;
			this.AdjustHScrollbar(this.HScroller, this.Editor.HorizontalScroll.Maximum, this.Editor.HorizontalScroll.Value, clientSize2.Width);
		}

		public void AdjustHScrollbar(DevExpress.XtraEditors.HScrollBar scrollBar, int max, int value, int clientSize)
		{
			scrollBar.LargeChange = clientSize / 3;
			scrollBar.SmallChange = clientSize / 0xB;
			scrollBar.Maximum = scrollBar.LargeChange + max;
			scrollBar.Visible = max > 0;
			scrollBar.Value = Math.Min(scrollBar.Maximum, value);
		}

		public void AdjustVScrollbar(DevExpress.XtraEditors.VScrollBar scrollBar, int max, int value, int clientSize)
		{
			scrollBar.LargeChange = clientSize / 3;
			scrollBar.SmallChange = clientSize / 0xB;
			scrollBar.Maximum = scrollBar.LargeChange + max;
			scrollBar.Visible = max > 0;
			scrollBar.Value = Math.Min(scrollBar.Maximum, value);
		}

		public void fctb_ScrollbarsUpdated(object sender, EventArgs e)
		{
			this.AdjustScrollbars();
		}

		public void VScrollBar_Scroll(object sender, ScrollEventArgs e)
		{
			byte alignByLines;
			if (e.Type != ScrollEventType.ThumbTrack && e.Type != ScrollEventType.ThumbPosition)
			{
				alignByLines = 1;
			}
			else
			{
				alignByLines = 0;
			}
			this.Editor.OnScroll(e, alignByLines != 0, 2);
		}

		public void HScrollBar_Scroll(object sender, ScrollEventArgs e)
		{
			byte alignByLines;
			if (e.Type != ScrollEventType.ThumbTrack && e.Type != ScrollEventType.ThumbPosition)
			{
				alignByLines = 1;
			}
			else
			{
				alignByLines = 0;
			}
			this.Editor.OnScroll(e, alignByLines != 0, 1);
		}

		public XEditor(ImageList images, List<AutocompleteItem> items)
		{
			try
			{
				this.InitializeComponent();
				this.Editor.ScrollbarsUpdated += this.fctb_ScrollbarsUpdated;
				Color selectionColor = Color.FromArgb(0x33, 0x99, 0xFF);
				this.Editor.SelectionColor = selectionColor;
				this.VScroller.Scroll += this.VScrollBar_Scroll;
				this.HScroller.Scroll += this.HScrollBar_Scroll;
				this.documentMap1.MouseEnter += this.OnDMMouseEnter;
				this.documentMap1.MouseLeave += this.OnDMMouseLeave;
				Color color = Color.FromArgb(0x64, 0x33, 0x99, 0xFF);
				this.Editor.BracketsStyle.BackgroundBrush = new SolidBrush(color);
				Color color2 = Color.FromArgb(0x64, 0x33, 0x99, 0xFF);
				this.Editor.BracketsStyle2.BackgroundBrush = new SolidBrush(color2);
				this.ACM = new AutocompleteMenu(this.Editor);
				this.Editor.Click += this.OnEClick;
				Color foreColor = Color.FromArgb(0xDC, 0xDC, 0xDC);
				this.ACM.ForeColor = foreColor;
				this.ACM.AllowTabKey = true;
				Color backColor = Color.FromArgb(0x25, 0x25, 0x25);
				this.ACM.BackColor = backColor;
				Color selectedColor = Color.FromArgb(0x3C, 0x95, 0xFD);
				this.ACM.SelectedColor = selectedColor;
				this.ACM.Font = new Font("Tahoma", 10f);
				Color hoveredColor = Color.FromArgb(0x25, 0x25, 0x25);
				this.ACM.HoveredColor = hoveredColor;
				this.ACM.ToolTipDuration = int.MaxValue;
				this.ACM.ImageList = images;
				this.ACM.ToolTip.OwnerDraw = true;
				this.ACM.ToolTip.Draw += this.OnTTDraw;
				Color backColor2 = Color.FromArgb(0x42, 0x41, 0x46);
				this.ACM.ToolTip.BackColor = backColor2;
				Color foreColor2 = Color.FromArgb(0xDC, 0xDC, 0xDC);
				this.ACM.ToolTip.ForeColor = foreColor2;
				this.ACM.AppearInterval = 0x64;
				this.ACM.SearchPattern = "[\\w\\.\\\\:]";
				this.ACM.Items.SetAutocompleteItems(items);
				this.ACM.MinFragmentLength = 1;
			}
			catch
			{
				base.Dispose(true);
				throw;
			}
		}

		public void SetAutoCompleteItems(List<AutocompleteItem> items)
		{
			this.ACM.Items.SetAutocompleteItems(items);
		}

		private void CleanupManaged()
		{
			IContainer container = this.components;
			if (container != null)
			{
				container.Dispose();
			}
		}

		private void InitializeComponent()
		{
			this.components = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(XEditor));
			this.VScroller = new DevExpress.XtraEditors.VScrollBar();
			this.HScroller = new DevExpress.XtraEditors.HScrollBar();
			this.CornerBlock = new XtraUserControl();
			this.Editor = new FastColoredTextBox();
			this.documentMap1 = new DocumentMap();
			((ISupportInitialize)this.Editor).BeginInit();
			base.SuspendLayout();
			this.VScroller.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right);
			Point location = new Point(0x2F6, 0);
			this.VScroller.Location = location;
			this.VScroller.Name = "VScroller";
			Size size = new Size(0x11, 0x247);
			this.VScroller.Size = size;
			this.VScroller.TabIndex = 1;
			this.VScroller.Click += this.VScroller_Click;
			this.HScroller.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			Point location2 = new Point(0, 0x247);
			this.HScroller.Location = location2;
			this.HScroller.Name = "HScroller";
			Size size2 = new Size(0x2F6, 0x11);
			this.HScroller.Size = size2;
			this.HScroller.TabIndex = 2;
			this.HScroller.Click += this.HScroller_Click;
			this.CornerBlock.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			Color backColor = Color.FromArgb(0x3E, 0x3E, 0x42);
			this.CornerBlock.Appearance.BackColor = backColor;
			this.CornerBlock.Appearance.Options.UseBackColor = true;
			Point location3 = new Point(0x2F6, 0x247);
			this.CornerBlock.Location = location3;
			this.CornerBlock.Name = "CornerBlock";
			Size size3 = new Size(0x11, 0x11);
			this.CornerBlock.Size = size3;
			this.CornerBlock.TabIndex = 3;
			this.Editor.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.Editor.AutoCompleteBrackets = true;
			char[] autoCompleteBracketsList = new char[]
			{
				'(',
				')',
				'{',
				'}',
				'[',
				']',
				'"',
				'"',
				'\'',
				'\''
			};
			this.Editor.AutoCompleteBracketsList = autoCompleteBracketsList;
			Size autoScrollMinSize = new Size(0x46, 0xF);
			this.Editor.AutoScrollMinSize = autoScrollMinSize;
			this.Editor.BackBrush = null;
			Color backColor2 = Color.FromArgb(0x1E, 0x1E, 0x1E);
			this.Editor.BackColor = backColor2;
			Color white = Color.White;
			this.Editor.CaretColor = white;
			Color changedLineColor = Color.FromArgb(0x1E, 0x1E, 0x1E);
			this.Editor.ChangedLineColor = changedLineColor;
			this.Editor.CharHeight = 0xF;
			this.Editor.CharWidth = 7;
			Color currentLineColor = Color.FromArgb(6, 6, 6);
			this.Editor.CurrentLineColor = currentLineColor;
			this.Editor.Cursor = Cursors.IBeam;
			this.Editor.DescriptionFile = System.IO.Path.Combine(Application.StartupPath, "GSXStyling.xml");
			Color disabledColor = Color.FromArgb(0x64, 0xB4, 0xB4, 0xB4);
			this.Editor.DisabledColor = disabledColor;
			Color foldingIndicatorColor = Color.FromArgb(0xF, 0xF, 0xF);
			this.Editor.FoldingIndicatorColor = foldingIndicatorColor;
			this.Editor.Font = new Font("Consolas", 9.75f);
			Color gainsboro = Color.Gainsboro;
			this.Editor.ForeColor = gainsboro;
			this.Editor.HighlightingRangeType = HighlightingRangeType.VisibleRange;
			//this.Editor.Hotkeys = componentResourceManager.GetString("Editor.Hotkeys");
			Color indentBackColor = Color.FromArgb(0x1E, 0x1E, 0x1E);
			this.Editor.IndentBackColor = indentBackColor;
			this.Editor.IsReplaceMode = false;
			this.Editor.LeftBracket = '{';
			this.Editor.LeftBracket2 = '(';
			this.Editor.LeftPadding = 0x1E;
			Color lineNumberColor = Color.FromArgb(0x2B, 0x91, 0xAF);
			this.Editor.LineNumberColor = lineNumberColor;
			Point location4 = new Point(0, 0);
			this.Editor.Location = location4;
			this.Editor.Name = "Editor";
			Padding paddings = new Padding(0xF, 0, 0, 0);
			this.Editor.Paddings = paddings;
			this.Editor.RightBracket = '}';
			this.Editor.RightBracket2 = ')';
			Color selectionColor = Color.FromArgb(0x3C, 0x33, 0x99, 0xFF);
			this.Editor.SelectionColor = selectionColor;
			//this.Editor.ServiceColors = (ServiceColors)componentResourceManager.GetObject("Editor.ServiceColors");
			this.Editor.ShowFoldingLines = true;
			this.Editor.ShowScrollBars = false;
			Size size4 = new Size(0x247, 0x247);
			this.Editor.Size = size4;
			this.Editor.TabIndex = 4;
			this.Editor.Zoom = 0x64;
			this.documentMap1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right);
			Color backColor3 = Color.FromArgb(0x1E, 0x1E, 0x1E);
			this.documentMap1.BackColor = backColor3;
			this.documentMap1.Font = new Font("Consolas", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			Color foreColor = Color.FromArgb(0x1E, 0x1E, 0x1E);
			this.documentMap1.ForeColor = foreColor;
			Point location5 = new Point(0x247, 0);
			this.documentMap1.Location = location5;
			this.documentMap1.Name = "documentMap1";
			this.documentMap1.ScrollbarVisible = false;
			Size size5 = new Size(0xAF, 0x247);
			this.documentMap1.Size = size5;
			this.documentMap1.TabIndex = 5;
			this.documentMap1.Target = this.Editor;
			SizeF autoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleDimensions = autoScaleDimensions;
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.documentMap1);
			base.Controls.Add(this.Editor);
			base.Controls.Add(this.CornerBlock);
			base.Controls.Add(this.HScroller);
			base.Controls.Add(this.VScroller);
			this.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
			this.LookAndFeel.UseDefaultLookAndFeel = false;
			base.Name = "XEditor";
			Size size6 = new Size(0x307, 0x258);
			base.Size = size6;
			((ISupportInitialize)this.Editor).EndInit();
			base.ResumeLayout(false);
		}

		private void VScroller_Click(object sender, EventArgs e)
		{
		}

		private void HScroller_Click(object sender, EventArgs e)
		{
		}

		private void OnDMMouseEnter(object sender, EventArgs e)
		{
			Color foreColor = Color.FromArgb(0xAA, 0xAA, 0xAA);
			this.documentMap1.ForeColor = foreColor;
		}

		private void OnDMMouseLeave(object sender, EventArgs e)
		{
			Color foreColor = Color.FromArgb(0x1E, 0x1E, 0x1E);
			this.documentMap1.ForeColor = foreColor;
		}

		private void OnTTDraw(object sender, DrawToolTipEventArgs e)
		{
			e.DrawBackground();
			e.DrawBorder();
			e.DrawText();
		}

		private void OnEClick(object sender, EventArgs e)
		{
			Color selectionColor = Color.FromArgb(0x33, 0x99, 0xFF);
			this.Editor.SelectionColor = selectionColor;
		}

		[HandleProcessCorruptedStateExceptions]
		protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool A_0)
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

		public AutocompleteMenu ACM;

		private DevExpress.XtraEditors.VScrollBar VScroller;

		private DevExpress.XtraEditors.HScrollBar HScroller;

		private XtraUserControl CornerBlock;

		private bool MovingVScrollBar = false;

		public FastColoredTextBox Editor;

		private DocumentMap documentMap1;

		private IContainer components;
	}
}
