using System;
using System.Xml.Linq;
using System.Linq;
using System.Diagnostics;

namespace ZadaniaMatematyczne
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        private string answer;
        int correctAnswers = 0;
        int wrongAnswers = 0;
        int attempts = 0;
        int result;
        string chosedTask;
        CalculateRandomTask calculateMultipTask;

        public Form1()
        {
            InitializeComponent();
            SetTask();
            DisplayPoints();
            DisplayAttempts();
            //dataGridView1.Rows.Add(new string[] { "aaccc", "bb"});
            //dataGridView1.Rows.Add(new string[] { "hhhh", "bb" });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckAnswer();
        }
        void SetTask()
        {
            calculateMultipTask = new CalculateRandomTask();
            int roleOperation = rand.Next(0, 2);
            result  = calculateMultipTask.RandomTask(roleOperation);
            chosedTask = calculateMultipTask.selectedOperation;
            DisplayTask();
        }

        void DisplayTask()
        {
            if (chosedTask == calculateMultipTask.caindOfTask[0])
            {
                label1.Text = calculateMultipTask.num1 + " x " + calculateMultipTask.num2 + " = ";
            }
            else
            {
                label1.Text = (calculateMultipTask.num1 * calculateMultipTask.num2).ToString() 
                    + " / " + calculateMultipTask.num2 + " = ";
            }
        }

        void CheckAnswer()
        {
            answer = textBox1.Text;
            NumberOfAttempts(1);
            if (answer == result.ToString())
            {
                SetTask();
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
                CorrectAnswers(1);
            }
            else if (answer == "")
            {
                MessageBox.Show("Podaj wynik działania w oknie");
            }
            else
            {
                textBox1.ForeColor = Color.Red;
                WrongAnswers(1);
            }
        }

        void CorrectAnswers(int addScorePoint)
        {
            correctAnswers += addScorePoint;
            DisplayPoints();
        }

        void WrongAnswers(int addScorePoint)
        {
            wrongAnswers += addScorePoint;
            DisplayPoints();
        }

        void DisplayPoints()
        {
            correctPointsLabel.Text = correctAnswers.ToString();
            wrongPointsLabel.Text = wrongAnswers.ToString();
        }

        void NumberOfAttempts(int attempt)
        {
            attempts += attempt;
            DisplayAttempts();
        }

        void DisplayAttempts()
        {
            labelOfAttempts.Text = attempts.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Proszę wprowadzać tylko cyfry");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }
    }
}