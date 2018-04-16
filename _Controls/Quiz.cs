using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;

namespace VocabularyProNamespace
{
    public partial class Quiz : UserControl
    {
        int answerIndex = 0;
        string answer = "";
        StringBuilder answerIndices = null;
        StringBuilder quizQuestion = null;
        StringBuilder userResponse = null;
        int quizNumber = 1;
        int numQuizQuestions = 0;
        WordUtil wordUtil = null;
        string wordType = "";
        int wordIndex = -1;

        public Quiz(int numQuestions)
        {
            InitializeComponent();
            this.numQuizQuestions = numQuestions;
            this.wordUtil = new WordUtil();
        }

        private void Quiz_Load(object sender, EventArgs e)
        {
            //make sure that the number of quiz questions are at least equal or more that the user selection
            if (this.wordUtil.TotalWords < this.numQuizQuestions)
            {
                this.numQuizQuestions = this.wordUtil.TotalWords;
                MessageBox.Show("NOT enough words to create selected " +
                    "number of quiz questions!\r\n" +
                    "Please add more words to create your vocabulary list.\r\n" +
                    "Only " + this.wordUtil.TotalWords.ToString() + " words are added till now.",
                    "Not Enough Words", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            this.answerIndices = new StringBuilder();
            this.quizQuestion = new StringBuilder();
            this.userResponse = new StringBuilder();

            GetWord();
            this.lblPage.Visible = true;
            this.btnNext.Enabled = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                // currentwordIndex is 0-based, while word index is 1-based
                this.wordUtil.CurrentWordIndex = this.wordIndex;
                
                // switch the correct answer index to evaluate user response
                switch (this.answerIndex)
                {
                    // if first choice is the correct answer
                    case 0:
                        // if user answered it correctly
                        if (this.radioButton1.Checked)
                        {

                            // set the number of correct answers for the word
                            this.wordUtil.SetNumCorrectAnswers();

                            // user response : correct answer
                            this.userResponse.Append("0:0;");
                        }
                        else
                        {
                            // incorrect answer
                            if (radioButton2.Checked)
                                this.userResponse.Append("1:0;");
                            else if (radioButton3.Checked)
                                this.userResponse.Append("2:0;");
                            else if (radioButton4.Checked)
                                this.userResponse.Append("3:0;");
                        }

                        // set the number of total attempts for the word
                        this.wordUtil.SetTotalQuestionAttempted();

                        break;
                    case 1:
                        if (this.radioButton2.Checked)
                        {
                            // get the number of correct answers for the word
                            this.wordUtil.SetNumCorrectAnswers();

                            this.userResponse.Append("1:1;");
                        }
                        else
                        {
                            if (radioButton1.Checked)
                                this.userResponse.Append("0:1;");
                            else if (radioButton3.Checked)
                                this.userResponse.Append("2:1;");
                            else if (radioButton4.Checked)
                                this.userResponse.Append("3:1;");
                        }

                        // set the number of total attempts for the word
                        this.wordUtil.SetTotalQuestionAttempted();

                        break;
                    case 2:
                        if (this.radioButton3.Checked)
                        {
                            this.wordUtil.SetNumCorrectAnswers();
                            this.userResponse.Append("2:2;");
                        }
                        else
                        {
                            if (radioButton1.Checked)
                                this.userResponse.Append("0:2;");
                            else if (radioButton2.Checked)
                                this.userResponse.Append("1:2;");
                            else if (radioButton4.Checked)
                                this.userResponse.Append("3:2;");
                        }

                        // set the number of total attempts for the word
                        this.wordUtil.SetTotalQuestionAttempted();

                        break;
                    case 3:
                        if (this.radioButton4.Checked)
                        {
                            // set the number of correct answers for the word
                            this.wordUtil.SetNumCorrectAnswers();
                            this.userResponse.Append("3:3;");

                        }
                        else
                        {
                            if (radioButton1.Checked)
                                this.userResponse.Append("0:3;");
                            else if (radioButton2.Checked)
                                this.userResponse.Append("1:3;");
                            else if (radioButton3.Checked)
                                this.userResponse.Append("2:3;");
                        }

                        // set the number of total attempts for the word
                        this.wordUtil.SetTotalQuestionAttempted();

                        break;
                }
            }
            catch
            {
                MessageBox.Show("Error on setting quiz result");
            }

            GetWord();
            this.btnNext.Enabled = false;
            this.radioButton1.Checked = false;
            this.radioButton2.Checked = false;
            this.radioButton3.Checked = false;
            this.radioButton4.Checked = false;
        }

        private void GetWord()
        {
            System.Random rNum = new System.Random();
            int choiceNum1 = -1;
            int choiceNum2 = -1;
            int choiceNum3 = -1;
            //int counter = 0;

            while (true)
            {
                // When quiz finishes, load the result and review of the quiz
                if (this.quizNumber > this.numQuizQuestions)
                {
                    this.quizNumber = 1;
                    this.gbResult.Visible = true;
                    Result res = new Result(this.userResponse.ToString());
                    this.gbResult.Controls.Clear();
                    this.gbResult.Controls.Add(res);

                    Review rv = new Review(this.quizQuestion.ToString(), this.userResponse.ToString());
                    this.gbQuestions.Controls.Clear();
                    this.gbQuestions.Controls.Add(rv);

                    return;
                }

                // word index to choose for question
                this.wordIndex = rNum.Next(0, this.wordUtil.TotalWords);
                this.wordUtil.CurrentWordIndex = wordIndex;
                
                // if word is already asked, ignore and get another word
                // answer indices contains indices of words already questioned
                if (this.answerIndices.ToString().Contains(this.wordUtil.CurrentWordIndex.ToString() + ";"))
                {
                    //counter++;
                    continue;
                }

                // correct answer index
                this.answerIndex = rNum.Next(0, 4);

                // get three other incorrect choice indices
                while (true)
                {
                    choiceNum1 = rNum.Next(0, this.wordUtil.TotalWords);
                    choiceNum2 = rNum.Next(0, this.wordUtil.TotalWords);
                    choiceNum3 = rNum.Next(0, this.wordUtil.TotalWords);

                    if ((choiceNum1 != this.wordUtil.CurrentWordIndex) &&
                        (choiceNum2 != this.wordUtil.CurrentWordIndex) &&
                        (choiceNum3 != this.wordUtil.CurrentWordIndex) &
                        (choiceNum1 != choiceNum2) &&
                        (choiceNum2 != choiceNum3) &&
                        (choiceNum3 != choiceNum1))
                        break;
                }

                break;
            }

            string[] questionContents = GetQuestionWordAndContents();


            // assign all the values to quiz control
            // set the word
            this.lblWord.Text = questionContents[0];

            // set the answer/meaning
            this.answer = questionContents[1];

            // set the type of word
            this.wordType = questionContents[2];

            if (Enum.IsDefined(typeof(Constants.WordType), this.wordType.ToUpper()))
                this.lblWordType.Text = "(" + this.wordType + ")";
            else
                this.lblWordType.Text = "";

            // string collection of correct answer indices for choosing exclusive answer choices
            this.answerIndices.Append(this.wordUtil.CurrentWordIndex.ToString() + ";");

            string choice1 = null;
            string choice2 = null;
            string choice3 = null;

            // all the choice indices are 0-based, while word-index is 1-based
            // get the 1st incorrect choice
            choice1 = GetIncorrectAnswerChoice(choiceNum1);

            // get the 2nd incorrect choice
            choice2 = GetIncorrectAnswerChoice(choiceNum2);

            // get the 3rd incorrect choice
            choice3 = GetIncorrectAnswerChoice(choiceNum3);


            // populate answer choices for the question
            switch (this.answerIndex)
            {
                // correct answer is in the first choice
                case 0:
                    this.radioButton1.Text = this.answer.Trim();
                    this.radioButton2.Text = choice1.Trim();
                    this.radioButton3.Text = choice2.Trim();
                    this.radioButton4.Text = choice3.Trim();
                    break;

                // correct answer is in the second choice
                case 1:
                    this.radioButton2.Text = this.answer.Trim();
                    this.radioButton1.Text = choice1.Trim();
                    this.radioButton3.Text = choice2.Trim();
                    this.radioButton4.Text = choice3.Trim();
                    break;

                // correct answer is in the third choice
                case 2:
                    this.radioButton3.Text = this.answer.Trim();
                    this.radioButton2.Text = choice1.Trim();
                    this.radioButton1.Text = choice2.Trim();
                    this.radioButton4.Text = choice3.Trim();
                    break;

                // correct answer is in the fourth choice
                case 3:
                    this.radioButton4.Text = this.answer.Trim();
                    this.radioButton2.Text = choice1.Trim();
                    this.radioButton3.Text = choice2.Trim();
                    this.radioButton1.Text = choice3.Trim();
                    break;
            }

            // string collection of quiz questions prepared for result and review
            this.quizQuestion.Append(this.lblWord.Text + "->" + this.radioButton1.Text + "&&" + this.radioButton2.Text +
                "&&" + this.radioButton3.Text + "&&" + this.radioButton4.Text + ";");


            this.lblPage.Text = "[ " + this.quizNumber.ToString() + " of " + this.numQuizQuestions.ToString() + " .]";
            this.quizNumber += 1;
        }

        string[] GetQuestionWordAndContents()
        {
            // get the word with contents
            WordContents wc = this.wordUtil.GetWordContents();
            System.Random randomNum = new System.Random();

            int rNum = randomNum.Next(0, wc.WordAttr.Count());

            StringBuilder str = new StringBuilder();

            // pick the word type randomly
            WordContents.WordAttribute wAttr = wc.WordAttr[rNum];

            // get all the meanings 
            foreach (string m in wAttr.Meanings)
            {
                str.AppendLine(m.Trim());
            }

            string[] meanings = str.ToString().Trim().Split(new char[] { '\r', '\n' },
                    StringSplitOptions.RemoveEmptyEntries);

            // randomize the meaning pick
            rNum = randomNum.Next(0, meanings.Count());

            // now finalize on word and its attributes and return the value
            return (new string[] { wc.Word, meanings[rNum], wAttr.WordType });
        }

        string GetIncorrectAnswerChoice(int choiceIndex)
        {
            // set the index for choice
            this.wordUtil.CurrentWordIndex = choiceIndex;

            // get the word with contents
            WordContents wc = this.wordUtil.GetWordContents();
            System.Random randomNum = new System.Random();

            int rNum = randomNum.Next(0, wc.WordAttr.Count());
            StringBuilder str = new StringBuilder();

            // pick the word type randomly
            WordContents.WordAttribute wAttr = wc.WordAttr[rNum];

            // get all the meanings 
            foreach (string m in wAttr.Meanings)
            {
                str.AppendLine(m.Trim());
            }

            string[] meanings = str.ToString().Trim().Split(new char[] { '\r', '\n' },
                    StringSplitOptions.RemoveEmptyEntries);

            // randomize the meaning pick
            rNum = randomNum.Next(0, meanings.Count());

            // now finalize on meaning to return
            return meanings[rNum];
        }

        private void answer_Clicked(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                this.btnNext.Enabled = true;
        }

    }
}
