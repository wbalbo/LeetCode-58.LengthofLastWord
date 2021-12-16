using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58.Length_of_Last_Word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //change the values as you wish.
            string word = "Hello World";
            string wordTwo = "   fly me   to   the moon  ";
            string wordThree = "luffy is still joyboy";
            string wordFour = "luffyisstilljoyboy";

            Console.WriteLine("Length: " + LengthOfLastWord(word));
            Console.ReadKey();
        }

        static int LengthOfLastWord(string word)
        {
            if (word.LastIndexOf(' ') == -1)
                return word.Length;

            word = word.TrimEnd(' ');
            var index = word.LastIndexOf(' ');
            string pedaco = word.Substring(index);
            return pedaco.Trim().Length;
        }
    }
}
