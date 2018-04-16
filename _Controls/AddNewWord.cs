using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Collections.ObjectModel;

namespace VocabularyProNamespace
{
    public partial class AddNewWord : UserControl
    {
        RadioButton[] rbWordTypeArr = null;
        string wordType = "";
        EditListBoxControl editListBoxControl;

        public AddNewWord()
        {
            InitializeComponent();
            AssignRadioButtonArr();
        }

        private void AssignRadioButtonArr()
        {
            this.rbWordTypeArr = new RadioButton[4];

            this.rbWordTypeArr[0] = this.rbAdjective;
            this.rbWordTypeArr[1] = this.rbAdverb;
            this.rbWordTypeArr[2] = this.rbNoun;
            this.rbWordTypeArr[3] = this.rbVerb;
        }

        private bool AddWord()
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(Environment.CurrentDirectory + Constants.XMLFILEPATH);


                if (xmlDoc.DocumentElement.SelectSingleNode(
                    Constants.XMLROOT + "[@Value = '" + this.txtWord.Text.Trim() + "']") != null)
                {
                    MessageBox.Show(this,"[ " + this.txtWord.Text.Trim() + " ] already exists in the list!\r\n" +
                        "If you wish to add more content to this word, you\r\n" +
                        "can do it from Flash Card.", "Info.",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return false;
                }


                XmlElement word = xmlDoc.CreateElement("word");
                XmlAttribute wordIDAttr = xmlDoc.CreateAttribute("ID");
                XmlAttribute wordValueAttr = xmlDoc.CreateAttribute("Value");
                
                // make sure he word is converted to lower case 
                wordValueAttr.Value = this.txtWord.Text.Trim().ToLower();
                wordIDAttr.Value = xmlDoc.DocumentElement.ChildNodes.Count == 0 ? "1" :
                    (Int32.Parse(xmlDoc.DocumentElement.LastChild.Attributes["ID"].Value) + 1).ToString();
                
                word.SetAttributeNode(wordIDAttr);
                word.SetAttributeNode(wordValueAttr);

                XmlElement wordType = xmlDoc.CreateElement("word_type");
                XmlAttribute wordTypeAttr = xmlDoc.CreateAttribute("Value");

                if (this.wordType.Trim() != String.Empty)
                    wordTypeAttr.Value = this.wordType;
                else
                    wordTypeAttr.Value = "adj/verb, etc.?";

                // add the word type attribute
                wordType.SetAttributeNode(wordTypeAttr);

                XmlElement num_correct = xmlDoc.CreateElement("NumCorrect");
                num_correct.InnerText = "0";
                word.AppendChild(num_correct);

                XmlElement total_attempt = xmlDoc.CreateElement("TotalAttempt");
                total_attempt.InnerText = "0";
                word.AppendChild(total_attempt);

                XmlElement meaning = xmlDoc.CreateElement("meaning");

                string[] meaningArr = this.editListBoxControl.GetMeanings();
                
                int mCounter = 1;
                foreach (string m in meaningArr)
                {
                    if (m.Trim().Length > 0) // ignore the last period
                    {
                        // create an inner meaning element
                        XmlElement mean = xmlDoc.CreateElement("m" + mCounter++);

                        mean.InnerText = m.Trim();
                        meaning.AppendChild(mean);
                    }
                }

                wordType.AppendChild(meaning);
                
                XmlElement sentence = xmlDoc.CreateElement("sentence");
                sentence.InnerText = this.txtSentence.Text.Trim();
                wordType.AppendChild(sentence);

                XmlElement synonyms = xmlDoc.CreateElement("synonyms");
                synonyms.InnerText = this.txtSynonyms.Text.Trim();
                wordType.AppendChild(synonyms);

                word.AppendChild(wordType);

                // New XML element inserted into the document
                xmlDoc.DocumentElement.InsertAfter(word,
                                                   xmlDoc.DocumentElement.LastChild);


                xmlDoc.Save(Environment.CurrentDirectory + Constants.XMLFILEPATH);

                ClearControls();

                MessageBox.Show("Word added successfully.", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Couldn't add the word.", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void ClearControls()
        {
            ObservableCollection<DataObject<string>> Meanings = this.editListBoxControl.lbMeaning.ItemsSource as ObservableCollection<DataObject<string>>;
            Meanings.Clear();
            this.editListBoxControl.lbMeaning.UpdateLayout();
            this.txtSentence.Text = "";
            this.txtSynonyms.Text = "";
            this.txtWord.Text = "";
            this.errorProvider1.Clear();
            this.lblError.Visible = false;
            this.rbAdjective.Checked = false;
            this.rbAdverb.Checked = false;
            this.rbNoun.Checked = false;
            this.rbVerb.Checked = false;
        }

        private bool CheckForEmptyEntry()
        {
            int numErrors = 0;

            if (this.txtWord.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.txtWord, "Enter a word!");
                numErrors++;
            }
            else
            {
                this.errorProvider1.SetError(this.txtWord, null);
            }

            if (this.editListBoxControl.GetMeanings().Length <= 0)
            {
                numErrors++;
                this.errorProvider1.SetError(this.elementHost1, "Enter meaning!");
            }
            else
            {
                this.errorProvider1.SetError(this.elementHost1, null);
            }

            if (this.txtSentence.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.txtSentence, "Enter a sentence!");
                numErrors++;
            }
            else
            {
                this.errorProvider1.SetError(this.txtSentence, null);
            }
            if (this.txtSynonyms.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.txtSynonyms, "Enter synonyms!");
                numErrors++;
            }
            else
            {
                this.errorProvider1.SetError(this.txtSynonyms, null);
            }

            if (numErrors > 0)
                return true;
            else
                return false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckForEmptyEntry())
            {
                this.lblError.Text = "* Required";
                this.lblError.ForeColor = System.Drawing.Color.Red;
                this.lblError.Visible = true;
                return;
            }

            if (!this.AddWord())
            {
                ClearControls();
            }
            else
            {
                this.txtWord.Select();
                this.lblError.ForeColor = System.Drawing.Color.ForestGreen;
                this.lblError.Text = "Word added successfully.";
            }

            Form f = Form.ActiveForm;
            ((VocabularyPro)f).DisableUtilControls();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void txtWord_TextChanged(object sender, EventArgs e)
        {
            this.lblError.Visible = false;
        }

        private void rbWordTypes_CheckedChange(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                this.wordType = ((RadioButton)sender).Text.ToLower();
            }
        }

        private void AddNewWord_Load(object sender, EventArgs e)
        {
            // load empty meaning control
            string meaning = "";
            // parse all the meanings
            string[] meaningArr = meaning.Trim().ToString().Split(new char[] { '\n', '\r' },
                StringSplitOptions.RemoveEmptyEntries);

            this.editListBoxControl = new EditListBoxControl(meaningArr);
            this.elementHost1.Child = this.editListBoxControl;
        }
    }
}
