namespace ComboBoxApp
{
    public partial class COMBOBOX : Form
    {
        public COMBOBOX()
        {
            InitializeComponent();
        }

        private void COMBOBOX_Load(object sender, EventArgs e)
        {

        }

        private void AddItems_Click(object sender, EventArgs e)
        {
            string item = textBox1.Text;
            if (textBox1.Text != "" && !HobbiesBox.Items.Contains(textBox1.Text))
            {
                HobbiesBox.Items.Add(item);

                textBox1.Clear();
                textBox1.Focus();
                MessageBox.Show("Successfull Added " + item);
            }
            else if (textBox1.Text != "")
            {
                MessageBox.Show("Fill The TextBox First !!");
            }
            else
            {
                MessageBox.Show("Already Contains This Item !!");
            }
        }

        private void count_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total Items Are : " + HobbiesBox.Items.Count.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HobbiesBox.Items.Remove(HobbiesBox.SelectedItem);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            HobbiesBox.Items.Clear();
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            HobbiesBox.Sorted = true;
        }

        private void HobbiesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string check = HobbiesBox.SelectedItem.ToString();
            OUTPUT.Text = "Selected Items is : " + check;
            OUTPUT.Visible = true;
        }
    }
}
