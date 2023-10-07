using System;
using System.Windows.Forms;

namespace Event_example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EventExample ExampleEvent = new EventExample();
        private void Form1_Load(object sender, EventArgs e)
        {
            ExampleEvent.DataReceivedEvent += DataReceivedEventHandlerMethod;
        }

        private void DataReceivedEventHandlerMethod(object sender, EventArgs e, byte[] data)
        {
            MessageBox.Show(data[0].ToString()+ data[2].ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExampleEvent.testEvent();
        }
    }
}
