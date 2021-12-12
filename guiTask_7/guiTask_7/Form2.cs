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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string str = tbStr.Text;
                Task2 t = new Task2(str);
                labRes.Text = t.Show();
                    
            }
            catch(System.FormatException)
            {

            }
        }
    }
    class Task2
    {
        StringBuilder str;
        public Task2(string str)
        {
            this.str = new StringBuilder(str);
            Ans();
        }
        void Ans()
        {
            int i = 0;
            while (i < str.Length - 1)
            {
                switch (str[i])
                {
                    case ' ':
                        switch (str[i + 1])
                        {
                            case '?':
                            case '!':
                            case ',':
                            case '.':
                                str.Remove(i, 1);
                                i--;
                                break;
                            default:
                                break;
                        }
                        break;
                    case '?':
                    case '!':
                    case ',':
                    case '.':
                        if (str[i + 1] == ' ')
                        {
                            break;
                        }
                        else
                        {
                            str.Insert(i + 1, ' ');
                            break;
                        }
                    default:
                        break;
                }
                i++;
            }
        }
        public string Show()
        {
            return str.ToString();
        }
    }
}
