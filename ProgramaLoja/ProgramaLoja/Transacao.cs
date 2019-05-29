using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaLoja
{
    public class Transacao
    {
        public string id { get; set; }
        public string identificacao { get; set; }
        public decimal valor { get; set; }

        public Transacao()
        {

        }

        public Transacao(string identificacao, decimal valor)
        {
            this.id = DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
            this.identificacao = identificacao;
            this.valor = valor;
        }
    }
}
