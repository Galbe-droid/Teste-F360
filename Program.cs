using System;
using System.Collections.Generic;
using System.IO;
using Teste_F360___Klingon.Methods;

namespace Teste_F360___Klingon
{
    class Program
    {
        static void Main(string[] args)
        {
            string PathA = @"C:\Users\gabri\source\repos\Teste F360 - Klingon\Teste F360 - Klingon\Files\TranslateA.txt";
            string PathB = @"C:\Users\gabri\source\repos\Teste F360 - Klingon\Teste F360 - Klingon\Files\TranslateB.txt";

            int preposition = Translation.Preposition(PathB);

            Console.WriteLine(preposition);

            Console.WriteLine("====================================================");

            Translation.Verb(PathB);

            Console.WriteLine("====================================================");

            Translation.WordTranslation(PathB);

            Console.WriteLine("====================================================");

            Translation.Numbers(PathB);
        }
    }
}
