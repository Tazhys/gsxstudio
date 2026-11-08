using System;
using System.Runtime.InteropServices;

namespace XParserLib
{
	public class XParseLanguage
	{
		[return: MarshalAs(UnmanagedType.U1)]
		public bool IsComplete()
		{
			return this.LSealed;
		}

		public XLNonTerminal GetProgram()
		{
			return this.XProgram;
		}

		public void SealLanguage(XParseLanguage.DefineLanguage A_0)
		{
			this.XProgram = A_0();
			this.LSealed = true;
		}

		public XParseLanguage(string LanguageName)
		{
			this.Language = LanguageName;
		}

		public string Language;

		private bool LSealed;

		private XLNonTerminal XProgram;

		public delegate XLNonTerminal DefineLanguage();
	}
}
