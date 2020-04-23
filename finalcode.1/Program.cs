using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3
{
    class Program
    {
        //a couple of variables that I am going to use throughout the program, and I have added one variable to make NewLine(to simplify command and to reduce amount of repetition of long command)
        public string NewLine = Environment.NewLine;
        public string input;
        public string input2;

        static void Main(string[] args)
        {
            //local variable made and some lines of code asking what the user wants to do
            Program p = new Program();
            p.Option1();

        }
        public void Option1()
        {
            Console.WriteLine("Which is the first file would you like to check" + NewLine);
            Console.WriteLine("Options");
            Console.WriteLine("File1");
            Console.WriteLine("File2");
            Console.WriteLine("File3");
            Console.WriteLine("File4");
            Console.WriteLine("File5");
            Console.WriteLine("File6" + NewLine);
            input = Console.ReadLine();
            if (input == "File1")
            {
                Option2();
            }
            else if (input == $"file1 or File1")
            {
                Option2();
            }
            else if (input == "File2")
            {
                Option2();
            }
            else if (input == "file2")
            {
                Option2();
            }
            else if (input == "File3")
            {
                Option2();
            }
            else if (input == "file3")
            {
                Option2();
            }
            else if (input == "File4")
            {
                Option2();
            }
            else if (input == "file4")
            {
                Option2();
            }
            else if (input == "File5")
            {
                Option2();
            }
            else if (input == "file5")
            {
                Option2();
            }
            else if (input == "File6")
            {
                Option2();
            }
            else if (input == "file6")
            {
                Option2();
            }
            else
            {
                Console.WriteLine("Incorrect input please try again");
                Option1();
            }

        }
        public void Option2()
        {
            Console.WriteLine("Which is the second file would you like to check" + NewLine);
            Console.WriteLine("Options");
            Console.WriteLine("File1");
            Console.WriteLine("File2");
            Console.WriteLine("File3");
            Console.WriteLine("File4");
            Console.WriteLine("File5");
            Console.WriteLine("File6");
            input2 = Console.ReadLine();
        }
        public void CheckFiles()
        //this is checking for files, comparing them and then letting the user know if they are the same or different
        {
            string file1 = File.ReadAllText(@"GitRepositories_1a.txt");
            string file2 = File.ReadAllText(@"GitRepositories_1b.txt");
            string file3 = File.ReadAllText(@"GitRepositories_2a.txt");
            string file4 = File.ReadAllText(@"GitRepositories_2b.txt");
            string file5 = File.ReadAllText(@"GitRepositories_3a.txt");
            string file6 = File.ReadAllText(@"GitRepositories_3b.txt");
            if (string.Equals(file1, file2))
            {
                Console.WriteLine("GitRepositories_1a and GitRepositories_1b are not different");
            }
            else
            {
                Console.WriteLine("GitRepositories_1a and GitRepositories_1b are different");
            }
            if (string.Equals(file3, file4))
            {
                Console.WriteLine("GitRepositories_2a and GitRepositories_2b are not different");
            }
            else
            {
                Console.WriteLine("GitRepositories_2a and GitRepositories_2b are different");
            }
            if (string.Equals(file5, file6))
            {
                Console.WriteLine("GitRepositories_3a and GitRepositories_3b are not different");
            }
            else
            {
                Console.WriteLine("GitRepositories_3a and GitRepositories_3b are different" + NewLine);
            }
            Program p = new Program();
            Console.WriteLine("Would you like to quit type Yes or No");
            if (input == "Yes")
            {
                return;
            }
            else if (input == "yes")
            {
                return;
            }
            else if (input == "No")
            {
                Option1();
            }
        }

    }

}
