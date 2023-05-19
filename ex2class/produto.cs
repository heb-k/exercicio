using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2class
{
    class produto
    {
        public string nome;
        public double preco;
        public int qtd;

        public double valortotal()
        {
            return preco * qtd;
        }


        public void adicionar(int quantidade)
        {
            qtd = qtd + quantidade;
        }

        public void remover(int quantidade)
        {
            qtd = qtd - quantidade;
        }

        public override string ToString()
        {
            return "Nome: "+nome
            + ", R$ "
            + preco.ToString("F2")
            + ", "
            + qtd
            + " unidades, Total: $ "
            + valortotal().ToString("F2");
        }



    }
}
