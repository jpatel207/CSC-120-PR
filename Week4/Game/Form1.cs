using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows;

//The following program runs a simple True-False boolean game. It is based on one of the games from csawesome.runestone.academy website.
//It is a fairly simple game where the user sees two different components - a colored box with an integer in it and a boolean expression. 
//The task is to choose true or false based on whether or not the colored box and boolean expression outputs match.

namespace Game
{
    public partial class Form1 : Form
    {
        System.Random random = new System.Random(); //to generate random integer
        Random rand = new Random(); //to get random pre-defined values from array

        //public variables that need to be accessible to different event handlers and other methods
        public int num;
        public int num2;
        public string colorBoxColorName;
        public string expressionColor;
        public string expressionOperator;
        public int scoreCount;


        public Form1() //class constructor
        {
            InitializeComponent();

            //used button form for color box and boolean expression outputs as it formats better in GUI
            //but they have no associated button type event handlers - function as if they are boxes and referred to as such throughout code
            
            //box with color and number 
            CreateColorBox();

            //box that shows boolean expression to compare with ColorBox
            CreateBooleanExpression();

            //intializes the beginning score of 0
            this.ScoreLabel.Text = "Score = " + scoreCount.ToString();

        }

        private void CreateBooleanExpression()
        {
            string[] color = { "Blue", "Red", "Green", "Gray" };
            num2 = random.Next(0, 9);
            string[] randomOperator = { "&&", "||" };
            expressionColor = color[rand.Next(0, color.Length)];
            expressionOperator = randomOperator[rand.Next(0, randomOperator.Length)];
            string booleanExpressionString = expressionColor + " " + expressionOperator + " " + num2.ToString(); //separate variables make it easier to do comparisons with later methods
            this.BooleanExpression.Text = booleanExpressionString;
        }

        private void CreateColorBox()
        {
            num = random.Next(0, 9);
            this.ColorBox.Text = num.ToString();
            Color[] c = { Color.Blue, Color.Red, Color.Green, Color.Gray };
            Color boxColor = c[rand.Next(0, c.Length)];
            colorBoxColorName = boxColor.Name; //returns string value of color to compare with boolean expression color string
            this.ColorBox.BackColor = boxColor;
            this.ColorBox.ForeColor = Color.White;
        }

        private void TrueButton_Click(object sender, EventArgs e)
        {
            int trueCount = 0; //counter to check if integers match, color match, or both (important for checking AND/OR logical operators)
            if (num == num2)
            {
                trueCount += 1;
            }
            if (colorBoxColorName == expressionColor)
            {
                trueCount += 1;
            }
            //after counting the matches for color and number, the following if statements break down into checking for AND or OR operator
            if (expressionOperator == "||") 
            {
                if (trueCount >= 1) //with OR logic, one or both true "inputs" results in a true output
                {
                    scoreCount += 1;
                    this.ScoreLabel.Text = "Score = " + scoreCount.ToString();
                }
                else if (trueCount == 0)
                {
                    MessageBox.Show("Game Over. Please restart." + " || if statement checker");
                    scoreCount = 0;
                    this.ScoreLabel.Text = "Score = " + scoreCount.ToString();
                }
            }
            if (expressionOperator == "&&")
            {
                if (trueCount == 2) //with AND logic, both inputs need to be true for the output to be true
                {
                    scoreCount += 1;
                    this.ScoreLabel.Text = "Score = " + scoreCount.ToString();
                }
                else
                {
                    MessageBox.Show("Game Over. Please restart." + " && if statement checker");
                    scoreCount = 0;
                    this.ScoreLabel.Text = "Score = " + scoreCount.ToString();
                }
            }
            //methods to start next round
            //putting this at the end of this button click event handler method because it can trigger unintended if statement when expressionOperator changes 
            //when CreateBooleanExpression() is called before if statement that checks for && operator
            CreateColorBox();
            CreateBooleanExpression();
        }

        private void FalseButton_Click(object sender, EventArgs e)
        {
            int falseCount = 0;
            if (num == num2)
            {
                falseCount += 1;
            }
            if (colorBoxColorName == expressionColor)
            {
                falseCount += 1;
            }
            if (expressionOperator == "||") //this is checking for false, essentially the reverse of the previous method for True Button logic
            {
                if (falseCount >= 1) //with OR logic, if at least one input is true, then the output would be true too, which means false is the wrong option for the user
                {
                    MessageBox.Show("Game Over. Please restart.");
                    scoreCount = 0;
                    this.ScoreLabel.Text = "Score = " + scoreCount.ToString();
                }
                else
                {
                    scoreCount += 1;
                    this.ScoreLabel.Text = "Score = " + scoreCount.ToString();
                }
            }
            if (expressionOperator == "&&")
            {
                if (falseCount == 2) //with AND logic, if both inputs are true, then the output would be true too, which means false is the wrong option for the user
                {
                    MessageBox.Show("Game Over. Please restart.");
                    scoreCount = 0;
                    this.ScoreLabel.Text = "Score = " + scoreCount.ToString();
                }
                else
                {
                    scoreCount += 1;
                    this.ScoreLabel.Text = "Score = " + scoreCount.ToString();

                }
            }
            //methods to start next round
            CreateColorBox();
            CreateBooleanExpression();
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            //restarts the program, similar to the actual game
            //this is not necessary because this program resets the user's score after incorrect input and still allows user to continue playing
            //user can also exit by using traditional exit (X) button, but this follows the way the original game has a restart button

            //personal knowledge comments:
            //System.Windows.Forms.Application.Restart(); did not work, possibly due to version of Windows Form Application being used
            //Application.Restart() resulted in an unhandled exception error message - seems unreliable

            Process.Start(Process.GetCurrentProcess().MainModule.FileName); //this method works with .NET CORE and Framework 3.1+ applications
            Application.Exit();
        }

    }
}
