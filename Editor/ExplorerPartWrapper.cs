using System;

namespace GSX_Studio
{
	public class ExplorerPartWrapper
	{
		public ExplorerPartWrapper(string NameIdentifier, GSCPart script)
		{
			this.Name = NameIdentifier;
			this.Script = script;
		}

		public override string ToString()
		{
			return this.Name;
		}

		public string Name;

		public GSCPart Script;
	}
}
