using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace revisãodeprojetos_14._07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            double altura = double.Parse(tbxAltura.Text);
            double baseArea = double.Parse(tbxBase.Text);
            double calcula = altura * baseArea;
            tbxArea.Text = calcula.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculaT_Click(object sender, EventArgs e)
        {
            double altura = double.Parse(tbxAlturaT.Text);
            double baseAreaT = double.Parse(tbxBaseT.Text) / 2;
            double calcula = altura * baseAreaT;
            tbxAreaT.Text = calcula.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double altura = double.Parse(tbxTrapezioAltura.Text);
            double baseTrapeziomenor = double.Parse(tbxBaseMenor.Text);
            double baseTrapezio = double.Parse(tbxBaseMaior.Text);
            double calcula =((baseTrapeziomenor + baseTrapezio)* altura)/ 2;
            tbxTrapezioArea.Text = calcula.ToString();

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void tbxTrapezioArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double quantidade = double.Parse(tbxQuantidade.Text);
            double valordoproduto = double.Parse(tbxValor.Text);
            double calcula = quantidade * valordoproduto;
            tbxCompra.Text = calcula.ToString();
        }

        private void tbnCalcula_Click(object sender, EventArgs e)
        {
            double nota1 = double.Parse(tbxN1.Text);
            double nota2 = double.Parse(tbxN2.Text);
            double nota3 = double.Parse(tbxN3.Text);
            double calcula = (nota1 + nota2 + nota3) / 3;
            tbxMediaFinal.Text = calcula.ToString();
        }
    }
}
