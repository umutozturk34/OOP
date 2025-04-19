namespace B221202039
{
    partial class B221202039
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            listBox1 = new ListBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ScrollBar;
            button1.Location = new Point(318, 319);
            button1.Name = "button1";
            button1.Size = new Size(160, 34);
            button1.TabIndex = 0;
            button1.Text = "Set Random Value";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ScrollBar;
            button2.Location = new Point(319, 359);
            button2.Name = "button2";
            button2.Size = new Size(160, 34);
            button2.TabIndex = 1;
            button2.Text = "Draw";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ScrollBar;
            button3.Location = new Point(318, 399);
            button3.Name = "button3";
            button3.Size = new Size(161, 31);
            button3.TabIndex = 2;
            button3.Text = "Rotate";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(142, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(147, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(318, 28);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(147, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(142, 81);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(147, 27);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(142, 131);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(147, 27);
            textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Location = new Point(142, 180);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(147, 27);
            textBox5.TabIndex = 7;
            // 
            // listBox1
            // 
            listBox1.BorderStyle = BorderStyle.FixedSingle;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(66, 248);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(206, 182);
            listBox1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(485, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(361, 381);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 31);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 10;
            label1.Text = "Center Points";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 81);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 11;
            label2.Text = "Length";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 131);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 12;
            label3.Text = "Number Of Edge";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 180);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 13;
            label4.Text = "Rotation Angel";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(858, 553);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private ListBox listBox1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
