using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CountCharsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //var countedCharacters = CountCharsWithLambda("da_vinci_code.txt");
            var countedCharacters = CountCharsWithQuery("da_vinci_code.txt");

            Console.ReadLine();
        }

        //private static Dictionary<string, int> CountCharsWithLambda(string filePath)
        //{
        //    var fileContent = File.ReadAllText(filePath);
        //    var countedCharacters = new Dictionary<string, int>();

        //    countedCharacters.Add("0", fileContent.Count(character => character == '0'));
        //    countedCharacters.Add("1", fileContent.Count(character => character == '1'));
        //    countedCharacters.Add("x", fileContent.Count(character => character == 'x'));
        //    return countedCharacters;
        //}

        private static Dictionary<string, int> CountCharsWithQuery(string filePath)
        {
            var fileContent = File.ReadAllText(filePath);
            var countedCharacters = new Dictionary<string, int>();

            countedCharacters = from 
        }
    }
}
