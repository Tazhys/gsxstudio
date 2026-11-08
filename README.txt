Welcome to GSX Studio!

In memory of SeriousHD:
    GSX Studio was created by SeriousHD, also known as Shiversoftdev and Serious.
    She passed away in 2025. Her work, generosity, and commitment to the modding
    scene meant a great deal to the people who used and learned from her projects.
    We are grateful for everything she contributed over the years.

    We were fortunate that she released some of her older projects, including a
    partial recovery of GSX Studio. That release helped make this build possible.
    Further recovery has drawn on reverse engineering and decompilation to
    understand and restore missing pieces. This work continues in appreciation
    of her contributions and the community around them.

Recovery and development:
    - SeriousHD (Shiversoftdev) ~ Original creator of GSX Studio and the released
      partial recovery.
    - Tazhys ~ Continued recovery, fixes, and development of this version.

    This recovery is intended to be open sourced in the future.

Special Thanks to the following people:
	-Extinct ~ Support, lots of help with function definitions and alpha testing.
	-SyGnUs ~ GSC Dumper, massive help in the creation and development of unsafe custom functions
	-Agreedbog ~ Help with some assembly for custom functions
	-Alfredo ~ Support, small toolwork here and there
	-Loz ~ General GSC Support
	-Kokole, Nukem, Master131 ~ Original reversal of Black Ops II GSC
	-DTX12 ~ His original compiler work
	-Jwm614 ~ Help with some PC injection addresses and the text editor
	-XTul, TCM, Inc ~ Alpha testing
	-jakedragon24, Cykotic ~ Helped with Xbox SESR Database Collection
	-Cooljay ~ Breaking gsx better than anyone else so I can make it better :D

Additional source credits:
	-iMCSx / iMCS Productions, Enstone, Buc-ShoTz ~ Credited in the PS3Lib source headers.

Historical changelog (original notes; some entries may no longer apply):

	Known Bugs:
			> Defining functions with the same name as a builtin will confuse the linker and optimizer, causing script errors.
			> Loading a file with a large horizontal region may cause the scrollbar to be incorrectly limited until the longest line in the script has been edited
			> Xbox users are currently unable to use custom functions. This will be resolved as soon as I can obtain the needed information.
				- Please note: You will still be able to inject scripts compiled outside of gsx studio. This will be fixed as soon as possible

	Version 1.2a	  
		- Private Alpha
	Version 1.4.0.0 
		- Public Alpha
	Version 1.6.0.0 (Public Beta)
		New Features:
			- Full Number support (hex, float, double, etc)
			- #region support for code organization
			- waitmin(): Supports waiting the absolute smallest time allowed by the game engine without triggering the network freeze logic
			- 'goto' and 'label':
				> Mark a section by typing an identifier followed by ':'
				> type goto followed by the name of the section to jump to that section!
				> Example code:
								start:
									self iprintln("Hi there!");
									waitmin;
									goto start;
			- Detects undefined local variables automatically during compilation
			- Syntax Update: You can now include, define functions, define macros, etc. in any order
			- New advanced script protection!
				> Used for special portions of code that need to be more secure than usual
				> Syntax: $(section_identifier){ /*code here*/ }
				> Example code:
								$(auto_verify)
								{
									foreach(player in level.players)
										if(player IsFounder())
											player CreateMenu(FOUNDER_ACCESS);
								}
			- New Memory Based Functions (calls are highlighted in red)
				- Please note that these functions are run on the HOST ONLY. You cannot call these functions and set memory on a client's machine (yet :D)
					> void SetInt( uint address, uint value )
					> int32 GetInt( uint address )
					> void SetByte( uint address, byte value )
					> byte GetByte( uint address )
					> void SetFloat( uint address, float value )
					> float GetFloat( uint address )
					> void SetString( uint address, string value )
					> void SetBytes( uint address, byte[] value )
					> void SetWord( uint address, word value )
					> word GetWord( uint address )

			- New RPC Function!
				- Call any function embedded in the game or loaded into process memory!
				- Please note that this function is run on the HOST ONLY.
					> int RPC( address, params... )
						- RPC returns whatever was loaded into eax/r3 from the function called. This means that if the function returns nothing you will get '0' back
						- This also means that return values are almost always pointers (unless simple types)
						- You will need to write any custom structs to memory and pass references through parameters
						- I will release a full RPC tutorial once the beta is out.

			- New Script Environment String Reduction feature:
				> Reduces string usage on platform by on average 33%, saving you nearly 3000 strings for your scripts.

			- New array shorthanding:
				> Use the 'array' keyword before a declaration to set up an array shorthand
					> Example code:
									array MyArray = { "Hello", "World", "!" };



		Bug Fixes:
			- Fixed 'Form has already been shown' exception
			- Fixed string definition so its coloration no longer exceeds its boundaries
			- Fixed an issue where the updater would loop infinitely if anti-virus removed the update file before the process finished
			- Fixed an issue where compiling certain gsc files would result in the linker producing false errors
			- Fixed an issue with steam injection that caused a windows access exception
			- Fixed an issue with PC Zombies injection that caused inadvertent overlapping of memory segments
			- Fixed an exception that occurred when starting GSX Studio without the default styling sheet
			- Optimized define replacement process to produce closer to O(c_string_count) versus O(c_string_count * defines_count^2)
			- Removed old GSX syntax highlighting to accomodate the new syntax

	Version {VERSION}
		New Features:
			
			New Platform:
				- XRPC is now supported for XB360

			New Memory Based Functions:
				- void* XAlloc( size ): Allocates memory of the specified size. Will return a pointer to the allocated object
				- void XDelete( ptr ): Deletes an object allocated by XAlloc
				- void* xstralloc( string ): Allocates a string in memory and then writes it to that position, returning a pointer to the string

			New Built-in Overflow Fix:
				- Much more advanced and simple than traditional overflow fixes
				- Call XOverflowFix( max_strings ) in your init, and then use XSetText on your text elements. Thats it! No redraw or extra hassle required!
				- You can also optionally call xoverflowclear( ?index, ?auto_redraw ) if you want to clear manually for whatever reason. 
				- Set __xoverflowusedelay__ to true or false depending on if you want a delay when clearing
				- define __xoverflowbatchsize__ to the number of strings to clear at a time when delay is active
			
			New grammar checking features:
				- Functions that collide with in game functions will automatically be detected and reported as erorrs

			
			New Builtins:
				- atostr( array, ?delim ): Convert an array to a string
				- dectohex( value ): Convert a decimal value into a hex value
				- hextodec( str_hex ): Convert hex into a decimal value

		Bug Fixes:
			- Fixed an issue where using a string literal version of a builtin identifier would cause a massive application hang
			- Failed to write is more verbose
			- Fixed an issue where parameters were detected if there was a space between empty parentheses 

Main Features:
	- Faster Compiler
	- Source protection built in
	- Script optimization
	- Many bug fixes from the original compiler
	- Autocomplete
	- Fully contained projects
	- Multi-Script support
	- Syntax error navigation and better accuracy
	- Basic Macros (define identifier expr;)
	- Post build linker that catches unresolved functions

P.S.
	- Please note that this is an beta build. This application has many features disabled which may never be implemented. 
	- This application may also have some bugs, so please report any bugs that you notice to me using About->Report a bug