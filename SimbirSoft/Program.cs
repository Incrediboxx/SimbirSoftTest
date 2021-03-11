using System;
using System.IO;
using System.Collections.Generic;

/*
    Скачать html в файл
    построчно прочитать файл разбивая на слова
    слова записать в словарь 
 
 */

namespace SimbirSoft
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length > 0)
                {
                    Dictionary<string, int> wordDictionary = FileHelper.FileWordsCount(HTMLHelper.LoadHtml(args[0]));            

                    foreach (var word in wordDictionary)
                        Console.WriteLine($"{word.Key} встречается {word.Value} раз(а)");

                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Url адрес не указан");
                }                               
            }
            catch (Exception e)
            {
                Logger.LogSomeError(e);

            }




        }     
    }
}
