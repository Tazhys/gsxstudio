using System;

namespace XParserLib
{
	public class XParser
	{
		public XParseTree FullParse(string A_0)
		{
			if (this.Language == null)
			{
				throw new Exception("No Language was defined to parse");
			}
			if (A_0 == null)
			{
				return null;
			}
			return null;
		}

		public XParser(XParseLanguage language)
		{
			this.Language = language;
		}

		private XParseLanguage Language;
	}
}
