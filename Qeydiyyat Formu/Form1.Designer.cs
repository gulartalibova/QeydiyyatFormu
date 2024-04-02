namespace Qeydiyyat_Formu
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            listBox1 = new ListBox();
            button1 = new Button();
            panel1 = new Panel();
            maskedTextBox1 = new MaskedTextBox();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 170);
            label1.Name = "label1";
            label1.Size = new Size(56, 33);
            label1.TabIndex = 0;
            label1.Text = "Ad:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(305, 170);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(296, 39);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 228);
            label2.Name = "label2";
            label2.Size = new Size(93, 33);
            label2.TabIndex = 2;
            label2.Text = "Soyad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 286);
            label3.Name = "label3";
            label3.Size = new Size(148, 33);
            label3.TabIndex = 3;
            label3.Text = "Universitet:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(105, 344);
            label4.Name = "label4";
            label4.Size = new Size(108, 33);
            label4.TabIndex = 4;
            label4.Text = "Fakulte:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(105, 402);
            label5.Name = "label5";
            label5.Size = new Size(82, 33);
            label5.TabIndex = 5;
            label5.Text = "Tarix:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(305, 226);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(296, 39);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(305, 282);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(296, 39);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(305, 338);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(296, 39);
            textBox4.TabIndex = 8;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 31;
            listBox1.Location = new Point(88, 485);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(868, 159);
            listBox1.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(658, 394);
            button1.Name = "button1";
            button1.Size = new Size(201, 51);
            button1.TabIndex = 11;
            button1.Text = "Qeydiyyat";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label6);
            panel1.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1023, 124);
            panel1.TabIndex = 12;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(305, 399);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(296, 39);
            maskedTextBox1.TabIndex = 13;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(139, 37);
            label6.Name = "label6";
            label6.Size = new Size(504, 51);
            label6.TabIndex = 0;
            label6.Text = "Q e y d i y y a t    F o r m u";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(1500, 698);
            Controls.Add(maskedTextBox1);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private ListBox listBox1;
        private Button button1;
        private Panel panel1;
        private MaskedTextBox maskedTextBox1;
        private Label label6;
    }
}
