namespace ExceptionHandlingSample
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            groupBox2 = new GroupBox();
            button2 = new Button();
            groupBox3 = new GroupBox();
            numericUpDown1 = new NumericUpDown();
            button3 = new Button();
            groupBox4 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(39, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(691, 133);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // button1
            // 
            button1.Location = new Point(394, 26);
            button1.Name = "button1";
            button1.Size = new Size(268, 81);
            button1.TabIndex = 4;
            button1.Text = "Divide";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(153, 69);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(201, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(153, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 27);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 76);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 1;
            label2.Text = "Zahl 2:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 31);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "Zahl 1:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(37, 365);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(643, 71);
            textBox3.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Location = new Point(39, 172);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(695, 103);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // button2
            // 
            button2.Location = new Point(28, 26);
            button2.Name = "button2";
            button2.Size = new Size(616, 53);
            button2.TabIndex = 0;
            button2.Text = "Lese Datei ein.";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(numericUpDown1);
            groupBox3.Controls.Add(button3);
            groupBox3.Location = new Point(37, 287);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(702, 72);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(29, 26);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(254, 27);
            numericUpDown1.TabIndex = 1;
            // 
            // button3
            // 
            button3.Location = new Point(339, 19);
            button3.Name = "button3";
            button3.Size = new Size(158, 39);
            button3.TabIndex = 0;
            button3.Text = "Starte Primzahlsuche";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(textBox6);
            groupBox4.Controls.Add(textBox5);
            groupBox4.Controls.Add(textBox4);
            groupBox4.Location = new Point(756, 43);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(499, 408);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Arten der Fehlerausgabe:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 263);
            label5.Name = "label5";
            label5.Size = new Size(139, 20);
            label5.TabIndex = 5;
            label5.Text = "toString()-Ausgabe:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 168);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 4;
            label4.Text = "StackTrace:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 45);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 3;
            label3.Text = "Message:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(15, 289);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(459, 87);
            textBox6.TabIndex = 2;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(20, 191);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(459, 69);
            textBox5.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(15, 83);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(459, 82);
            textBox4.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1292, 560);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(textBox3);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "ExceptionHandling Samples";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private GroupBox groupBox2;
        private Button button2;
        private GroupBox groupBox3;
        private Button button3;
        private NumericUpDown numericUpDown1;
        private GroupBox groupBox4;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
    }
}
