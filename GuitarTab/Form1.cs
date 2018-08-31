using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuitarTab
{
    public partial class Form1 : Form
    {
        int i = 0;
        //char E, A, D, G, B, e;
        //   6, 5, 4, 3, 2, 1
        string str;
        bool start_e = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                str = textBox1.Text;
                button2.Enabled = true;
                button3.Enabled = true;
            }
            else
            {
                Console.WriteLine("TextBox is empty");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CheckBox[] eArr = { e0, e1, e2, e3 };
            char ee = str[i];
            if (ee == 'e' || start_e) //beginning
            {
                i++;
                ee = str[i];
                if (ee == '|' || start_e) //probably a tab
                {
                    start_e = true;
                    while (!System.Char.IsDigit(ee))
                    {
                        i++; //increase index until we hit a number
                        ee = str[i];
                    }//Found number!                                    (only works for single digits currently)
                    Console.WriteLine(ee);
                    eArr[ee - 48].Checked = true;


                }
            }
            else
            {
                Console.WriteLine("Tab issue");
            }
            //Console.WriteLine(ee);
            //i++;
        }

    }
}
