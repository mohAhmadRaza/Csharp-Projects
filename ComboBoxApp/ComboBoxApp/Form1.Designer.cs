namespace ComboBoxApp
{
    partial class COMBOBOX
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
            HobbiesBox = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            AddItems = new Button();
            count = new Button();
            button1 = new Button();
            Clear = new Button();
            Sort = new Button();
            OUTPUT = new Label();
            SuspendLayout();
            // 
            // HobbiesBox
            // 
            HobbiesBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            HobbiesBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            HobbiesBox.Font = new Font("Perpetua Titling MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HobbiesBox.FormattingEnabled = true;
            HobbiesBox.Items.AddRange(new object[] { "Playing", "Reading", "Writing", "Singing", "Dancing", "Swimming" });
            HobbiesBox.Location = new Point(287, 180);
            HobbiesBox.Name = "HobbiesBox";
            HobbiesBox.Size = new Size(292, 36);
            HobbiesBox.TabIndex = 0;
            HobbiesBox.SelectedIndexChanged += HobbiesBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(47, 186);
            label1.Name = "label1";
            label1.Size = new Size(182, 24);
            label1.TabIndex = 1;
            label1.Text = "SELECT HOBBIES";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(46, 36);
            label3.Name = "label3";
            label3.Size = new Size(207, 24);
            label3.TabIndex = 3;
            label3.Text = "ADD NEW HOBBIES";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(287, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(328, 35);
            textBox1.TabIndex = 4;
            // 
            // AddItems
            // 
            AddItems.BackColor = Color.MediumSeaGreen;
            AddItems.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddItems.Location = new Point(287, 87);
            AddItems.Name = "AddItems";
            AddItems.Size = new Size(192, 43);
            AddItems.TabIndex = 5;
            AddItems.Text = "ADD HOBBIE";
            AddItems.UseVisualStyleBackColor = false;
            AddItems.Click += AddItems_Click;
            // 
            // count
            // 
            count.BackColor = Color.SeaGreen;
            count.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            count.Location = new Point(287, 249);
            count.Name = "count";
            count.Size = new Size(209, 43);
            count.TabIndex = 6;
            count.Text = "COUNT ITEMS";
            count.UseVisualStyleBackColor = false;
            count.Click += count_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSeaGreen;
            button1.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(287, 305);
            button1.Name = "button1";
            button1.Size = new Size(209, 43);
            button1.TabIndex = 7;
            button1.Text = "REMOVE ITEMS";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Clear
            // 
            Clear.BackColor = Color.MediumSeaGreen;
            Clear.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Clear.Location = new Point(287, 360);
            Clear.Name = "Clear";
            Clear.Size = new Size(209, 43);
            Clear.TabIndex = 8;
            Clear.Text = "CLEAR ITEMS";
            Clear.UseVisualStyleBackColor = false;
            Clear.Click += Clear_Click;
            // 
            // Sort
            // 
            Sort.BackColor = Color.MediumSeaGreen;
            Sort.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Sort.Location = new Point(287, 415);
            Sort.Name = "Sort";
            Sort.Size = new Size(209, 43);
            Sort.TabIndex = 9;
            Sort.Text = "SORT ITEMS";
            Sort.UseVisualStyleBackColor = false;
            Sort.Click += Sort_Click;
            // 
            // OUTPUT
            // 
            OUTPUT.AutoSize = true;
            OUTPUT.BackColor = Color.Olive;
            OUTPUT.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OUTPUT.Location = new Point(235, 485);
            OUTPUT.Name = "OUTPUT";
            OUTPUT.Size = new Size(84, 28);
            OUTPUT.TabIndex = 10;
            OUTPUT.Text = "output";
            OUTPUT.Visible = false;
            // 
            // COMBOBOX
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(800, 532);
            Controls.Add(OUTPUT);
            Controls.Add(Sort);
            Controls.Add(Clear);
            Controls.Add(button1);
            Controls.Add(count);
            Controls.Add(AddItems);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(HobbiesBox);
            ForeColor = SystemColors.ActiveCaptionText;
            MaximizeBox = false;
            Name = "COMBOBOX";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Combo Box App";
            Load += COMBOBOX_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox HobbiesBox;
        private Label label1;
        private Label label3;
        private TextBox textBox1;
        private Button AddItems;
        private Button count;
        private Button button1;
        private Button Clear;
        private Button Sort;
        private Label OUTPUT;
    }
}
