using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuada2
{
    internal class Tabuada
    {
        private double n1;
        private double n2;

        public Tabuada(double n1, double n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }

        public void setN1(double n)
        {
            this.n1 = n;
        }

        public double getN1()
        {
            return this.n1;
        }

        public void setN2(double n)
        {
            this.n2 = n;
        }

        public double getN2()
        {
            return this.n2;
        }

        public double soma(double n1, double n2) { 
            return n1+ n2;
        }

        public double subtracao(double n1, double n2)
        {
            return n1 - n2;
        }

        public double multipicacao(double n1, double n2)
        {
            return n1 * n2;
        }

        public double divisao(double n1, double n2)
        {
            return n1 / n2;
        }
        public double resultado(double n1, double n2)
        {
            Console.WriteLine("Você  não preencheu as caixas");
        }
        
    }
}
