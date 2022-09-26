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
                frm.Text = "��������� ��������";
                frm.ShowDialog();
            }
            catch
            {
                MessageBox.Show("�������� ����� ������, ��������� ���� ������");  
            }
            count++;
            this.label4.Text = count.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "�������� �.� ���-211";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                 firstNum = double.Parse(this.textBox1.Text);
                 secondNum = double.Parse(this.textBox2.Text);
                DataNums data = new DataNums(firstNum, secondNum);
                Form2 frm = new Form2(null);
                frm.Text = "��������� ���������";
                frm.label1.Text = Math.Round(firstNum - secondNum,2).ToString();
                frm.ShowDialog();
            }
            catch
            {
                MessageBox.Show("�������� ����� ������, ��������� ���� ������");
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
                frm.Text = "��������� ��������� � �������"; 
                frm.label1.Text= Math.Pow(firstNum,secondNum).ToString();
            }   
            catch
            {
                MessageBox.Show("�������� ����� ������, ��������� ���� ������");
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
                frm.Text = "��������� ���������";
                if (firstNum > secondNum) frm.label1.Text = firstNum.ToString();
                else if (secondNum < firstNum) frm.label1.Text = secondNum.ToString();
                else frm.Text = "����� �����";
                frm.label1.Text = Math.Pow(firstNum, secondNum).ToString();
            }
            catch
            {
                MessageBox.Show("�������� ����� ������, ��������� ���� ������");
            }
            count++;
            label4.Text = count.ToString();
        }
    }
}  