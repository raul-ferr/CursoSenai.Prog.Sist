using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carro
{
    internal class Carro
    {
        private string Marca;
        private int Ano;
        private string Cor;

        public void setMarca(string marca)
        {
            this.Marca = marca;
        }
        public string getMarca()
        {
            return this.Marca;
        }
        public void setAno(int ano)
        {
            this.Ano = ano;
        }
        public int getAno()
        {
            return this.Ano;
        }
        public void setCor(string cor)
        {
            this.Cor = cor;
        }
        public string getCor()
        {
            return this.Cor;
        }

    }
}
