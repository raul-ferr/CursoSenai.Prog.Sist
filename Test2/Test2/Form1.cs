namespace Test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btlCalcular_Click(object sender, EventArgs e)
        {
            double lado1 = Convert.ToDouble(txtLado1.Text);
            double lado2 = Convert.ToDouble(txtLado2.Text);
            double lado3 = Convert.ToDouble(txtLado3.Text);

            if (lado1 == lado2 && lado1 == lado3) 
            txtTipo.Text = "Equil�tero";

            if((lado1 == lado2 && lado1 != lado3) ||  
                (lado1 != lado2 && lado1 != lado3)|| 
                (lado2 == lado3 && lado2 != lado1))
                txtTipo.Text = "Is�celes";

            if (lado1 != lado2 && lado1 != lado3)
                txtTipo.Text = "Escaleno";
            }
        }
    }

    