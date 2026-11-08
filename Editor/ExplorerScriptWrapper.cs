using System;
using DevExpress.XtraTreeList.Nodes;

namespace GSX_Studio
{
	public class ExplorerScriptWrapper
	{
		public ExplorerScriptWrapper(string NameIdentifier, GSCScript script)
		{
			this.Name = NameIdentifier;
			this.Script = script;
		}

		public override string ToString()
		{
			return this.Name;
		}

		public string Name;

		public GSCScript Script;

		public TreeListNode Node;
	}
}
