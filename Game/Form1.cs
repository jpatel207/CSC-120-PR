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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var title = new Label();
            title.AutoSize = true;
            title.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            title.Location = new System.Drawing.Point(168, 9);
            title.Name = "title";
            title.Size = new System.Drawing.Size(397, 46);
            title.TabIndex = 0;
            title.Text = "True-False Boolean Game";

        }
    }
}
