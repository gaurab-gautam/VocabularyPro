using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VocabularyProNamespace
{
    public static class WordType
    {
        public static int GetType(string word)
        {
            if (word == "adjective")
                return 0;
            else if (word == "adverb")
                return 1;
            else if (word == "noun")
                return 2;
            else if (word == "phrase")
                return 3;
            else if (word == "verb")
                return 4;
            else
                return -1;
        }
    }
}
