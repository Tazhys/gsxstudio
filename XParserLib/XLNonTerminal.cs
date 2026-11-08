using System;

namespace XParserLib
{
	public class XLNonTerminal
	{
		public XLNonTerminal(string name)
		{
			this.Name = name;
		}

		public XLNonTerminal()
		{
			this.Name = "unknown";
		}

		public static XLNonTerminal GetDefaultProgram()
		{
			return new XLNonTerminal
			{
				Name = "program"
			};
		}

		public string Name;

		public XLState Rule;
	}
}
