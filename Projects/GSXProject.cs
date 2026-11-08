using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace GSX_Studio
{
	public class GSXProject
	{
		public void UpdateModified()
		{
			int num = 0;
			if (0 < this.ProjectFiles.Count)
			{
				do
				{
					int num2 = 0;
					if (0 < this.ProjectFiles[num].ScriptFiles.Count)
					{
						while (!this.ProjectFiles[num].ScriptFiles[num2].Modified)
						{
							num2++;
							if (num2 >= this.ProjectFiles[num].ScriptFiles.Count)
							{
								goto IL_66;
							}
						}
						goto IL_7A;
					}
					IL_66:
					num++;
				}
				while (num < this.ProjectFiles.Count);
				goto IL_83;
				IL_7A:
				this.Unsaved = true;
				return;
			}
			IL_83:
			this.Unsaved = false;
		}

		public static string GetDefaultProjectCode(string Creator, string ProjectName)
		{
			return GetDefaultProjectCode(Creator, ProjectName, null);
		}

		/// <summary>Build default code for the explicitly selected game-mode script path.</summary>
		public static string GetDefaultProjectCode(string Creator, string ProjectName, string scriptPath)
		{
			string name = "DefaultCode.txt";
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name);
			StreamReader streamReader = new StreamReader(manifestResourceStream);
			string text = "\n\n" + streamReader.ReadToEnd();
			if (streamReader != null)
			{
				((IDisposable)streamReader).Dispose();
			}
			if (manifestResourceStream != null)
			{
				((IDisposable)manifestResourceStream).Dispose();
			}
			// The embedded template targets Zombies. Only paths that explicitly
			// select multiplayer's gametypes directory override those includes;
			// shared/unknown paths retain the existing template.
			string path = (scriptPath ?? "").Replace('\\', '/').TrimStart('/');
			if (path.StartsWith("maps/mp/gametypes/", StringComparison.OrdinalIgnoreCase))
			{
				text = text.Replace("maps\\mp\\gametypes_zm\\_hud_util;", "maps\\mp\\gametypes\\_hud_util;")
					.Replace("maps\\mp\\gametypes_zm\\_hud_message;", "maps\\mp\\gametypes\\_hud_message;");
			}
			return text.Replace("{CREATOR_NAME}", Creator).Replace("{PROJECT_NAME}", ProjectName);
		}

		public static GSXProject LoadProject(string FileName)
		{
			if (!File.Exists(FileName))
			{
				return null;
			}
			GSXProject gsxproject = new GSXProject();
			List<byte> list = new List<byte>();
			list.AddRange(File.ReadAllBytes(FileName));
			byte[] array = new byte[]
			{
				0x25,
				0x47,
				0x53,
				0x58,
				0x50,
				0x25
			};
			byte[] array2 = new byte[6];
			string str = FileName.Substring(0, FileName.LastIndexOf(Path.DirectorySeparatorChar) + 1);
			if (list.Count < array.Length)
			{
				throw new Exception("File is not a valid GSX Project");
			}
			int num = 0;
			if (0 < array2.Length)
			{
				do
				{
					array2[num] = list[num];
					num++;
				}
				while (num < array2.Length);
			}
			if (!IDE.Utility.ByteMatch(array2, array))
			{
				throw new Exception("File is not a valid GSX Project");
			}
			int num2 = 6;
			try
			{
				string creatorName = IDE.Utility.StringFromBytes(list, ref num2);
				string text = IDE.Utility.StringFromBytes(list, ref num2);
				gsxproject.SourceLocation = str + text + Path.DirectorySeparatorChar;
				gsxproject.CreatorName = creatorName;
				gsxproject.ProjectName = text;
				byte b = list[num2];
				num2++;
				gsxproject.NumberOfScripts = b;
				for (byte b2 = 0; b2 < b; b2 += 1)
				{
					GSCScript gscscript = new GSCScript();
					gscscript.Name = IDE.Utility.StringFromBytes(list, ref num2);
					gscscript.NumberOfScriptFiles = list[num2];
					num2++;
					for (byte b3 = 0; b3 < gscscript.NumberOfScriptFiles; b3 += 1)
					{
						string text2 = IDE.Utility.StringFromBytes(list, ref num2);
						GSCPart item = new GSCPart(File.ReadAllText(str + text + Path.DirectorySeparatorChar + gscscript.Name + Path.DirectorySeparatorChar + text2), text2);
						gscscript.ScriptFiles.Add(item);
					}
					gsxproject.ProjectFiles.Add(gscscript);
				}
				gsxproject.TypeStrictState = list[num2];
				num2++;
				gsxproject.InlineState = list[num2];
				num2++;
				gsxproject.Debug = list[num2] != 0;
				num2++;
				gsxproject.Watermark = IDE.Utility.StringFromBytes(list, ref num2);
			}
			catch (Exception)
			{
				throw new Exception("File is not a valid GSX Project");
			}
			return gsxproject;
		}

		public static GSXProject CreateProject(string ProjectName, string CreatorName, string Description, string PathLocation, string ScriptName)
		{
			string arg = null;
			string text = new string(Path.GetInvalidPathChars());
			int num = 0;
			if (0 < text.Length)
			{
				do
				{
					ProjectName = ProjectName.Replace(text[num] + "", "#");
					ScriptName = ScriptName.Replace(text[num] + "", "#");
					num++;
				}
				while (num < text.Length);
			}
			arg = PathLocation + Path.DirectorySeparatorChar + ProjectName + Path.DirectorySeparatorChar + ProjectName;
			string text2 = PathLocation + Path.DirectorySeparatorChar + ProjectName;
			try
			{
				Directory.CreateDirectory(text2);
				Directory.CreateDirectory(text2 + Path.DirectorySeparatorChar + ProjectName);
				string[] array = ScriptName.Split(new char[]
				{
					'\\',
					'/'
				});
				for (int i = 0; i < array.Length; i++)
				{
					if (!Directory.Exists(arg + Path.DirectorySeparatorChar + array[i]))
					{
						Directory.CreateDirectory(arg + Path.DirectorySeparatorChar + array[i]);
					}
					arg = arg + Path.DirectorySeparatorChar + array[i];
				}
			}
			catch (Exception ex)
			{
				throw new Exception("Couldnt create a new project directory! (" + ex.Message + ")");
			}
			List<byte> list = new List<byte>();
			list.AddRange(new byte[]
			{
				0x25,
				0x47,
				0x53,
				0x58,
				0x50,
				0x25
			});
			list.AddRange(IDE.Utility.BytesFromString(CreatorName));
			list.AddRange(IDE.Utility.BytesFromString(ProjectName));
			list.Add(1);
			list.AddRange(IDE.Utility.BytesFromString(ScriptName));
			list.Add(1);
			list.AddRange(IDE.Utility.BytesFromString("main.gsx"));
			list.AddRange(IDE.GetDefaultProjectData());
			try
			{
				File.WriteAllBytes(text2 + Path.DirectorySeparatorChar + ProjectName + ".gsxp", list.ToArray());
				File.WriteAllText(arg + Path.DirectorySeparatorChar + "main.gsx", "/*\n" + Description + "\n*/" + GSXProject.GetDefaultProjectCode(CreatorName, ProjectName, ScriptName));
			}
			catch (Exception ex2)
			{
				throw new Exception("Couldnt create a new project file! (" + ex2.Message + ")");
			}
			return GSXProject.LoadProject(text2 + Path.DirectorySeparatorChar + ProjectName + ".gsxp");
		}

		public string ProjectName;

		public string CreatorName;

		public string SourceLocation;

		public byte NumberOfScripts;

		public List<GSCScript> ProjectFiles = new List<GSCScript>();

		public bool Unsaved = false;

		public byte TypeStrictState;

		public byte InlineState;

		public bool Debug;

		public string Watermark;
	}
}
