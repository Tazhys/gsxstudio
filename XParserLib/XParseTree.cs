using System;

namespace XParserLib
{
	public class XParseTree
	{
		public XParseTree(XParseNode root, XParseLanguage language)
		{
			this.Root = root;
			this.Language = language;
		}

		public XParseNode Root;

		public XParseLanguage Language;
	}
}
