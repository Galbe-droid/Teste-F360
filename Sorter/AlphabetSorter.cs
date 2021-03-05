using System;
using System.Collections.Generic;
using System.Text;

namespace Teste_F360___Klingon.Sorter
{
    class AlphabetSorter
    {
        public static int CompareStrings(string a, string b)
        {
            var KlingomAlphabet = "kbwrqdnfxjmlvhtcgzps";
            if (KlingomAlphabet.IndexOf(a[0]) < KlingomAlphabet.IndexOf(b[0]))
                return -1;

            return KlingomAlphabet.IndexOf(a[0]) >
            KlingomAlphabet.IndexOf(b[0]) ? 1 : 0;
        }
    }
}
