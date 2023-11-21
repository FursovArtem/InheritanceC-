//#define WRITE_TO_FILE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files
{
    internal class Program 
    {
        static void Main(string[] args)
        {
#if WRITE_TO_FILE
            Console.WriteLine("Hello Files");

            string directory = Directory.GetCurrentDirectory();
            string filename = "File.txt";
            Console.WriteLine(Directory.GetCurrentDirectory());
            StreamWriter sw = new StreamWriter("File.txt");
            sw.WriteLine("Hello files");
            sw.Close();

            using (StreamWriter file = File.AppendText(filename))
            {
                file.WriteLine("Привет");
            }

            string cmd = directory + "\\" + filename;
            System.Diagnostics.Process.Start(cmd); 
#endif
            StreamReader sr = new StreamReader("File.txt");
            while(!sr.EndOfStream)
            {
                string buffer = sr.ReadLine();
                Console.WriteLine(buffer);
            }
            sr.Close();
        }
    }
}
