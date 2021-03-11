using System;
using System.Net;
using System.IO;

namespace SimbirSoft
{
    abstract class HTMLHelper
    {
        public static string LoadHtml(string url)
        {
            var filename = Guid.NewGuid().ToString();
            using (WebClient client = new WebClient())
            {
                try
                {
                    if (!Directory.Exists("HTMLS"))
                        Directory.CreateDirectory("HTMLS");

                    client.DownloadFile(url, $"HTMLS/{filename}.html");
                    return filename;
                }
                catch (Exception e)
                {
                    Logger.LogSomeError(e);
                    return null;
                }
            }
        }
    }
}
