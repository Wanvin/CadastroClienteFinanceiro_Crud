using CadastroCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProjetooCadastro
{
    /// <summary>
    /// Lógica interna para Cadastro.xaml
    /// </summary>
    public partial class Cadastro : Window
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, RoutedEventArgs e)
        {

            Crud crud = new Crud();
            DadosCadastro dadosCadastro = new DadosCadastro();
            
            dadosCadastro.Nome = txb_nome.Text;

            

            try
            {
                crud.Cadastrar(dadosCadastro);
                MessageBox.Show(crud.msg);


                return ;

            }
            catch (Exception)
            {
  
            }
            
        }
    }
}
