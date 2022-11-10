using System;
using System.IO;

using System.Linq;

namespace ConsoleApp1
{
    class Sample
    {
        public static void Main(string[] args)
        {
            Console.WriteLine ("enter a sentance");
            string str = Console.ReadLine();
            File.WriteAllText("C:\\Users\\GSSTesterPamGroup\\Desktop\\gu1.txt", str);
            string read = File.ReadAllText("C:\\Users\\GSSTesterPamGroup\\Desktop\\gu1.txt");
            //Console.WriteLine(read);
            int nw = 1, nl = 1, len = 0;
            while(len<=read.Length-1)
            {
                if (read[len] ==' ')
                {
                    nw++;
                }
                else if(read[len]=='\n')
                {
                    nl++;
                }
                len++;
            }
            Console.WriteLine("number of words in the sentance is : "+ nw);
            Console.WriteLine("number of lines in the file is     : "+nl);

        }
    }
        

 }
              

            

        
    

 

