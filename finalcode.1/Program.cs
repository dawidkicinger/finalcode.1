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
        //I have also made some public variables to call them from different functions and to easily alter them for all of the functions
        public string NewLine = Environment.NewLine;
        public string input;
        public string input2;
        public string GitRepositories_1a = System.IO.File.ReadAllText(@"GitRepositories_1a.txt");
        public string GitRepositories_1b = System.IO.File.ReadAllText(@"GitRepositories_1b.txt");
        public string GitRepositories_2a = System.IO.File.ReadAllText(@"GitRepositories_1b.txt");
        public string GitRepositories_2b = System.IO.File.ReadAllText(@"GitRepositories_2b.txt");
        public string GitRepositories_3a = System.IO.File.ReadAllText(@"GitRepositories_3a.txt");
        public string GitRepositories_3b = System.IO.File.ReadAllText(@"GitRepositories_3b.txt");

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
                CheckFiles();
            }
            else if (input == "file1")
            {
                Option2();
            }
            else if (input == $"File2")
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
            Console.WriteLine("GitRepositories_1a");
            Console.WriteLine("GitRepositories_1b");
            Console.WriteLine("GitRepositories_2a");
            Console.WriteLine("GitRepositories_2b");
            Console.WriteLine("GitRepositories_3a");
            Console.WriteLine("GitRepositories_3b");
            input2 = Console.ReadLine();
        }
        public void CheckFiles()
        //this is checking for files, comparing them and then letting the user know if they are the same or different
        {
            
            if (string.Equals(GitRepositories_1a, GitRepositories_1b))
            {
                Console.WriteLine("GitRepositories_1a and GitRepositories_1b are not different");
            }
            else
            {
                Console.WriteLine("GitRepositories_1a and GitRepositories_1b are different");
            }
            if (string.Equals(GitRepositories_2a, GitRepositories_2b))
            {
                Console.WriteLine("GitRepositories_2a and GitRepositories_2b are not different");
            }
            else
            {
                Console.WriteLine("GitRepositories_2a and GitRepositories_2b are different");
            }
            if (string.Equals(GitRepositories_3a, GitRepositories_3b))
            {
                Console.WriteLine("GitRepositories_3a and GitRepositories_3b are not different");
            }
            else
            {
                //Console.WriteLine("GitRepositories_3a and GitRepositories_3b are different" + NewLine);
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
