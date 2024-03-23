using System.Timers;
using System.Xml.Serialization;


namespace clickerGame
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        int clickCount = 0;

        private void button1_Click(object sender, EventArgs e)
        {

            clickCount += 1;
            label1.Text = clickCount.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (clickCount >= 20) {
                clickCount -= 20;
                label1.Text = clickCount.ToString();
                autoclick();
            }
        }

        private void autoclick()
        {
            System.Timers.Timer timer1 = new System.Timers.Timer();
            timer1.Interval = 2000;
            timer1.Start();
            timer1.Elapsed += timer1_Tick;
            timer1.AutoReset = true;
            timer1.Enabled = true;
        }

        private void timer1_Tick(Object source, System.Timers.ElapsedEventArgs e)
        {
            clickCount += 1;
        }
    }
}
