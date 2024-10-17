namespace тестирование_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox4.ReadOnly = true; //делаем недоступным для ввода
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //получаем значения сторон
            double side1 = double.Parse(textBox1.Text);
            double side2 = double.Parse(textBox2.Text);
            double side3 = double.Parse(textBox3.Text);

            //Проверяем, являются ли стороны треугольником
            if (!Prov(side1, side2, side2))
            {
                MessageBox.Show("Эти стороны не образуют треугольник.");
            }

            //Определяем вид треугольника
            string Type = A(side1, side2, side3);

            textBox4.Text = Type;
        }

        //Проверяем, являются ли стороны треугольником
        private bool Prov(double side1, double side2, double side3)
        {
            return (side1 + side2 > side3) && (side1 + side3 > side2) && (side2 + side3 > side1);
        }

        //Определяем вид треугольника
        private string A(double side1, double side2, double side3)
        {
            if (side1 == side2 && side2 == side3)
            {
                return "Равносторонний";
            }
            else if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                return "Равнобедренныйй";
            }
            else
            {
                return "Разносторонний";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Разрешаем только цифры, backspace и точку
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }
    }
}
