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
            //had already used drag and drop method of creating buttons before tutorial, so I kept that instead of loading buttons using code here
            //this section contains the properties for components that need to be adjusted when form is loaded initially

            int num = random.Next(0, 9);
            this.ColorBox.Text = num.ToString();




        }



        //true and false button event handlers
        //checks if colored box output and text boolean output is the same
        //adds to score if match - message box saying game over if no match

    }
}
