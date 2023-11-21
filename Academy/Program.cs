using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Dynamic;
using System.Text.RegularExpressions;

namespace Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("Vercetti", "Tommy", 30);
            Student student = new Student("Pinkman", "Jessie", 25, "Chemistry", "WW220", 95, 98);
            Teacher teacher = new Teacher("White", "Walter", 50, "Chemistry", 20);
            Graduate graduate = new Graduate("Schreder", "Hank", 40, "Criminalistic", "OBN", 70, 40, "How to catch Heisenberg");
            Student tommy = new Student(human, "Theft", "Vice", 98, 99);
            Graduate tommy_grad = new Graduate(tommy, "How to make money");

            Human[] group = new Human[]
                {
                    student, teacher, graduate, tommy, tommy_grad,
                    new Graduate("Rosenberg", "Ken", 30, "Lawyer", "Vice", 45, 22, "How to get money back"),
                    new Teacher("Diaz", "Ricardo", 50, "Weapons distribution", 25)
                };
            StreamWriter sw = new StreamWriter("group.txt");

            foreach (Human i in group)
            {
                sw.Write(i.GetType() + ": ");
                sw.WriteLine(i);
            }
            sw.Close();
            System.Diagnostics.Process.Start("notepad", $"{Directory.GetCurrentDirectory()}\\group.txt");

            StreamReader sr = new StreamReader("group.txt");
            List<string> strings = new List<string>();
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                strings.Add(line);
            }
            Human[] load = new Human[strings.Count];
            for (int i = 0; i < load.Length; i++)
            {
                if (strings[i].Contains("Academy.Human"))
                {
                    strings[i] = strings[i].Replace("Academy.Human: ", "").Replace(" лет", "");
                    string[] split = Regex.Split(strings[i], "(?=(?<= )\\p{Lu}|(?<= )\\d)");
                    load[i] = new Human(split[0], split[1], Convert.ToInt32(split[2]));
                }
                else if (strings[i].Contains("Academy.Student"))
                {
                    strings[i] = strings[i].Replace("Academy.Student: ", "").Replace(" лет", "");
                    string[] split = Regex.Split(strings[i], "(?=(?<= )\\p{Lu}|(?<= )\\d)");
                    load[i] = new Student(split[0], split[1], Convert.ToInt32(split[2]), split[3], split[4], Convert.ToDouble(split[5]), Convert.ToDouble(split[6]));
                }
                else if (strings[i].Contains("Academy.Teacher"))
                {
                    strings[i] = strings[i].Replace("Academy.Teacher: ", "").Replace(" лет", "");
                    string[] split = Regex.Split(strings[i], "(?=(?<= )\\p{Lu}|(?<= )\\d)");
                    load[i] = new Teacher(split[0], split[1], Convert.ToInt32(split[2]), split[3], Convert.ToInt32(split[4]));
                }
                else if (strings[i].Contains("Academy.Graduate"))
                {
                    strings[i] = strings[i].Replace("Academy.Graduate: ", "").Replace(" лет", "");
                    string[] split = Regex.Split(strings[i], "(?=(?<= )\\p{Lu}(?=\\p{Ll}+? )|(?<= )\\p{Lu}{2,}|(?<= )\\d)");
                    load[i] = new Graduate(split[0], split[1], Convert.ToInt32(split[2]), split[3], split[4], Convert.ToDouble(split[5]), Convert.ToDouble(split[6]), split[7]);
                }
            }
            foreach (Human i in load) Console.WriteLine(i);
            sr.Close();
        }
    }
}
