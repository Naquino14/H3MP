using System;
using System.Collections.Generic;
using System.Text;

namespace Discord
{
	public partial class StorageManager // creates a list of file info and adds it to something, not too sure
	{
		public IEnumerable<FileStat> Files()
		{
			var fileCount = Count();
			var files = new List<FileStat>();
			for (var i = 0; i < fileCount; i++)
			{
				files.Add(StatAt(i));
			}
			return files;
		}
	}
}
