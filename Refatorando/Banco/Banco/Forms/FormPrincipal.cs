using Caelum.Banco.Clientes;
using Caelum.Banco.Contas;
using Caelum.Banco.Enums;
using Caelum.Banco.Excecoes;
using Caelum.Banco.Seguros;
using Caelum.Banco.Totalizadores;
using Caelum.Banco.Tributacoes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace Caelum.Banco.Forms
{
    /// <summary>
    /// Classe do formulário principal do sistema. O primeiro que é executado junto com o sistema.
    /// </summary>
    public partial class FormPrincipal : Form
    {   
        // Vamos utilizar agora lista ao invés de vetor. Para isso, não iremos precisar armazenar o número de contas.
        private List<Conta> contas;
        
        // Dicionário de nomes e conta.
        private Dictionary<string, Conta> dicionario;

        /// <summary>
        /// Construtor sem argumentos
        /// </summary>
        public FormPrincipal()
        {
            InitializeComponent();
        } // fim Construtor

        /// <summary>
        /// Método executado quando o evento de Load do FormPrincipal é executado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            // Iniciando nossa lista
            this.contas = new List<Conta>();

            // Iniciando o dicionário
            this.dicionario = new Dictionary<string, Conta>();

            // Criando e selecionando o primeiro item nas combos
            this.comboContas.Items.Add("-- Selecione --");
            this.comboContas.SelectedIndex = 0;
            this.comboDestino.Items.Add("-- Selecione --");
            this.comboDestino.SelectedIndex = 0;

            var c1 = new ContaCorrente();
            c1.Titular = new Cliente("Victor");
            c1.Titular.Rg = 123;
            c1.Deposita(100000);
            this.Adiciona(c1);

            var c2 = new ContaPoupanca();
            c2.Titular = new Cliente("Maurício");
            c2.Titular.Rg = 456;
            c2.Deposita(20000);
            this.Adiciona(c2);

            var c3 = new ContaCorrente();
            c3.Titular = new Cliente("Nico");
            c3.Titular.Rg = 789;
            c3.Deposita(30000);
            this.Adiciona(c3);

            // Fazendo o teste do totalizador de contas
            TotalizadorDeContas tdc = new TotalizadorDeContas();
            tdc.Adiciona(this.contas[0]);
            tdc.Adiciona(this.contas[1]);
            tdc.Adiciona(this.contas[2]);
            Debug.WriteLine("Saldo total: " + tdc.SaldoTotal);
        } // fim Form1_Load

        /// <summary>
        /// Método executado quando o usuário clica no botão de Saque.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botaoSaca_Click(object sender, EventArgs e)
        {
            this.ExecutaOperacaoBancaria(TipoOperacao.SAQUE);
        } // fim botaoSaca_Click
        
        /// <summary>
        /// Método executado quando o usuário clica no botão de Depósito.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botaoDeposita_Click(object sender, EventArgs e)
        {
            this.ExecutaOperacaoBancaria(TipoOperacao.DEPOSITO);
        } // fim botaoDeposita_Click
        
        /// <summary>
        /// Método executado quando um valor é selecionado no menu da comboContas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.AtualizaCampos();
        } // fim comboContas_SelectedIndexChanged

        /// <summary>
        /// Método executado quando o botão de transferência é clicado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botaoTransfere_Click(object sender, EventArgs e)
        {
            this.ExecutaOperacaoBancaria(TipoOperacao.TRANSFERENCIA);
        } // fim botaoTransfere_Click

        /// <summary>
        /// Metodo que adiciona uma conta ao vetor de contas.
        /// </summary>
        /// <param name="conta">A conta a ser adicionada</param>
        public void Adiciona(Conta conta)
        {
            this.contas.Add(conta);
            this.comboContas.Items.Add(conta);
            this.comboDestino.Items.Add(conta);
            this.comboDestino.DisplayMember = "Titular";
            this.dicionario.Add(conta.Titular.Nome, conta);
        } // fim Adiciona

        /// <summary>
        /// Método executado quando o botão nova conta é clicado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botaoNovaConta_Click(object sender, EventArgs e)
        {
            FormCadastroConta fcc = new FormCadastroConta(this);
            fcc.ShowDialog();
        } // fim botaoNovaConta_Click

        /// <summary>
        /// Método executado quando o botão impostos é clicado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botaoImpostos_Click(object sender, EventArgs e)
        {
            var c1 = new ContaCorrente();
            c1.Deposita(100);

            MessageBox.Show("Imposto da conta corrente = " + c1.CalculaTributos());
            ITributavel t = c1;
            MessageBox.Show("Imposto da conta pela interface = " + t.CalculaTributos());
            SeguroDeVida sv = new SeguroDeVida();
            MessageBox.Show("Imposto do seguro de vida = " + sv.CalculaTributos());
            t = sv;
            MessageBox.Show("Imposto do segudo de vida pela interface = " + t.CalculaTributos());
            TotalizadorDeTributos tdc = new TotalizadorDeTributos();
            tdc.Adiciona(c1);
            MessageBox.Show("Total: " + tdc.Total);
            tdc.Adiciona(t);
            MessageBox.Show("Total: " + tdc.Total);
            
        } // fim  botaoImpostos_Click

        /// <summary>
        /// Método acionado quando o botão buscar é clicado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botaoBuscar_Click(object sender, EventArgs e)
        {
            string nomeTitular = this.textoBusca.Text;
            try
            {
                var encontrada = this.dicionario[nomeTitular];
                this.textoTitular.Text = encontrada.Titular.Nome;
                this.textoNumero.Text = Convert.ToString(encontrada.Numero);
                this.textoSaldo.Text = Convert.ToString(encontrada.Saldo);
                this.comboContas.SelectedItem = encontrada;
            }
            catch (KeyNotFoundException)
            {
                MessageBox.Show("Nome não encontrado!");
            }
        } // fim botaoBuscar_Click

        /// <summary>
        /// Método acionado quando o botão de relatórios é clicado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botaoRelatorios_Click(object sender, EventArgs e)
        {
            FormRelatorios formRelatorios = new FormRelatorios(this.contas);
            formRelatorios.ShowDialog();
        } // fim botaoRelatorios_Click

        /// <summary>
        /// Recupera a conta selecionada na combo de acordo com o tipo.
        /// </summary>
        /// <param name="tipoComboConta">Qual a combo a recuperar conta</param>
        /// <exception cref="ArgumentNullException">Caso nenhuma conta esteja selecionada</exception>
        /// <returns>A conta selecionada</returns>
        private Conta GetContaSelecionada(TipoComboConta tipoComboConta)
        {
            // Todas as combos são instâncias da classe ComboBox.
            // Dessa forma, basta eu criar uma variável genérica que irá receber a combo de acordo com o parâmetro passado.
            ComboBox combo;
            String mensagemErro = "";
            if (tipoComboConta.Equals(TipoComboConta.ORIGEM))
            {
                combo = this.comboContas;
                mensagemErro = "Selecione uma conta de origem";
            }
            else
            {
                combo = this.comboDestino;
                mensagemErro = "Selecione uma conta de destino";
            }

            if ((combo.SelectedItem == null) || (combo.SelectedIndex == 0))
                throw new ContaNaoSelecionadaException(mensagemErro);

            return (Conta)combo.SelectedItem;
        } // fim GetContaSelecionada
        
        /// <summary>
        /// Atualiza os campos do formulário com os valores da referência passada como argumento.
        /// </summary>
        /// <param name="conta">A conta</param>
        private void AtualizaCampos()
        {
            try
            {
                if (this.comboContas.SelectedIndex >0)
                {
                    var conta = this.GetContaSelecionada(TipoComboConta.ORIGEM);
                    this.textoTitular.Text = conta.Titular.Nome;
                    this.textoNumero.Text = Convert.ToString(conta.Numero);
                    this.textoSaldo.Text = Convert.ToString(conta.Saldo);
                }
                else
                {
                    this.textoTitular.Text = String.Empty;
                    this.textoNumero.Text = String.Empty;
                    this.textoSaldo.Text = String.Empty;
                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Selecione uma conta primeiro.");
            }
        } // fim AtualizaCampos

        /// <summary>
        /// Executa a operação bancária correspondente.
        /// </summary>
        /// <param name="operacao">O tipo da operacao bancária</param>
        private void ExecutaOperacaoBancaria(TipoOperacao operacao)
        {
            try
            {
                var selecionada = this.GetContaSelecionada(TipoComboConta.ORIGEM);
                var valor = Convert.ToDouble(textoValor.Text);

                switch (operacao)
                {
                    case TipoOperacao.SAQUE:
                        selecionada.Saca(valor);
                        MessageBox.Show("Saque realizado com sucesso!!!");
                        break;
                    case TipoOperacao.DEPOSITO:
                        selecionada.Deposita(valor);
                        MessageBox.Show("Depósito realizado com sucesso!!!");
                        break;
                    case TipoOperacao.TRANSFERENCIA:
                        Conta destino = this.GetContaSelecionada(TipoComboConta.DESTINO);
                        selecionada.Transfere(destino, valor);
                        MessageBox.Show("Transferência realizada com sucesso!!!");
                        break;
                    default:
                        break;
                } // fim switch

                this.AtualizaCampos();
                this.textoValor.Text = String.Empty;
            }
            catch (FormatException)
            {
                MessageBox.Show("O valor digitado é inválido");
            }
            catch (OverflowException)
            {
                MessageBox.Show("O valor digitado é grande demais.");
            }
            catch (ContaNaoSelecionadaException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Argumento inválido!");
            }
            catch (SaldoInsuficienteException ex)
            {
                MessageBox.Show(ex.Message);
            }

        } // fim ExecutaOperacaoBancaria

    } // fim Form1

} // fim namespace