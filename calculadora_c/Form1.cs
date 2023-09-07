namespace calculadora_c
{
    public partial class Form1 : Form
    {
        double primero;
        double segundo;
        string operador;
        public Form1()
        {
            InitializeComponent();
        }

        clases.CIsSuma obj = new clases.CIsSuma();
        clases.CIsResta obj2 = new clases.CIsResta();
        clases.CIsMultiplicacion obj3 = new clases.CIsMultiplicacion();
        clases.CIsDivicion obj4 = new clases.CIsDivicion();

        private void btn1_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(tbx.Text);
            tbx.Clear();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbx.Text = tbx.Text + "2";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tbx.Text = tbx.Text + "8";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tbx.Text = tbx.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tbx.Text = tbx.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tbx.Text = tbx.Text + "7";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tbx.Text = tbx.Text + "9";
        }

        private void btn_punto_Click(object sender, EventArgs e)
        {
            tbx.Text = tbx.Text + ".";

        }
        private void btn_sum_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(tbx.Text);
            tbx.Clear();

        }

        private void btn_rest_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(tbx.Text);
            tbx.Clear();
        }

        private void btn_mult_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(tbx.Text);
            tbx.Clear();
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(tbx.Text);
            tbx.Clear();
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(tbx.Text);
            double sum;
            double rest;
            double mult;
            double div;
            switch (operador)
            {
                case "+":
                    sum = obj.sumar((primero), (segundo));
                    tbx.Text = sum.ToString();
                    break;
                case "-":
                    rest = obj2.restar((primero), (segundo));
                    tbx.Text = rest.ToString();
                    break;
                case "*":
                    mult = obj3.musltiplicar((primero), (segundo));
                    tbx.Text = mult.ToString();
                    break;

                case "/":
                    div = obj4.dividir((primero), (segundo));
                    tbx.Text = div.ToString();
                    break;
            }
        }

        private void btn1_Click_1(object sender, EventArgs e)
        {
            tbx.Text = tbx.Text + "1";
        }

        private void btn3_Click_1(object sender, EventArgs e)
        {
            tbx.Text = tbx.Text + "3";
        }

        private void btn4_Click_1(object sender, EventArgs e)
        {
            tbx.Text = tbx.Text + "4";
        }

        private void btn_elim_Click(object sender, EventArgs e)
        {
            tbx.Clear();
        }

        private void btn_retroceder_Click(object sender, EventArgs e)
        {
            if (tbx.Text.Length == 1)
                tbx.Text = "";
            else
                tbx.Text = tbx.Text.Substring(0, tbx.Text.Length - 1);
        }

        private void btn0_Click_1(object sender, EventArgs e)
        {
            tbx.Text = tbx.Text + "0";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}