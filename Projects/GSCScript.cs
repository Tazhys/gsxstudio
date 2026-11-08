using System;
using System.Collections.Generic;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraTreeList.Nodes;
using FastColoredTextBoxNS;
using GSXCompilerLib;
using Irony.Parsing;

namespace GSX_Studio
{
	public class GSCScript
	{
		public void SyncEditorContents()
		{
			int num = 0;
			if (0 < this.ScriptFiles.Count)
			{
				do
				{
					this.ScriptFiles[num].Contents = this.Links[this.ScriptFiles[num]].Editor.Text;
					num++;
				}
				while (num < this.ScriptFiles.Count);
			}
		}

		public void RefreshParseTrees(Parser parser)
		{
			List<GSCPart>.Enumerator enumerator = this.ScriptFiles.GetEnumerator();
			if (enumerator.MoveNext())
			{
				do
				{
					enumerator.Current.LoadCache(parser);
				}
				while (enumerator.MoveNext());
			}
		}

		public string Name;

		public byte NumberOfScriptFiles;

		public TreeListNode Node;

		public List<GSCPart> ScriptFiles = new List<GSCPart>();

		public Dictionary<GSCPart, XEditor> Links = new Dictionary<GSCPart, XEditor>();

		public Dictionary<XEditor, GSCPart> EditorLinks = new Dictionary<XEditor, GSCPart>();

		public Dictionary<GSCPart, DockPanel> WindowLinks = new Dictionary<GSCPart, DockPanel>();

		public bool Linked = false;

		public Intellisense.ScriptInfo ScriptInfo = new Intellisense.ScriptInfo();

		public List<AutocompleteItem> Autos = new List<AutocompleteItem>();
	}
}
