using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsTutorial
{

    public partial class Form1 : Form
    {
        int controlCount = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //load code here
            for(int i = 0; i<controlCount;i++)
            {
                var myButton = new Button();
                myButton.Click += MyButton_Click; //event handler
                myButton.Height = 90;
                myButton.Width = 90;
                switch(i)
                {
                    case 0:
                        myButton.BackColor = Color.Blue;
                        myButton.ForeColor = Color.White;
                        break;
                    case 1:
                        myButton.BackColor = Color.Red;
                        myButton.ForeColor = Color.White;
                        break;
                    case 2:
                        myButton.BackColor = Color.Beige;
                        myButton.ForeColor = Color.Black;
                        break;
                    case 3:
                        myButton.BackColor = Color.Maroon;
                        myButton.ForeColor = Color.White;
                        break;
                    default:
                        myButton.BackColor = Color.White;
                        myButton.ForeColor = Color.Black;
                        break;
                }
                //myButton.BackColor = Color.Beige;
                myButton.Text = i.ToString();
                this.flowLayoutPanel1.Controls.Add(myButton);
            }


        }

        private void MyButton_Click(object sender, EventArgs e)
        {
            var buttonThatWasClicked = (Button)sender;
            MessageBox.Show(buttonThatWasClicked.Text);
            var intValue = int.Parse(buttonThatWasClicked.Text);
            switch(intValue)
            {
                case 0:
                    buttonThatWasClicked.BackColor = Color.Red;
                    buttonThatWasClicked.ForeColor = Color.White;
                    break;
                case 1:
                    buttonThatWasClicked.BackColor = Color.Blue;
                    buttonThatWasClicked.ForeColor = Color.White;
                    break;
                case 2:
                    buttonThatWasClicked.BackColor = Color.Aqua;
                    buttonThatWasClicked.ForeColor = Color.Black;
                    break;
                case 3:
                    buttonThatWasClicked.BackColor = Color.Green;
                    buttonThatWasClicked.ForeColor = Color.White;
                    break;
                default:
                    buttonThatWasClicked.BackColor = Color.Black;
                    buttonThatWasClicked.ForeColor = Color.White;
                    break;
            }

        }
    }
}
