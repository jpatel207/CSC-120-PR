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

        List<int> firstlist = new List<int>();


        public Form1()
        {
            InitializeComponent();
        }
        System.Random random = new System.Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            //had already used drag and drop method of creating buttons before help session tutorial, so I kept that instead of loading buttons using code here
            //this section contains the properties for components that need to be adjusted when form is loaded initially

            //gives a random integer to the box that the user will compare the boolean expression with 
            int num = random.Next(0, 9);
            this.ColorBox.Text = num.ToString();
            //gives a random color for the background of the comparison box
            Random rand = new Random();
            Color[] c = { Color.Blue, Color.Red, Color.Green, Color.Yellow};
            this.ColorBox.BackColor = c[rand.Next(0, c.Length)];
            this.ColorBox.ForeColor = Color.White;

            //box that shows boolean expression to compare with ColorBox
            //
            booleanExpressionString = 
            this.BooleanExpression.Text = "button1";


        }



        //true and false button event handlers
        //checks if colored box output and text boolean output is the same
        //adds to score if match - message box saying game over if no match

    }
}
