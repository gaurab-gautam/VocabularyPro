using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.XPath;
using System.Threading;
using System.IO;

namespace VocabularyProNamespace
{
    public class WordUtil
    {
        XmlDocument xmlDoc = null;
        private int currentWordIndex = 0;
        private int TOTALWORDS = -1;
        XPathNodeIterator nodeIter = null;
        XPathNavigator nav = null;
        static string filepath = Environment.CurrentDirectory + Constants.XMLFILEPATH;
        
        public WordUtil()
        {
            //DataEncryptionAndDecryption.SymmetricDecryptFile();
            LoadWords();
            //DataEncryptionAndDecryption.SymmetricEncryptFile();
        }


        /// <summary>
        /// Gets or sets the current word index.
        /// </summary>
        public int CurrentWordIndex
        {
            get
            {
                return this.currentWordIndex;
            }

            set
            {
                this.currentWordIndex = value;
            }
        }

        /// <summary>
        /// Gets the total words in the vocabulary list
        /// </summary>
        public int TotalWords
        {
            get
            {
                return this.TOTALWORDS;
            }

            private set
            {
                this.TOTALWORDS = value;
            }
        }

        public static int TotalWordsCount()
        {
            //DataEncryptionAndDecryption.SymmetricDecryptFile();
            XPathDocument xDoc = new XPathDocument(Environment.CurrentDirectory + Constants.XMLFILEPATH);
            XPathNavigator nav = xDoc.CreateNavigator();
            XPathNodeIterator xIter = nav.Select(Constants.XMLROOT);
            //DataEncryptionAndDecryption.SymmetricEncryptFile();
            
            return xIter.Count;
        }

        public static bool IsWordListEmpty()
        {
            //DataEncryptionAndDecryption.SymmetricDecryptFile();
            XPathDocument xDoc = new XPathDocument(Environment.CurrentDirectory + Constants.XMLFILEPATH);
            XPathNavigator nav = xDoc.CreateNavigator();
            XPathNodeIterator xIter = nav.Select(Constants.XMLROOT);
            //DataEncryptionAndDecryption.SymmetricEncryptFile();

            if (xIter.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckForMinimumWordsCount()
        {
            //DataEncryptionAndDecryption.SymmetricDecryptFile();
            XPathDocument xDoc = new XPathDocument(Environment.CurrentDirectory + Constants.XMLFILEPATH);
            XPathNavigator nav = xDoc.CreateNavigator();
            XPathNodeIterator xIter = nav.Select(Constants.XMLROOT);
            //DataEncryptionAndDecryption.SymmetricEncryptFile();

            if (xIter.Count < 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private  void LoadWords()
        {
            // open and load XML file
            xmlDoc = new XmlDocument();
            xmlDoc.Load(filepath);
            //create XML navigator
            nav = xmlDoc.CreateNavigator();

            // sorts and selects all words in the vocabulary list
            SelectAllWords();
        }
        private void SelectAllWords()
        {
            XPathExpression xExp = nav.Compile(Constants.XMLROOT);
            //XPathExpression sortExp = nav.Compile("@Value");
            xExp.AddSort("@Value", XmlSortOrder.Ascending, XmlCaseOrder.None, "", XmlDataType.Text);

            // select all words and move iterator to the root
            this.nodeIter = this.nav.Select(xExp);

            this.TOTALWORDS = this.nodeIter.Count;

        }

        private void MoveIteratorToIndex(int index)
        {
            // get all words and point to the root
            this.SelectAllWords();
            
            // move along until the given index
            while (this.nodeIter.MoveNext())
            {
                if (this.nodeIter.CurrentPosition == index)
                {
                    break;
                }
            }
        }

        /// <summary>
        /// Always returns 1-based index
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public string GetFirstIndexOfWordStartingWithChar(char c)
        {
            XPathExpression xExp = this.nav.Compile(Constants.XMLROOT + "/@Value[starts-with(.,'" + c + "')]");

            xExp.AddSort("@Value", XmlSortOrder.Ascending, XmlCaseOrder.None, "", XmlDataType.Text);

            // select all the words starting with the given letter
            this.nodeIter = this.nav.Select(xExp);

            // move to the first attribute word node that contains the letter
            this.nodeIter.MoveNext();
            // move to its parent word node
            this.nodeIter.Current.MoveToParent();

            string wordID = this.nodeIter.Current.GetAttribute("ID", "");

            // Select all words and position iterator to the root
            this.SelectAllWords();

            string index = null;

            // move along until two IDs match
            while (this.nodeIter.MoveNext())
            {
                if (this.nodeIter.Current.GetAttribute("ID", "") == wordID)
                {
                    index = this.nodeIter.CurrentPosition.ToString();
                    break;
                }
            }

            return index;
        }

        /// <summary>
        /// Detete the word, given as an argument, from the xml file
        /// </summary>
        /// <param name="word">word to delete as string</param>
        /// <returns>true on success; false otherwise</returns>
        public bool DeleteWord(string word)
        {
            try
            {
                XmlNode root = this.xmlDoc.DocumentElement;
                XmlNode node = root.SelectSingleNode("descendant::word[@Value='" +
                    word + "']");

                node.ParentNode.RemoveChild(node);
                this.xmlDoc.Save(Environment.CurrentDirectory + Constants.XMLFILEPATH);

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Returns the word and its contents as WordContent type structure
        /// </summary>
        /// <returns>WordContent structure</returns>
        public WordContents GetWordContents()
        {
            WordContents wc = new WordContents();

            if (this.TOTALWORDS > 0)
            {
                // currentwordIndex is 0-based, while word index is 1-based
                MoveIteratorToIndex(this.currentWordIndex + 1);

                // get the word and id
                wc.Word = this.nodeIter.Current.GetAttribute("Value", "");
                wc.ID = this.nodeIter.Current.GetAttribute("ID", "");

                // get the numcorrect and totalattempt
                this.nodeIter.Current.MoveToChild("NumCorrect", "");
                wc.NumCorrect = this.nodeIter.Current.Value;
                this.nodeIter.Current.MoveToNext();
                wc.TotalAttempt = this.nodeIter.Current.Value;
                this.nodeIter.Current.MoveToParent();
                
                // get all the word types, synonyms and sentences 
                this.nodeIter = this.nodeIter.Current.SelectChildren("word_type", "");
                int i = 0;
                
                wc.WordAttr = new WordContents.WordAttribute[nodeIter.Count];
                
                //get word type through sentence
                while (nodeIter.MoveNext())
                {
                    // get the word type
                    wc.WordAttr[i].WordType = this.nodeIter.Current.GetAttribute("Value", "");
                    
                    // get the meaning
                    this.nodeIter.Current.MoveToChild("meaning", "");
                    
                    // if there are multiple meanings, get one at a time
                    XPathNodeIterator clone = this.nodeIter.Current.SelectChildren(XPathNodeType.Element);
                    int j = 0;

                    wc.WordAttr[i].Meanings = new string[clone.Count];

                    while (clone.MoveNext())
                    {
                        wc.WordAttr[i].Meanings[j++] = clone.Current.Value;
                    }
                    
                    // move up to word node again (up from meaning to word_type)
                    this.nodeIter.Current.MoveToParent();

                    // get the synonym(s)
                    this.nodeIter.Current.MoveToChild("synonyms", "");
                    wc.WordAttr[i].Synonyms = this.nodeIter.Current.Value;
                    this.nodeIter.Current.MoveToParent();

                    // get the sentence(s)
                    this.nodeIter.Current.MoveToChild("sentence", "");
                    wc.WordAttr[i].Sentence = this.nodeIter.Current.Value;
                    
                    // reset the iterator back to <word_type> node
                    this.nodeIter.Current.MoveToParent();


                    i += 1;
                }

                

                /*System.Windows.Forms.MessageBox.Show("Word  : " + i + " : " + wc.Word + "\r\n" +
                        "Meaning : " + i + " : " + wAttr[i].Meanings[0] + "\r\n" +
                        "Synonyms : " + i + " : " + wAttr[i].Synonyms + "\r\n" +
                        "Sentence : " + i + " : " + wAttr[i].Sentence + "\r\n" +
                        "Type : : " + i + " : " + wAttr[i].WordType + "\r\n"
                        );
                 
                 */

            }
                  
            return wc;
        }

        public WordContents GetWordContents(string word)
        {
            int index = GetWordIndex(word);

            if (index == -1)
                throw (new NullReferenceException());

            this.currentWordIndex = index;

            return GetWordContents();
        }
        
        /// <summary>
        /// Returns an array of strings contain word only
        /// </summary>
        /// <returns>
        /// An array of strings contain word only
        /// </returns>
        public string[] GetAllWords()
        {
            string [] words = new string [this.TotalWords];
            int i = 0;

            this.nodeIter.Current.MoveToRoot();

            while (this.nodeIter.MoveNext())
            {
                words[i++] = this.nodeIter.Current.GetAttribute("Value", "");
            }

            return words;
        }

        public int GetWordIndex(string word)
        {
            if (this.nodeIter.Current.GetAttribute("Value", "") == word)
                return this.currentWordIndex;

            // select all the word to search
            this.SelectAllWords();

            // move along until word is found
            while (this.nodeIter.MoveNext())
            {
                if (this.nodeIter.Current.GetAttribute("Value", "") == word)
                {
                    return (this.nodeIter.CurrentPosition - 1);
                }
            }

            // word not found
            return -1;
        }

        public string GetWordByIndex(int index)
        {
            this.SelectAllWords();

            // move along until word is found
            while (this.nodeIter.MoveNext())
            {
                if (this.nodeIter.CurrentPosition == (index + 1))
                {
                    return (this.nodeIter.Current.GetAttribute("Value", ""));
                }
            }

            // word not found
            return null;
        }

        /// <summary>
        /// Delete all the words in the vocabulary list
        /// </summary>
        /// <returns>true on success; false otherwise</returns>
        public bool DeleteAll()
        {
            return false;
        }

        public bool DeleteWordTypeNode(string word, string wordType)
        {
            try
            {
                XmlNode root = this.xmlDoc.DocumentElement;
                XmlNode node = root.SelectSingleNode("/word_table/word[@Value='" +
                    word + "']/word_type[@Value='" + wordType + "']");

                node.ParentNode.RemoveChild(node);
                this.xmlDoc.Save(Environment.CurrentDirectory + Constants.XMLFILEPATH);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public void SetNumCorrectAnswers()
        {
            XmlElement elem = null;

            MoveIteratorToIndex(this.currentWordIndex);
            // set the number of correct answers for the word
            this.nodeIter.Current.MoveToChild("NumCorrect", "");
            elem = (XmlElement)((IHasXmlNode)this.nodeIter.Current).GetNode();
            elem.InnerText = (Int32.Parse(elem.InnerText) + 1).ToString();
            this.nodeIter.Current.MoveToParent();
        }

        public void SetTotalQuestionAttempted()
        {
            XmlElement elem = null;

            MoveIteratorToIndex(this.currentWordIndex);
            this.nodeIter.Current.MoveToChild("TotalAttempt", "");
            elem = (XmlElement)((IHasXmlNode)this.nodeIter.Current).GetNode();
            elem.InnerText = (Int32.Parse(elem.InnerText) + 1).ToString();

            // save after setting the values
            xmlDoc.Save(Environment.CurrentDirectory + Constants.XMLFILEPATH);
        }

        public void AddNewWordType(string word, string meanings, string synonyms, string sentence, string wordtype)
        {
            XmlNode root = this.xmlDoc.DocumentElement;
            XmlNode node = root.SelectSingleNode("/word_table/word[@Value='" +
                word.Trim() + "']");

            XmlElement newWordType = this.xmlDoc.CreateElement("word_type");
            XmlAttribute newWordTypeAttr = this.xmlDoc.CreateAttribute("Value");

            newWordTypeAttr.Value = wordtype;
            newWordType.SetAttributeNode(newWordTypeAttr);

            XmlElement meaningElem = xmlDoc.CreateElement("meaning");

            string[] meaningArr = meanings.Split(new char[] { '\r', '\n' },
                StringSplitOptions.RemoveEmptyEntries);
            
            int mCounter = 1;
            foreach (string m in meaningArr)
            {
                if (m.Trim().Length > 0) // ignore the last period
                {
                    XmlElement mean = xmlDoc.CreateElement("m" + mCounter++);

                    mean.InnerText = m.Trim();
                    meaningElem.AppendChild(mean);
                }
            }

            newWordType.AppendChild(meaningElem);

            XmlElement syno = xmlDoc.CreateElement("synonyms");
            syno.InnerText = synonyms.Trim();
            newWordType.AppendChild(syno);

            XmlElement sent = xmlDoc.CreateElement("sentence");
            sent.InnerText = sentence.Trim();
            newWordType.AppendChild(sent);

            node.AppendChild(newWordType);

            this.xmlDoc.Save(Environment.CurrentDirectory + Constants.XMLFILEPATH);
        }
    }
}
