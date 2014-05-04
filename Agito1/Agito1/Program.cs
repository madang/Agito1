using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Task 1:
 * 1.Create a Console Application project.
 * 2.Please make your own ordinary text file. 
 * 3.Words should be separated by spaces and newline characters. 
 * 4.Your program must read the words from that text file into memory,
 * 5.then sort those words (using QuickSort implementation of algorithm that can be found in .NET Base Class Library) 
 * 6.and write the sorted words into a new text file onto the disk.
 */

/* Comments on the task:
 * 
 * 2. and 3. I assume from what is written in 3. that there should be no punctuation 
 * just spaces,newlines and words from alphabetic characters.
 * First I didn't assume that but then after re-reading the task this is how I interpret it.
 */

/* TODO list
 * [DONE] set repo, gitignore all but source
 * [DONE] Copy specs into the source
 * [DONE] Create a file
 * [DONE] Read (safely)
 * Sort
 * Write(safely)
 * --Featuritis begin--
 * Argparse
 * StringBuilder
 */

namespace Agito1
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname = @"D:\Agito\Test\1\ordinary.txt";
            //Read
            string[] words;
            char[] sep = new char[] {' ','\r' ,'\n' };
            try
            {
                words = System.IO.File.ReadAllText(fname).Split(sep); //consumes memory at least four times the size of file (provided file is 1 byte per character);
                                                                    // But we're not writing C here, so let's assume we have the resources
            }
            catch
            {
                Console.WriteLine("Something went wrong with file io");
                return;
            }
            //Sort
            System.Array.Sort(words);
            //Write
            System.IO.File.WriteAllText //(@"D:\Agito\Test\1\out.txt", words);


            
        }
    }
}
