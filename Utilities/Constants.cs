using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VocabularyProNamespace
{
    public static class Constants
    {
        public static string XMLROOT
        {
            get
            {
                return "/word_table/word";
            }
        }

        public static string XMLFILEPATH
        {
            get
            {
                return @"\Data\WordList.xml";
            }
        }

        public  enum ReportChoices
        {
            ALL = 0,
            QUIZZED = 1,
            MOST_INCORRECTLY_ANSWERED = 2
        };

        public enum WordType
        {
            ADJECTIVE = 0,
            ADVERB = 1,
            NOUN = 2,
            VERB = 3,
            NOTDEFINED = -1
        };
    }

}
