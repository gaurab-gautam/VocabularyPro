using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Reflection;
using Microsoft.Office.Interop;
using System.Diagnostics;
using System.Collections;


namespace VocabularyProNamespace
{
    public partial class AddNewWordList : UserControl
    {
        bool fileProcessedSuccessfully = false;
        StringBuilder wordsAlreadyPresent = new StringBuilder();


        public AddNewWordList()
        {
            InitializeComponent();
        }

        private void AddNewWordList_Load(object sender, EventArgs e)
        {
            this.openFileDialog1.FileName = "";

            this.openFileDialog1.Filter = "All files (*.*)| *.*|Text files (*.txt)|*.txt|Excel files (*.xls,*.xlsx)|*.xls*|CSV files (*.csv)|*.csv";
            this.openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            DialogResult res = this.openFileDialog1.ShowDialog();

            if (res != DialogResult.Cancel)
            {
                this.spinningProgress1.Visible = true;
                this.UseWaitCursor = true;
                this.spinningProgress1.Visible = true;
                this.backgroundWorker1.RunWorkerAsync();
                this.UseWaitCursor = false;
            }
        }

        private string[] GetWordsFromExcel()
        {
            Microsoft.Office.Interop.Excel.Application app = null;
            Microsoft.Office.Interop.Excel.Workbook wb = null;
            string[] wordArray = null;
            int rowNumber = 0;

            //try
            {
                app = new Microsoft.Office.Interop.Excel.Application();

                wb = app.Workbooks.Open(this.openFileDialog1.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                        Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                        Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                        Type.Missing, Type.Missing);

                //Assume data are in the first sheet
                Microsoft.Office.Interop.Excel.Worksheet sheet =
                    (Microsoft.Office.Interop.Excel.Worksheet)wb.Sheets.get_Item(1);

                Microsoft.Office.Interop.Excel.Range excelRange = sheet.UsedRange;

                //ignore the header
                wordArray = new string[excelRange.Rows.Count];

                foreach (Microsoft.Office.Interop.Excel.Range row in excelRange.Rows)
                {
                    rowNumber = row.Row;
                    
                    string[] eachRow = GetRange("A" + rowNumber.ToString() + ":C" + rowNumber.ToString() + "", sheet);
                    
                    wordArray[rowNumber - 1] = eachRow[0] + "||\t\t" + eachRow[1] + "||\t\t" + eachRow[2] + "\r\n";
                }                
            }
            //catch 
            //{
            //    MessageBox.Show("Excel File processing failed!\r\n", "File Input Failed", 
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
           // finally
            {
                app.Workbooks.Close();
                wb = null;
                app = null;
                GC.Collect();
            }

            return wordArray;
        }

        string[] ConvertToStringArray(System.Array values)
        {
            // create a new string array
            string[] theArray = new string[values.Length];

            // loop through the 2-D System.Array and populate the 1-D String Array
            for (int i = 1; i <= values.Length; i++)
            {
                if (values.GetValue(1, i) == null)
                    theArray[i - 1] = "";
                else
                    theArray[i - 1] = (string)values.GetValue(1, i).ToString();
            }

            return theArray;
        }

        public string[] GetRange(string range, Microsoft.Office.Interop.Excel.Worksheet excelWorksheet)
        {
            Microsoft.Office.Interop.Excel.Range workingRangeCells =
              excelWorksheet.get_Range(range, Type.Missing);
            
            System.Array array = (System.Array)workingRangeCells.Cells.Value2;
            string[] arrayS = this.ConvertToStringArray(array);

            return arrayS;
        }
           
        private string[] GetWordFromTextFile()
        {
            System.IO.StreamReader fs = null;
            List<string> splits = new List<string>();
            string word = "";
            try
            {
                fs = new StreamReader(this.openFileDialog1.FileName);
                string line = "";

                while (fs.Peek() >= 0)
                {
                    line = fs.ReadLine().TrimEnd();

                    if (fs.Peek() == -1)
                    {
                        if (line[0] == '(')
                        {
                            word += line.Substring(1, line.IndexOf(')') - 1) + "||" + line.Substring(line.IndexOf(')') + 1) + "\r\n";
                        }
                        else
                        {
                            word += line + "\r\n";
                        }
                        splits.Add(word);
                    }

                    if (line.Trim() == "")
                    {
                        // skip all the empty line
                        if ((word == "") && (fs.Peek() != -1))
                            continue;

                        word = word.Substring(0, word.Length - 2) + "\r\n";
                        splits.Add(word);
                        
                        word = "";
                        line = "";
                    }
                    else
                    {
                        if (line[0] == '(')
                        {
                            word += line.Substring(1, line.IndexOf(')') - 1) + "||" + line.Substring(line.IndexOf(')') + 1) + "||";
                        }
                        else
                        {
                            word += line + "||";
                        }
                    }
                }
            }
            catch //(Exception exp)
            {
                //MessageBox.Show("Text File processing failed!\r\n", "File Input Failed", MessageBoxButtons.OK,
                  //  MessageBoxIcon.Error);
                this.fileProcessedSuccessfully = false;
                splits.Clear();
            }
            finally
            {
                fs.Close();
            }

            return splits.ToArray();
        }

        private void AddWordList()
        {
            string[] splits = null;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(Environment.CurrentDirectory + Constants.XMLFILEPATH);
            int lineNumber = 1;

            try
            {
                if (this.openFileDialog1.FileName.Contains(".xls"))
                {
                    splits = GetWordsFromExcel();
                }
                else
                {
                    splits = GetWordFromTextFile();
                }

                foreach (string s in splits)
                {
                    string[] words = s.Split(new string[] { "||", "\n", "\r" }, StringSplitOptions.None);
                    
                    // ignore the words that are already in the vocabulary list
                    if (xmlDoc.DocumentElement.SelectSingleNode(
                        Constants.XMLROOT + "[@Value = '" + words[0].Trim() + "']".Trim()) != null)
                    {
                        //MessageBox.Show(this, "[ " + words[0] + " ] already exists in the list!\r\n", "Info.",
                        //MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (words[1].Trim() != String.Empty)
                        {
                            wordsAlreadyPresent.AppendLine(words[0].Trim() + ";" + words[1].Trim());
                        }
                        else
                        {
                            wordsAlreadyPresent.AppendLine(words[0].Trim());
                        }

                        lineNumber += 1;
                        continue;
                    }

                    XmlElement word = xmlDoc.CreateElement("word");
                    XmlAttribute wordIDAttr = xmlDoc.CreateAttribute("ID");
                    XmlAttribute wordValueAttr = xmlDoc.CreateAttribute("Value");

                    // make sure the word is converted to lower case 
                    wordValueAttr.Value = words[0].Trim().ToLower();
                    wordIDAttr.Value = (xmlDoc.DocumentElement).ChildNodes.Count == 0 ? "1" :
                        (Int32.Parse((xmlDoc.DocumentElement).LastChild.Attributes["ID"].Value) + 1).ToString();

                    word.SetAttributeNode(wordIDAttr);
                    word.SetAttributeNode(wordValueAttr);

                    XmlElement wordType = xmlDoc.CreateElement("word_type");
                    XmlAttribute wordTypeAttr = xmlDoc.CreateAttribute("Value");

                    if (words[1].Trim() != String.Empty)
                        wordTypeAttr.Value = words[1].Trim();
                    else
                        wordTypeAttr.Value = "adj/verb, etc.?";

                    wordType.SetAttributeNode(wordTypeAttr);


                    XmlElement num_correct = xmlDoc.CreateElement("NumCorrect");
                    num_correct.InnerText = "0";
                    word.AppendChild(num_correct);

                    XmlElement total_attempt = xmlDoc.CreateElement("TotalAttempt");
                    total_attempt.InnerText = "0";
                    word.AppendChild(total_attempt);

                    XmlElement meanings = xmlDoc.CreateElement("meaning");

                    // parse all the meanings
                    string[] meaningArr = words[2].Trim().Split(new char[] { '.', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                    int mCounter = 1;
                    foreach (string m in meaningArr)
                    {
                        if (m.Trim().Length > 0) // ignore the last period
                        {
                            XmlElement meaning = xmlDoc.CreateElement("m" + mCounter++);

                            meaning.InnerText = m.Trim();
                            meanings.AppendChild(meaning);
                        }
                    }

                    wordType.AppendChild(meanings);

                    if ((words.Length >= 4) && (words[3].Trim() != String.Empty))
                    {
                        XmlElement sentence = xmlDoc.CreateElement("sentence");
                        sentence.InnerText = words[3].Trim();
                        wordType.AppendChild(sentence);
                    }
                    else
                    {
                        XmlElement sentence = xmlDoc.CreateElement("sentence");
                        sentence.InnerText = "NOT ASSIGNED";
                        wordType.AppendChild(sentence);
                    }

                    if ((words.Length >= 5) && (words[4].Trim() != String.Empty))
                    {
                        XmlElement synonyms = xmlDoc.CreateElement("synonyms");
                        synonyms.InnerText = words[4].Trim();
                        wordType.AppendChild(synonyms);
                    }
                    else
                    {
                        XmlElement synonyms = xmlDoc.CreateElement("synonyms");
                        synonyms.InnerText = "NOT ASSIGNED";
                        wordType.AppendChild(synonyms);
                    }

                    word.AppendChild(wordType);

                    // New XML element inserted into the document
                    xmlDoc.DocumentElement.InsertAfter(word,
                                                       xmlDoc.DocumentElement.LastChild);

                    lineNumber += 1;
                    this.fileProcessedSuccessfully = true;
                }

                xmlDoc.Save(Environment.CurrentDirectory + Constants.XMLFILEPATH);
            }
            catch
            {
                string msg = "File processing failed!" +
                    "\r\n\r\nFile Name: " + this.openFileDialog1.FileName;
                    
                
                MessageBox.Show(msg, "File Input Processed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.fileProcessedSuccessfully = false;
            }
            finally
            {
                this.UseWaitCursor = false;
                xmlDoc = null;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            AddWordList();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.spinningProgress1.Visible = false;
            
            if (this.fileProcessedSuccessfully)
                MessageBox.Show("File processing complete!", "File Process Successful", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            this.fileProcessedSuccessfully = false;
            
            Form f = Form.ActiveForm;
            ((VocabularyPro)f).DisableUtilControls();

            if (this.wordsAlreadyPresent.Length > 0)
            {
                InputFileLoadResult fileLoadResult = new InputFileLoadResult(this.wordsAlreadyPresent);
                fileLoadResult.ShowDialog();
            }
        }
    }
}
