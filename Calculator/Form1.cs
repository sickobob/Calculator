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
                frm.Owner = this;
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
        void sec_MyDelegateEvent(string s)
        {
            label4.Text = s;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                 firstNum = double.Parse(this.textBox1.Text);
                 secondNum = double.Parse(this.textBox2.Text);
                DataNums data = new DataNums(firstNum, secondNum);
                Form2 frm = new Form2(null);
                frm.Owner = this;
                frm.label1.Text = Math.Round(firstNum - secondNum, 2).ToString();
                frm.Text = "Результат вычитания";
                frm.ShowDialog();
            
               
            
            }
            catch
            {
                MessageBox.Show("Неверный вввод данных, повторите ввод данных");
            }
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                firstNum = double.Parse(this.textBox1.Text);
                secondNum = double.Parse(this.textBox2.Text);
                Form2 frm = new Form2(null);
                frm.Owner = this;
                frm.Text = "Результат возвдения в степень"; 
                frm.label1.Text= Math.Pow(firstNum,secondNum).ToString();
                frm.ShowDialog();
            }   
            catch
            {
                MessageBox.Show("Неверный вввод данных, повторите ввод данных");
            }
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                firstNum = double.Parse(this.textBox1.Text);
                secondNum = double.Parse(this.textBox2.Text);
                Form2 frm = new Form2(null);
             
                frm.Owner = this;
                frm.Text = "Результат сравнения";
                if (firstNum > secondNum) frm.label1.Text = $"Большее число--->{firstNum}";
                else if (firstNum < secondNum) frm.label1.Text = $"Большее число--->{secondNum}";
                else frm.label1.Text = "Числа равны";
                frm.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Неверный вввод данных, повторите ввод данных");
            }
         
        }
    }
}  