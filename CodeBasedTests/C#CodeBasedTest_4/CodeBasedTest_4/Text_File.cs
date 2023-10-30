using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBasedTest_4
{
    class Text_File
    {
        static void Main(string[] args)
        {
            string dirpath = @"D:\C#\Practice";
            string filepath = Path.Combine(dirpath, "Myfile.txt");
            try
            {
                Directory.CreateDirectory(dirpath);

                using (StreamWriter sw1 = File.CreateText(filepath))
                {
                    sw1.WriteLine("Welcome to the new .txt file");
                    sw1.WriteLine("You can use this space as your notepad to note down imporatnt points\nThanks.");
                    Console.WriteLine(".txt file created successfulluy!!!");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
