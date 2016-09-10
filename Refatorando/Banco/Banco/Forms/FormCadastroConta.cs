using Caelum.Banco.Busca;
using Caelum.Banco.Clientes;
using Caelum.Banco.Contas;
using Caelum.Banco.Enums;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Caelum.Banco.Forms
{
    /// <summary>
    /// Formulário de cadastro de clientes
    /// </summary>
    public partial class FormCadastroConta : Form
    {
        // Atributos
        private FormPrincipal formPrincipal;
        private ICollection<string> devedores;

        /// <summary>
        /// Construtor que recebe FormPrincipal.
        /// </summary>
        /// <param name="formPrincipal"></param>
        public FormCadastroConta(FormPrincipal formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();
        } // fim Construtor

        /// <summary>
        /// Método executado quando o formulário termina de carregar e todos os componentes estão prontos para serem utilizados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCadastroConta_Load(object sender, EventArgs e)
        {
            GeradorDeDevedores gerador = new GeradorDeDevedores();
            this.devedores = gerador.GeraLista();

            this.textoNumero.Text = Convert.ToString(Conta.ProximoNumero());

            this.comboTipo.Items.Add("Poupança");
            this.comboTipo.Items.Add("Corrente");
        } // fim FormCadastroConta_Load

        /// <summary>
        /// Metodo executado quando o botao cadastrar é clicado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botaoCadastrar_Click(object sender, EventArgs e)
        {
            var titular = this.textoTitular.Text;
            var ehDevedor = false;
            for (int i = 0; i < 30000; i++)
                ehDevedor = this.devedores.Contains(titular);

            // Se for um devedor...
            if (ehDevedor)
                MessageBox.Show("Devedor!");
            else // ...caso contrário, continuar a criar a nova conta. 
            {
                Conta novaConta;
                var indiceTipo = comboTipo.SelectedIndex;
                switch (indiceTipo)
                {
                    case (int)TipoConta.POUPANCA:
                        novaConta = new ContaPoupanca();
                        break;
                    case (int)TipoConta.CORRENTE:
                        novaConta = new ContaCorrente();
                        break;
                    default:
                        novaConta = new ContaPoupanca();
                        break;

                } // fim switch

                novaConta.Titular = new Cliente(textoTitular.Text);

                this.formPrincipal.Adiciona(novaConta);
                MessageBox.Show("Conta criada com sucesso!");

                this.Close();

            } // fim else

        } // fim botaoCadastrar_Click
        
    } // fim FormCadastroConta

} // fim namespace
