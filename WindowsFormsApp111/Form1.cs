using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp111
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = int.Parse(textBox1.Text);
            b = 1;
            c = 0;
            for(int i = a; i<a+9999; i++)
            {
                for(b =1; b <= 12; b++)
                {
                    DateTime qwe = new DateTime(i, b, 13);
                    if (qwe.DayOfWeek == DayOfWeek.Friday)
                        c += 1;
                }
            }
            MessageBox.Show($"{c}");

        }
    }
}
