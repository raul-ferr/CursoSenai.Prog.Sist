using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contabancaria
{
    internal class Banco
    {
        private double saldo;

        public void setSaldo(double valor)
        {
          this.saldo = valor;
        }

        public double getSaldo()
        {
            return this.saldo;
        }

        public double setDeposito(double valor)
        {
           
                return this.saldo = saldo + valor;

           
        }

        public double setSaque(double valor)
        {
            //MessageBox.Show(Convert.ToString(valor));
            if (valor <= saldo)
            {
                //MessageBox.Show(Convert.ToString(valor), Convert.ToString(saldo));

                return this.saldo = saldo - valor;
            }
            else
                return 0;
            
        }

        public double setTrasnfe(double valor)
        {
            if (saldo > valor)
            {
                saldo = saldo - valor;
               
            }
            return saldo;

        }

       
    }
}
