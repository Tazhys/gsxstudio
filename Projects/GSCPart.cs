using System;
using System.Collections.Generic;
using FastColoredTextBoxNS;
using GSXCompilerLib;
using Irony.Parsing;

namespace GSX_Studio
{
	public class GSCPart
	{
		public GSCPart(string Code, string name)
		{
			this.Contents = Code;
			this.Name = name;
		}

		public void LoadCache(Parser Parser)
		{
			this.Tree = Parser.Parse(this.Contents);
		}

		public void SetCache(Parser Parser, string filename, string cts)
		{
			this.Tree = Parser.Parse(cts, filename);
		}

		public List<AutocompleteItem> GetFunctionsList()
		{
			this.FunctionsACList.Clear();
			ParseTree tree = this.Tree;
			if (tree != null && tree.ParserMessages.Count <= 0)
			{
				List<ParseTreeNode>.Enumerator enumerator = Intellisense.CollectFunctionNodes(this.Tree).GetEnumerator();
				if (enumerator.MoveNext())
				{
					do
					{
						ParseTreeNode node = enumerator.Current;
						AutocompleteItem autocompleteItem = new AutocompleteItem();
						autocompleteItem.Text = Intellisense.FindFunctionHeader(node);
						autocompleteItem.ToolTipText = Intellisense.FindFunctionDescription(node);
						autocompleteItem.ToolTipTitle = Intellisense.FindFunctionHeader(node);
						autocompleteItem.ImageIndex = 0;
						this.FunctionsACList.Add(autocompleteItem);
					}
					while (enumerator.MoveNext());
				}
				return this.FunctionsACList;
			}
			return this.FunctionsACList;
		}

		public bool Modified;

		public string Name;

		public string Contents;

		public ParseTree Tree;

		public List<AutocompleteItem> FunctionsACList = new List<AutocompleteItem>();
	}
}
