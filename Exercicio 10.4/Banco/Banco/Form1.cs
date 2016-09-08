using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Banco
{
    /// <summary>
    /// Classe do formulário principal do sistema. O primeiro que é executado junto com o sistema.
    /// 
    /// Você pode ver essa classe sendo instanciada na classe <see cref="Program"/> nesse projeto aqui mesmo. 
    /// Abra o seu Solution Explorer e procure o aquivo lá.*
    /// 
    /// Essa classe é partial, pois ela tem uma segunda parte no arquivo Form1.designer.cs que contém todo o código usado para desenhar os componentes. 
    /// Quando você altera qualquer coisa no modo Design, ele escreve nesse arquivo. Por isso é importante que não alteremos esse arquivo na mão, 
    /// quem manipula ele é o Visual Studio.
    /// </summary>
    public partial class Form1 : Form
    {
        // Atributo da classe Form1. Declaramos aqui para que ele seja acessível por todos os métodos do formulário.
        private Conta conta;

        /// <summary>
        /// Construtor da classe
        /// </summary>
        public Form1()
        {
            // Inicializando os componentes visuais (botões, labels, textboxes, etc.)
            InitializeComponent();

        } // fim Construtor

        /// <summary>
        /// Método executado quando o evento de Load do Form1 é executado.
        /// Mais precisamente, logo após o objeto de Form1 ser instanciado e exibido.
        /// Isso garante que todos os componentes do form já existam e possam ser utilizados pelo código.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // Instanciando uma nova conta assim que o Form é exibido.
            // Não precisamos mudar o tipo da variável conta. Aqui entra o polimorfismo.
            this.conta = new ContaCorrente();
            this.conta.Numero = 1;
            this.conta.Titular = new Cliente("Victor");
            this.conta.Deposita(100);

            // Preenchendo os campos do formulário com os valores criados no objeto.
            textoTitular.Text = this.conta.Titular.Nome;
            textoNumero.Text = Convert.ToString(this.conta.Numero);
            textoSaldo.Text = Convert.ToString(this.conta.Saldo);

            // Fazendo o teste do totalizador de contas
            TotalizadorDeContas tdc = new TotalizadorDeContas();
            tdc.Adiciona(this.conta);
            Debug.WriteLine("Saldo total: " + tdc.SaldoTotal);
            
        } // fim Form1_Load

        /// <summary>
        /// Método executado quando o usuário clica no botão de Saque.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botaoSaca_Click(object sender, EventArgs e)
        {
            // Recuperando o valor digitado no campo valor do formulário. Como o valor digitado é um texto, ele vem como String.
            // Eu preciso converter esse valor para um double. Para isso, usamos a classe utilitária do .NET conhecida como "Convert"
            // Essa classe converte um texto para qualquer valor e qualquer número para um texto. Se quiser saber mais sobre a classe Convert e seus métodos, é só buscar por ela na MSDN.
            // Aqui eu declarei a variável valor como "var". A variável valor será do tipo do primeiro valor que receber.
            // Nesse caso aqui, ela será do tipo double. Lembrando que só podemos usar o operador "var" em métodos.
            var valor = Convert.ToDouble(textoValor.Text);

            // Realiza um saque na conta, passando o valor que recuperamos do campo no formulário.
            this.conta.Saca(valor);

            // Atualiza o campo saldo do formulario, com o novo saldo depois de fazer o saque.
            textoSaldo.Text = Convert.ToString(this.conta.Saldo);

            // Exibe uma mensagem informando que o saque foi realizado com sucesso.
            MessageBox.Show("Saque realizado com sucesso!!!");

        } // fim botaoSaca_Click

        /// <summary>
        /// Método executado quando o usuário clica no botão de Depósito.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botaoDeposita_Click(object sender, EventArgs e)
        {
            // Recuperando o valor digitado no campo valor do formulário. Como o valor digitado é um texto, ele vem como String.
            // Eu preciso converter esse valor para um double. Para isso, usamos a classe utilitária do .NET conhecida como "Convert"
            // Essa classe converte um texto para qualquer valor e qualquer número para um texto. Se quiser saber mais sobre a classe Convert e seus métodos, é só buscar por ela na MSDN.
            // Aqui eu declarei a variável valor como "var". A variável valor será do tipo do primeiro valor que receber.
            // Nesse caso aqui, ela será do tipo double. Lembrando que só podemos usar o operador "var" em métodos.
            var valor = Convert.ToDouble(textoValor.Text);

            // Realiza um depósito na conta, passando o valor que recuperamos do campo no formulário.
            this.conta.Deposita(valor);

            // Atualiza o campo saldo do formulario, com o novo saldo depois de fazer o depósito.
            textoSaldo.Text = Convert.ToString(this.conta.Saldo);

            // Exibe uma mensagem informando que o depósito foi realizado com sucesso.
            MessageBox.Show("Depósito realizado com sucesso!!!");

        } // fim botaoDeposita_Click

    } // fim Form1

} // fim namespace
