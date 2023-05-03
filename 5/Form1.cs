using System.Diagnostics.Metrics;

namespace _5
{
    public partial class Form1 : Form
    {
        Mammals mammals;
        Birds birds;
        Fish fish;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if (NameBox1.Text == "" || VidBox1.Text == "" || Home1.Text == "" || NameBox2.Text == "" || VidBox2.Text == "" || Home2.Text == "" || NameBox3.Text == "" || VidBox3.Text == "" || Home3.Text == "")
            {
                MessageBox.Show("Всі дані мають бути введені!");
                Application.Restart();
            }



            mammals = new Mammals(NameBox1.Text, VidBox1.Text, Home1.Text, checkedListBox1.Text);
            birds = new Birds(NameBox3.Text, VidBox3.Text, Home3.Text, checkedListBox3.Text, checkBox1.Text);
            fish = new Fish(NameBox2.Text, VidBox2.Text, Home2.Text, checkedListBox2.Text);
            ResultBox.Text += birds.GetInformation() + Environment.NewLine;
            ResultBox.Text += fish.GetInformation() + Environment.NewLine;
            ResultBox.Text += mammals.GetInformation() + Environment.NewLine;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}