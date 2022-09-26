using Microsoft.VisualBasic;

namespace Calculator

{

    public partial class Form1 : Form
    {
        static int count = 0;
        public static double firstNum = 0;
        public static double secondNum = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                firstNum = double.Parse(this.textBox1.Text);
                secondNum = double.Parse(this.textBox2.Text);
                DataNums data = new DataNums(firstNum,secondNum);
               Form2 frm = new Form2(data);
                frm.Text = "Результат сложения";
                frm.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Неверный вввод данных, повторите ввод данных");  
            }
            count++;
            this.label4.Text = count.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Терешкин А.А ЭПБ-211";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                 firstNum = double.Parse(this.textBox1.Text);
                 secondNum = double.Parse(this.textBox2.Text);
                DataNums data = new DataNums(firstNum, secondNum);
                Form2 frm = new Form2(null);
                frm.Text = "Результат вычитания";
                frm.label1.Text = Math.Round(firstNum - secondNum,2).ToString();
                frm.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Неверный вввод данных, повторите ввод данных");
            }
            count++;
            this.label4.Text = count.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                firstNum = double.Parse(this.textBox1.Text);
                secondNum = double.Parse(this.textBox2.Text);
                Form2 frm = new Form2(null);
                frm.Text = "Результат возвдения в степень"; 
                frm.label1.Text= Math.Pow(firstNum,secondNum).ToString();
            }   
            catch
            {
                MessageBox.Show("Неверный вввод данных, повторите ввод данных");
            }
            count++;
           label4.Text = count.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                firstNum = double.Parse(this.textBox1.Text);
                secondNum = double.Parse(this.textBox2.Text);
                Form2 frm = new Form2(null);
                frm.Text = "Результат сравнения";
                if (firstNum > secondNum) frm.label1.Text = firstNum.ToString();
                else if (secondNum < firstNum) frm.label1.Text = secondNum.ToString();
                else frm.Text = "числа равны";
                frm.label1.Text = Math.Pow(firstNum, secondNum).ToString();
            }
            catch
            {
                MessageBox.Show("Неверный вввод данных, повторите ввод данных");
            }
            count++;
            label4.Text = count.ToString();
        }
    }
}  