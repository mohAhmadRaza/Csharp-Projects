﻿namespace ListBox
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
            FruitsListBox = new System.Windows.Forms.ListBox();
            label1 = new Label();
            textBox1 = new TextBox();
            ADD = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // FruitsListBox
            // 
            FruitsListBox.BackColor = SystemColors.Info;
            FruitsListBox.FormattingEnabled = true;
            FruitsListBox.Items.AddRange(new object[] { "Banana", "Apple", "Orange", "WaterMelon", "Guava", "Mango", "Grapes", "Stawberry", "PineApple", "Melon" });
            FruitsListBox.Location = new Point(12, 12);
            FruitsListBox.Name = "FruitsListBox";
            FruitsListBox.SelectionMode = SelectionMode.MultiSimple;
            FruitsListBox.Size = new Size(226, 464);
            FruitsListBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(316, 43);
            label1.Name = "label1";
            label1.Size = new Size(122, 31);
            label1.TabIndex = 1;
            label1.Text = "ADD ITEM";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.OldLace;
            textBox1.Location = new Point(483, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(259, 27);
            textBox1.TabIndex = 2;
            // 
            // ADD
            // 
            ADD.BackColor = SystemColors.Info;
            ADD.Location = new Point(482, 95);
            ADD.Name = "ADD";
            ADD.Size = new Size(260, 47);
            ADD.TabIndex = 3;
            ADD.Text = "ADD";
            ADD.UseVisualStyleBackColor = false;
            ADD.Click += ADD_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Location = new Point(483, 160);
            button1.Name = "button1";
            button1.Size = new Size(259, 46);
            button1.TabIndex = 4;
            button1.Text = "COUNT ITEMS";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Info;
            button2.Location = new Point(483, 225);
            button2.Name = "button2";
            button2.Size = new Size(259, 46);
            button2.TabIndex = 5;
            button2.Text = "SORT ITEMS";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Info;
            button3.Location = new Point(483, 290);
            button3.Name = "button3";
            button3.Size = new Size(259, 46);
            button3.TabIndex = 8;
            button3.Text = "DEL SPECIFIC ITEM";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Info;
            button4.Location = new Point(483, 361);
            button4.Name = "button4";
            button4.Size = new Size(259, 46);
            button4.TabIndex = 9;
            button4.Text = "CLEAR ALL";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(800, 604);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(ADD);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(FruitsListBox);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My ListBox Control";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox FruitsListBox;
        private Label label1;
        private TextBox textBox1;
        private Button ADD;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
