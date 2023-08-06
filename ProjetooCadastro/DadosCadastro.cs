using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CadastroCliente
{
    public class DadosCadastro
    {

        public DateTime DataCadastro { get; set; }
        public Guid ClienteUI { get; set; }
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Id { get; set;}
        public int Cpf { get; set; }
        public DateTime DataNascimento { get; set; }


        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Referencia { get; set; }
        public int Cep { get; set; }
        public string UF { get; set; }


        public int Celular { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }
        public string ContatoNome { get; set; }
        public string ContatoTelefone { get; set;}
        public string ContatoRelacao { get; set; }

        public Guid ProcessoUI { get; set; }
        public string Processo { get; set; }
        public string Tipo { get; set; }
        public string Situacao { get; set; }
        public string DataProcesso { get; set; }
        public string Medida { get; set; }
        public string Descricao { get; set; }

        public decimal ValorServico { get; set; }
        public string FormaPagamento { get; set; }
        public int Parcelas { get; set; }
        public DateTime Vencimento { get; set; }
        public bool Pago { get; set; }
        public bool Pagar {get; set;}


    }
}
