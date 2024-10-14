namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            FruitsListBox.Items.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int val = FruitsListBox.Items.Count;
            MessageBox.Show("Number Of List Items are : " + val.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FruitsListBox.Sorted = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FruitsListBox.Items.Remove(FruitsListBox.SelectedItem);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FruitsListBox.Items.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
