using System;
using System.Collections.Generic;
using System.IO;
using System.Web;

namespace SM.Utils
{
	public class FileUtil
	{
		private const string DEFAULT_IMAGE_DIR = "images";
		private const string DEFAULT_IMAGE = "Check Out My Stuff Default.png";

		/// <summary>
		/// Return a list of file names given the web path and filter.
		/// </summary>
		/// <param name="server">Server utility.</param>
		/// <param name="webRootPath">The web path to the images.</param>
		/// <param name="filter">The file system filter/wildcard.</param>
		/// <returns></returns>
		public static List<string> FilterImagesInPath(HttpServerUtilityBase server, string webRootPath, string filter, int count = 0)
		{
			var fileSystemRootPath = server.MapPath(webRootPath);
			var thumbPath = $"{fileSystemRootPath}{Path.DirectorySeparatorChar}thumbs";
			var files = Directory.GetFiles(fileSystemRootPath, filter);
			var fileCount = files.Length;
			var result = new List<string>();

			if (count > 0 && count < fileCount)
			{
				var random = new Random();

				while (result.Count < count)
				{
					var index = random.Next(0, fileCount - 1);

					AddFileName(result, Path.GetFileName(files[index]), thumbPath);
				}
			}
			else
			{
				foreach (var file in files)
				{
					AddFileName(result, Path.GetFileName(file), thumbPath);
				}
			}

			return result;
		}

		public static string ParseImageFileDate(string fileName)
		{
			if (fileName != null)
			{
				char[] delimeters = { '_' };
				fileName = Path.GetFileNameWithoutExtension(fileName);
				var pieces = fileName.Split(delimeters);

				if (pieces.Length >= 3)
				{
					fileName = pieces[2];
				}
				else
				{
					fileName = "2002";
				}
			}

			return fileName;
		}

		public static string ParseImageFileName(string fileName)
		{
			if (fileName != null)
			{
				char[] delimeters = { '_' };
				fileName = Path.GetFileNameWithoutExtension(fileName);
				var pieces = fileName.Split(delimeters);

				if (pieces.Length >= 2)
				{
					fileName = $"{pieces[1]} {pieces[0]}";
				}

				// If it doesn't split correctly, oh well at least the extension is gone. (for those one word names like M3TH)
			}

			return fileName;
		}

		private static void AddFileName(List<string> list, string fileName, string thumbPath)
		{
			// Make sure the thumbnail exists before the image is added.

			if (File.Exists($"{thumbPath}{Path.DirectorySeparatorChar}{fileName}")
			&& !list.Contains(fileName))
			{
				list.Add(fileName);
			}
		}
	}
}