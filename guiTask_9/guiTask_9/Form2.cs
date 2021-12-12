using consoleTask_9;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guiTask_9
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                Task2 t = new Task2();
                lab1.Text = "Считано:\n" + t.Str;
                t.F();
                t.Write();
                lab2.Text = "Изменено:\n" + t.Str;
            }
            catch(Exception exc)
            {
                lab1.Text = exc.Message;
                lab2.Visible = false;
            }
        }
    }
}
