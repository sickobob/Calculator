using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form2 : Form
    {
        public Form2(DataNums? dataNums)
        {
            InitializeComponent();
            DataNums = dataNums;
            if (dataNums != null) label1.Text = (dataNums.FirstNum + dataNums.SecondNum).ToString();
        }
        static int count = 0;
     
        DataNums? DataNums;
     

        private void Form2_Load(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            Close();
            Form1 main = Owner as Form1;
            if (main != null) main.label4.Text = count.ToString();
           
        }
    }
}
