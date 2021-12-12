using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guiTask_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Task t = new Task(tbStr.Text);
                labRes.Text = t.Ans();
            }
            catch(System.FormatException)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }
    }
    class Task
    {
        string str;
        public Task(string str)
        {
            this.str = str;
        }
        public string Ans()
        {
            string ans = String.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ':')
                {
                    ans += str[i];
                }
                else
                {
                    return ans;
                }
            }
            return ans;
        }

    }
}
