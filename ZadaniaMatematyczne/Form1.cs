using System;

namespace ZadaniaMatematyczne
{
    public partial class Form1 : Form
    {
        private string answer;
        private string divAnswer;
        int points = 0;
        int attempts = 0;
        CalculateRandomTask calculateMultipTask;
        CalculateRandomTask calculateDivTask;
        public Form1()
        {
            InitializeComponent();
            calculateMultipTask = new CalculateRandomTask();
            calculateDivTask = new CalculateRandomTask();
            DisplayMultiplierTask();
            DisplayDivideTask();
            DisplayPoints();
            DisplayAttempts();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckMultiplierTask();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckDivAnswer();
        }

        void DisplayMultiplierTask()
        {
            calculateMultipTask.RandomTask();
            label1.Text = calculateMultipTask.num1 + " x " + calculateMultipTask.num2 + " = ";
        }

        void DisplayDivideTask()
        {
            calculateDivTask.RandomTask();
            label4.Text = calculateDivTask.result + " / " + calculateDivTask.num2 + " = ";
        }
        void CheckMultiplierTask()
        {
            answer = textBox1.Text;
            NumberOfAttempts(1);
            if (answer == calculateMultipTask.result.ToString())
            {
                DisplayMultiplierTask();
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
                ScorePoints(1);
            }
            else
            {
                textBox1.ForeColor = Color.Red;
                ScorePoints(-1);
            }
        }

        void CheckDivAnswer()
        {
            divAnswer = textBox2.Text;
            NumberOfAttempts(1);
            if (divAnswer == calculateDivTask.num1.ToString())
            {
                DisplayDivideTask();
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
                ScorePoints(1);
            }
            else
            {
                textBox2.ForeColor = Color.Red;
                ScorePoints(-1);
            }
        }

        void ScorePoints(int addScorePoint)
        {
            points += addScorePoint;
            DisplayPoints();
        }

        void DisplayPoints()
        {
            scorePointsLabel.Text = points.ToString();
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


    }
}