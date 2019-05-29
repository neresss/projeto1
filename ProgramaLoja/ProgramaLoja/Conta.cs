using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaLoja
{
    public class Conta
    {

        List<Transacao> transacoes = new List<Transacao>();
        public List<Transacao> Transacoes
        {
            get
            {
                return transacoes;
            }

            set
            {
                transacoes = value;
            }
        }

        public void AddTransacao(string ind, decimal valor)
        {
            Transacao tr = new Transacao(ind, valor);
            transacoes.Add(tr);
        }
        public void AddTransacao(Transacao trans)
        {
            transacoes.Add(trans);
        }

        public List<Transacao> getLista()
        {
           return  transacoes;

        }

        public void Extrato()
        {
            foreach (Transacao item in transacoes)
            {
                Console.WriteLine("DATA:{0} , IDENTIFICAÇÃO: {1} , VALOR: R${2}", item.id , item.identificacao, item.valor);
            }
            
        }



        public decimal getSaldo()
        {
            decimal saldo = 0;
            foreach (Transacao item in transacoes)
            {
                saldo = saldo + item.valor;

            }
            return saldo;
        }


        public Transacao GetByID(string id)
        {
            foreach (Transacao item in transacoes)
            {
                if (item.id == id)
                {
                    return item;
                }
                
            }
            return null;

        }

        //private decimal saldo;
        //public void credito(decimal valor)
        //{
        //    this.saldo = this.saldo + valor;
        //}
        //public void Debitar(decimal valor)
        //{

        //    this.saldo = this.saldo - valor;
        //}

        //public decimal getSaldo()
        //{
        //    return saldo;

        //}





    }
}
