using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace CadastroCliente
{
    


    public class Crud
    {

        Conexao conexao = new Conexao();
        SqlCommand cmd = new();



        public string msg = string.Empty;

        public bool ClienteCadastro(DadosCadastro dadosCadastro)
        {
            
            dadosCadastro.DataCadastro = DateTime.Now;
            dadosCadastro.ClienteUI = Guid.NewGuid(); 
            dadosCadastro.ProcessoUI = Guid.NewGuid();


            // Comando Sql 
            cmd.CommandText = "insert into Cliente(DataCadastro , ClienteUI, Codigo, Nome, Id, Cpf, DataNascimento, Endereco, Numero, Bairro, Cidade, Referencia, Cep, UF, Celular, Telefone Email, ContatoNome, ContatoTelefone, ContatoRelacao, ProcessUI, Processo, Tipo, Situacao, DataProcesso, Medida, Descricao, ValorServico, FormaPagamento, Parcelas, Vencimento, Pago, Pagar) " +
                              "values(@DataCadastro, @ClienteUI, @Codigo, @Nome, @Id, @Cpf, @DataNascimento, @Endereco, @Numero, @Bairro, @Cidade, @Referencia, @Cep, @UF, @Celular, @Telefone @Email, @ContatoNome, @ContatoTelefone, @ContatoRelacao, @ProcessUI, @Processo, @Tipo, @Situacao, @DataProcesso, @Medida, @Descricao, @ValorServico, @FormaPagamento, @Parcelas, @Vencimento, @Pago, @Pagar) ";
            // Parametros

            cmd.Parameters.AddWithValue("@DataCadastro",dadosCadastro.DataCadastro);
            cmd.Parameters.AddWithValue("@ClienteUI", dadosCadastro.ClienteUI);
            cmd.Parameters.AddWithValue("@Codigo", dadosCadastro.Codigo);
            cmd.Parameters.AddWithValue("@Nome", dadosCadastro.Nome);
            cmd.Parameters.AddWithValue("@Id", dadosCadastro.Id);
            cmd.Parameters.AddWithValue("@Cpf", dadosCadastro.Cpf);
            cmd.Parameters.AddWithValue("@DataNascimento", dadosCadastro.DataNascimento);
            cmd.Parameters.AddWithValue("@Endereco", dadosCadastro.Endereco);
            cmd.Parameters.AddWithValue("@Numero", dadosCadastro.Numero);
            cmd.Parameters.AddWithValue("@Bairro", dadosCadastro.Bairro);
            cmd.Parameters.AddWithValue("@Cidade", dadosCadastro.Cidade);
            cmd.Parameters.AddWithValue("@Referencia", dadosCadastro.Referencia);
            cmd.Parameters.AddWithValue("@Cep", dadosCadastro.Cep);
            cmd.Parameters.AddWithValue("@UF", dadosCadastro.UF);
            cmd.Parameters.AddWithValue("@Celular", dadosCadastro.Celular);
            cmd.Parameters.AddWithValue("@Telefone", dadosCadastro.Telefone);
            cmd.Parameters.AddWithValue("@Email", dadosCadastro.Email);
            cmd.Parameters.AddWithValue("@ContatoNome", dadosCadastro.ContatoNome);
            cmd.Parameters.AddWithValue("@ContatoTelefone", dadosCadastro.ContatoTelefone);
            cmd.Parameters.AddWithValue("@ContatoRelacao", dadosCadastro.ContatoRelacao);
            cmd.Parameters.AddWithValue("@ProcessoUI", dadosCadastro.ProcessoUI);
            cmd.Parameters.AddWithValue("@Processo", dadosCadastro.Processo);
            cmd.Parameters.AddWithValue("@Tipo", dadosCadastro.Tipo);
            cmd.Parameters.AddWithValue("@Situacao", dadosCadastro.Situacao);
            cmd.Parameters.AddWithValue("@DataProcesso", dadosCadastro.DataProcesso);
            cmd.Parameters.AddWithValue("@Medida", dadosCadastro.Medida);
            cmd.Parameters.AddWithValue("@Descricao", dadosCadastro.Descricao);
            cmd.Parameters.AddWithValue("@ValorServico", dadosCadastro.ValorServico);
            cmd.Parameters.AddWithValue("@FormaPagamento", dadosCadastro.FormaPagamento);
            cmd.Parameters.AddWithValue("@Parcelas", dadosCadastro.Parcelas);
            cmd.Parameters.AddWithValue("@Vencimento", dadosCadastro.Vencimento);
            cmd.Parameters.AddWithValue("@Pago", dadosCadastro.Pago);
            cmd.Parameters.AddWithValue("@Pagar", dadosCadastro.Pagar);
                

            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.desconectar();
                msg = "Cliente Cadastrado!";
                return true;
            }

            catch (Exception)
            {
                msg = "Erro ao cadastrar cliente!";
                return false;
            }
            


        }



    }
}
