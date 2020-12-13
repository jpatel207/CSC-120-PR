using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        System.Random random = new System.Random();
        Random rand = new Random();

        //public variables that need to be accessible to different event handlers
        public int num;
        public int num2;
        public string colorBoxColorName;
        public string expressionColor;
        public string expressionOperator;
        public int scoreCount;


        public Form1() //class constructor
        {
            InitializeComponent();

            //box with color and number
            num = random.Next(0, 9);
            this.ColorBox.Text = num.ToString();
            Color[] c = { Color.Blue, Color.Red, Color.Green, Color.Gray };
            Color boxColor = c[rand.Next(0, c.Length)];
            colorBoxColorName = boxColor.Name;
            this.ColorBox.BackColor = boxColor;
            this.ColorBox.ForeColor = Color.White;

            //box that shows boolean expression to compare with ColorBox
            string[] color = { "Blue", "Red", "Green", "Gray" };
            num2 = random.Next(0, 9);
            string[] randomOperator = { "&&", "||" };
            expressionColor = color[rand.Next(0, color.Length)];
            expressionOperator = randomOperator[rand.Next(0, randomOperator.Length)];
            string booleanExpressionString = expressionColor + " " + expressionOperator + " " + num2.ToString();
            this.BooleanExpression.Text = booleanExpressionString;

            this.ScoreLabel.Text = "Score = " + scoreCount.ToString();

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            //used drag and drop method of creating buttons before help session tutorial, so I kept that instead of loading buttons using code here
            //this section contains the properties for components that need to be adjusted when form is loaded initially

            //box "button" that shows number and color
            //int num = random.Next(0, 9);
            //this.ColorBox.Text = num.ToString();
            //Random rand = new Random();
            //Color[] c = { Color.Blue, Color.Red, Color.Green, Color.Gray };
            //Color boxColor = c[rand.Next(0, c.Length)];
            //this.ColorBox.BackColor = boxColor;
            //this.ColorBox.ForeColor = Color.White;

            //box that shows boolean expression to compare with ColorBox
            //string[] color = { "blue", "red", "green", "gray" };
            //int num2 = random.next(0, 9);
            //string[] randomoperator = { "&&", "||" };
            //string expressioncolor = color[rand.next(0, color.length)];
            //expressionoperator = randomoperator[rand.next(0, randomoperator.length)];
            //string booleanexpressionstring = expressioncolor + " " + expressionoperator + " " + num2.tostring();
            //this.booleanexpression.text = booleanexpressionstring;

        }

        private void TrueButton_Click(object sender, EventArgs e)
        {
            int trueCount = 0;
            MessageBox.Show(expressionOperator);
            if (num == num2)
            {
                trueCount += 1;
            }
            if (colorBoxColorName == expressionColor)
            {
                trueCount += 1;
            }
            if (expressionOperator == "||")
            {
                if (trueCount >= 1)
                {
                    scoreCount += 1;
                    //add function or code to start next round
                }
                else
                {
                    MessageBox.Show("Game Over. Please restart.");
                    scoreCount = 0;
                }
            }
            if (expressionOperator == "&&")
            {
                if (trueCount == 2)
                {
                    scoreCount += 1;
                    //add function or code to start next round
                }
                else
                {
                    MessageBox.Show("Game Over. Please restart.");
                    scoreCount = 0;
                }
            }
        }

        private void FalseButton_Click(object sender, EventArgs e)
        {
            int falseCount = 0;
            MessageBox.Show(expressionOperator);
            if (num == num2)
            {
                falseCount += 1;
            }
            if (colorBoxColorName == expressionColor)
            {
                falseCount += 1;
            }
            if (expressionOperator == "||")
            {
                if (falseCount >= 1)
                {
                    scoreCount += 1;
                    //add function or code to start next round
                }
                else
                {
                    MessageBox.Show("Game Over. Please restart.");
                    scoreCount = 0;
                }
            }
            if (expressionOperator == "&&")
            {
                if (falseCount == 2)
                {
                    scoreCount += 1;
                    //add function or code to start next round
                }
                else
                {
                    MessageBox.Show("Game Over. Please restart.");
                    scoreCount = 0;
                }
            }
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ExecutablePath);
            Application.Exit();
        }

    }
}
