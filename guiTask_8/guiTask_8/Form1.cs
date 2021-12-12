using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using consoleTask_8;

namespace guiTask_8
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
                Class1 o = new Class1(tbStr.Text);
                labRes.Text = "Сайты:\n" + o.Result;
            }
            catch(Exception exc)
            {
                labRes.Text = exc.Message;
            }
        }
    }
}
