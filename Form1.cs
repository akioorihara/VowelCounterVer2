using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VowelCounterVer2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int counter_x = 0, counter_y = 0;
            string words = textBox1.Text;
            for (int i = 0 ; i < words.Length; i++)
            {
                if(words[i] == 'a' || words[i] == 'i' || words[i] == 'u' || words[i] == 'e' || words[i] == 'o')
                {
                    counter_x += 1; 
                }
                if (checkBox1.Checked && words[i] == 'y')
                    counter_y += 1;
            }


            if (counter_x > 0 && checkBox1.Checked)
                if (counter_y > 0)
                    MessageBox.Show("Vowles found :" + counter_x + "\n Y found :" + counter_y + "\n" + "in " + words);
                else
                    MessageBox.Show("Vowles found :" + counter_x + "\n Y not found." + "\n" + "in " + words);
            else if (counter_x == 0 && checkBox1.Checked)
                MessageBox.Show("Vowles not found, but" + " Y count is : " + counter_y + "\n" + "in " + words);
            else if (counter_x > 0)
                MessageBox.Show("Vowles found : " + counter_x + "\n" + "in " + words);
            else
                MessageBox.Show("No Vowels found" + "\n" + "in " + words);

        }
    }
}
