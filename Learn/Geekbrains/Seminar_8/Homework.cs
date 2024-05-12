using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_8
{
    public class Homework
    {
        public static List<string> list = new();

        private static bool IsFoundedText(string path, string text)
        {
            using StreamReader sr = new StreamReader(path);
            while (!sr.EndOfStream)
            {
                var tempString = sr.ReadLine();
                if (tempString.Contains(text))
                {
                    return true;
                }
            }

            return false;
        }

        public static void SearchFile(string path, string extension, string fileName)
        {
            var files = Directory.GetFiles(path);

            foreach (var file in files)
            {
                var name = Path.GetFileName(file);
                var exten = Path.GetExtension(file);
                if (exten == extension)
                {
                    if (IsFoundedText(file, fileName))
                    {
                        list.Add(file);
                    }
                }
            }

            var directories = Directory.GetDirectories(path);
            foreach (var directory in directories)
            {
                SearchFile(directory, extension, fileName);
            }
        }
    }
}