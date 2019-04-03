using System.Linq;
using System.Windows.Forms;

namespace Updater
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            foreach(var item in Proxy.list)
            {
                textBox.AppendText(item+"\n");
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Proxy.list = textBox.Text.Split('\n').ToList();
        }
    }
}
