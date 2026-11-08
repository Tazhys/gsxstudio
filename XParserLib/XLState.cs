using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace XParserLib
{
	public class XLState
	{
		[return: MarshalAs(UnmanagedType.U1)]
		public bool Match(string A_0)
		{
			return false;
		}

		public XLState(List<XLState> SubTerms)
		{
			this.Terms = SubTerms;
			this.IsTerminal = false;
			this.UsingStaticValue = false;
		}

		public XLState(string staticvalue)
		{
			this.UsingStaticValue = true;
			this.StaticValue = staticvalue;
			this.IsTerminal = true;
			this.TerminalType = this.KEYWORD;
		}

		public XLState(int Type)
		{
			this.UsingStaticValue = false;
			this.IsTerminal = true;
			this.TerminalType = Type;
		}

		public static XLState operator +(XLState A_0, string A_1)
		{
			XLState a_ = new XLState(A_1);
			return A_0 + a_;
		}

		public static XLState operator +(XLState A_0, XLState A_1)
		{
			List<XLState> list = new List<XLState>();
			list.AddRange(A_0.Terms);
			list.AddRange(A_1.Terms);
			return new XLState(list);
		}

		public static XLState operator |(XLState A_0, XLState A_1)
		{
			return null;
		}

		public static XLState operator &(XLState A_0, XLState A_1)
		{
			return A_0 + A_1;
		}

		public static implicit operator XLState(string str)
		{
			return new XLState(str);
		}

		public List<XLState> Terms = new List<XLState>();

		private string StaticValue;

		private bool UsingStaticValue;

		private bool IsTerminal;

		private int TerminalType;

		private int IDENTIFIER = 0;

		private int NUMBER = 1;

		private int COMMENT = 2;

		private int KEYWORD = 3;

		private int UNKNOWNTERMINAL = 0xFF;
	}
}
