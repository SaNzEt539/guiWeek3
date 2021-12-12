using consoleTask_10;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guiTask_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Task10 t = new Task10();
                label1.Text = t.GetFileInfo();
                t.f();
                label2.Text = t.GetDirectoryInfo();
            }
            catch(Exception exc)
            {
                label1.Text = exc.Message;
                label2.Visible = false;
            }
        }
    }
}
