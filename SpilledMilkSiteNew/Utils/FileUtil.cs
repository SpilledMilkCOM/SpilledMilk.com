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
		public static List<string> FilterImagesInPath(HttpServerUtilityBase server, string webRootPath, string filter)
		{
			var fileSystemRootPath = server.MapPath(webRootPath);
			var thumbPath = $"{fileSystemRootPath}{Path.DirectorySeparatorChar}thumbs";
			var files = Directory.GetFiles(fileSystemRootPath, filter);
			var result = new List<string>();

			foreach (var file in files)
			{
				var fileName = Path.GetFileName(file);

				// Make sure the thumbnail exists before the image is added.

				if (File.Exists($"{thumbPath}{Path.DirectorySeparatorChar}{fileName}"))
				{
					result.Add(fileName);
				}
			}

			return result;
		}

		public static string ParseImageFileName(string fileName)
		{
			if (fileName != null)
			{
				char[] delimeters = { '_' };
				fileName = Path.GetFileNameWithoutExtension(fileName);
				var pieces = fileName.Split(delimeters);

				if (pieces.Length == 2)
				{
					fileName = $"{pieces[1]} {pieces[0]}";
				}

				// If it doesn't split correctly, oh well at least the extension is gone. (for those one word names like M3TH)
			}

			return fileName;
		}
	}
}