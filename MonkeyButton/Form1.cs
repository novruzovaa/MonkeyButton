namespace MonkeyButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Random random = new Random();
            button1.Location = new Point(random.Next(1505), random.Next(807));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
        }
    }
}