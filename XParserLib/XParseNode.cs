using System;
using System.Collections.Generic;

namespace XParserLib
{
	public class XParseNode
	{
		public string Value
		{
			get
			{
				return this._backingStoreValue;
			}
			set
			{
				this._backingStoreValue = value;
			}
		}

		public XParseNode(string TypeOfGNode)
		{
			this.TypeIdentity = TypeOfGNode;
		}

		public string TypeIdentity;

		private string _backingStoreValue;

		public List<XParseNode> Children = new List<XParseNode>();
	}
}
