using System.Windows.Forms;

namespace ThreadTest
{
    public partial class Form1 : Form
    {
        private volatile bool cancel;
        private Thread thread;
        private delegate void AddTextDelegate(string text);

        public Form1()
        {
            InitializeComponent();

            ButtonStop.Enabled = false;
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            ButtonStart.Enabled = false;
            ButtonStop.Enabled = true;

            cancel = false;

            thread = new Thread(DoSomething);

            thread.Start();
        }



        private void DoSomething()
        {
            var number = 0;

            while (!cancel)
            {
                AddText($"{number++}");

                Thread.Sleep(500);
            }
        }

        private void AddText(string text)
        {
            if (listBox.InvokeRequired)
            {
                var d = new AddTextDelegate(AddText);

                Invoke(d, text);
            }
            else
            {
                listBox.Items.Add(text);
            }
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            cancel = true;
            Thread.Sleep(500);

            thread.Join(10);
            thread = null;

            ButtonStart.Enabled = true;
            ButtonStop.Enabled = false;
        }
    }
}