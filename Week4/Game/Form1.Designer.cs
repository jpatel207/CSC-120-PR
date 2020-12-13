namespace Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.instructions = new System.Windows.Forms.Label();
            this.TrueButton = new System.Windows.Forms.Button();
            this.FalseButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.RestartButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ColorBox = new System.Windows.Forms.Button();
            this.BooleanExpression = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(168, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(397, 46);
            this.title.TabIndex = 0;
            this.title.Text = "True-False Boolean Game";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ScoreLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ScoreLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ScoreLabel.Location = new System.Drawing.Point(286, 71);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(123, 37);
            this.ScoreLabel.TabIndex = 3;
            //this.ScoreLabel.Text = "Score = 0";
            // 
            // instructions
            // 
            this.instructions.AutoSize = true;
            this.instructions.Location = new System.Drawing.Point(168, 341);
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(370, 20);
            this.instructions.TabIndex = 6;
            this.instructions.Text = "Click true if the button matches the boolean expresion.";
            // 
            // TrueButton
            // 
            this.TrueButton.Location = new System.Drawing.Point(3, 3);
            this.TrueButton.Name = "TrueButton";
            this.TrueButton.Size = new System.Drawing.Size(94, 29);
            this.TrueButton.TabIndex = 7;
            this.TrueButton.Text = "True";
            this.TrueButton.UseVisualStyleBackColor = true;
            this.TrueButton.Click += new System.EventHandler(this.TrueButton_Click);
            // 
            // FalseButton
            // 
            this.FalseButton.Location = new System.Drawing.Point(103, 3);
            this.FalseButton.Name = "FalseButton";
            this.FalseButton.Size = new System.Drawing.Size(94, 29);
            this.FalseButton.TabIndex = 8;
            this.FalseButton.Text = "False";
            this.FalseButton.UseVisualStyleBackColor = true;
            this.FalseButton.Click += new System.EventHandler(this.FalseButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.TrueButton);
            this.flowLayoutPanel1.Controls.Add(this.FalseButton);
            this.flowLayoutPanel1.Controls.Add(this.RestartButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(248, 247);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 77);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // RestartButton
            // 
            this.RestartButton.BackColor = System.Drawing.Color.Red;
            this.RestartButton.Location = new System.Drawing.Point(3, 38);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(194, 29);
            this.RestartButton.TabIndex = 9;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = false;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ColorBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BooleanExpression, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(275, 128);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(144, 113);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // ColorBox
            // 
            this.ColorBox.Location = new System.Drawing.Point(3, 3);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(138, 50);
            this.ColorBox.TabIndex = 0;
            this.ColorBox.UseVisualStyleBackColor = true;
            // 
            // BooleanExpression
            // 
            this.BooleanExpression.Location = new System.Drawing.Point(3, 59);
            this.BooleanExpression.Name = "BooleanExpression";
            this.BooleanExpression.Size = new System.Drawing.Size(138, 51);
            this.BooleanExpression.TabIndex = 1;
            this.BooleanExpression.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.instructions);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label instructions;
        private System.Windows.Forms.Button TrueButton;
        private System.Windows.Forms.Button FalseButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ColorBox;
        private System.Windows.Forms.Label cor;
        private System.Windows.Forms.Button BooleanExpression;
    }
}

