using System;
using System.Collections.Generic;
using System.IO;

namespace SimbirSoft
{
    abstract class FileHelper
    {
        public static Dictionary<string,int> FileWordsCount(string filename)
        {
            Dictionary<string, int> wordDictionary = new Dictionary<string, int>();
            try
            {
                using (StreamReader sr = new StreamReader($"HTMLS/{filename}.html"))
                {
                    while (!sr.EndOfStream)
                    {
                        var words = sr.ReadLine().Split(new[] { ' ', ',', '.', '!', '?', '"', ';', ':', '[', ']', '(', ')', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                        foreach (var word in words)
                            if (wordDictionary.ContainsKey(word))
                                wordDictionary[word] += 1;
                            else
                                wordDictionary.Add(word, 1);
                    }
                    return wordDictionary;
                }
            }
            catch (Exception e)
            {
                Logger.LogSomeError(e);
                return null;
            }
        }
    }
}
