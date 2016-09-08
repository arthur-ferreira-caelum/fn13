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
        // Mudamos o atributo de apenas uma referência para um vetor de contas.
        //private Conta conta;
        private Conta[] contas;

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
            // Instanciando um novo vetor com 3 posições
            this.contas = new Conta[3];

            // Criando três contas. Uma para cada posição do vetor.
            this.contas[0] = new Conta();
            this.contas[0].Numero = 1;
            this.contas[0].Titular = new Cliente("Victor");
            this.contas[0].Deposita(100);

            this.contas[1] = new ContaPoupanca();
            this.contas[1].Numero = 2;
            this.contas[1].Titular = new Cliente("Maurício");
            this.contas[1].Deposita(200);

            this.contas[2] = new ContaCorrente();
            this.contas[2].Numero = 3;
            this.contas[2].Titular = new Cliente("Nico");
            this.contas[2].Deposita(300);

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
            // Agora não trabalhamos mais com textoIndice e sim, com a combobox
            //var indice = Convert.ToInt32(textoIndice.Text);
            var indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];

            // Recuperando o valor digitado no campo valor do formulário. Como o valor digitado é um texto, ele vem como String.
            // Eu preciso converter esse valor para um double. Para isso, usamos a classe utilitária do .NET conhecida como "Convert"
            // Essa classe converte um texto para qualquer valor e qualquer número para um texto. Se quiser saber mais sobre a classe Convert e seus métodos, é só buscar por ela na MSDN.
            // Aqui eu declarei a variável valor como "var". A variável valor será do tipo do primeiro valor que receber.
            // Nesse caso aqui, ela será do tipo double. Lembrando que só podemos usar o operador "var" em métodos.
            var valor = Convert.ToDouble(textoValor.Text);

            // Realiza um saque na conta, passando o valor que recuperamos do campo no formulário.
            selecionada.Saca(valor);

            // Atualiza o campo saldo do formulario, com o novo saldo depois de fazer o saque.
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);

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
            // Agora não trabalhamos mais com textoIndice e sim, com a combobox
            //var indice = Convert.ToInt32(textoIndice.Text);
            var indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];

            // Recuperando o valor digitado no campo valor do formulário. Como o valor digitado é um texto, ele vem como String.
            // Eu preciso converter esse valor para um double. Para isso, usamos a classe utilitária do .NET conhecida como "Convert"
            // Essa classe converte um texto para qualquer valor e qualquer número para um texto. Se quiser saber mais sobre a classe Convert e seus métodos, é só buscar por ela na MSDN.
            // Aqui eu declarei a variável valor como "var". A variável valor será do tipo do primeiro valor que receber.
            // Nesse caso aqui, ela será do tipo double. Lembrando que só podemos usar o operador "var" em métodos.
            var valor = Convert.ToDouble(textoValor.Text);

            // Realiza um depósito na conta, passando o valor que recuperamos do campo no formulário.
            selecionada.Deposita(valor);

            // Atualiza o campo saldo do formulario, com o novo saldo depois de fazer o depósito.
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);

            // Exibe uma mensagem informando que o depósito foi realizado com sucesso.
            MessageBox.Show("Depósito realizado com sucesso!!!");

        } // fim botaoDeposita_Click

        ///// <summary>
        ///// Método executado quando o usuário clica no botão de busca.
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void botaoBusca_Click(object sender, EventArgs e)
        //{
        //    // Recupera a conta selecionada através do índice digitado no campo textoIndice.
        //    var indice = Convert.ToInt32(textoIndice.Text);
        //    Conta selecionada = this.contas[indice];

        //    // Preenche os campos do formulário com as informações da conta.
        //    textoTitular.Text = selecionada.Titular.Nome;
        //    textoNumero.Text = Convert.ToString(selecionada.Numero);
        //    textoSaldo.Text = Convert.ToString(selecionada.Saldo);

        //} // fim botaoBusca_Click

        /// <summary>
        /// Método executado quando um valor é selecionado no menu da comboContas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Recupera o índice selecionado no menu da combo e recupera a conta no vetor
            var indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];

            // Preenche os campos do formulário com as informações da conta.
            textoNumero.Text = Convert.ToString(selecionada.Numero);
            textoTitular.Text = selecionada.Titular.Nome;
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);

        } // fim comboContas_SelectedIndexChanged

        /// <summary>
        /// Método executado quando o botão de transferência é clicado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botaoTransfere_Click(object sender, EventArgs e)
        {
            // Recupera o índice de origem selecionado no menu da combo de contas e recupera a conta no vetor
            var indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];

            // Recupera o índice de destino selecionado no menu da combo de destino e recupera a conta no vetor
            var indiceDestino = comboDestino.SelectedIndex;
            Conta destino = this.contas[indice];

            // Recuperando o valor digitado no campo valor do formulário. Como o valor digitado é um texto, ele vem como String.
            // Eu preciso converter esse valor para um double. Para isso, usamos a classe utilitária do .NET conhecida como "Convert"
            // Essa classe converte um texto para qualquer valor e qualquer número para um texto. Se quiser saber mais sobre a classe Convert e seus métodos, é só buscar por ela na MSDN.
            // Aqui eu declarei a variável valor como "var". A variável valor será do tipo do primeiro valor que receber.
            // Nesse caso aqui, ela será do tipo double. Lembrando que só podemos usar o operador "var" em métodos.
            var valor = Convert.ToDouble(textoValor.Text);

            // Realiza a transferência entre contas passando o valor e a conta destino.
            selecionada.Transfere(destino, valor);

            // Atualiza o campo saldo do formulario, com o novo saldo depois de fazer a transferência.
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);

            // Exibe uma mensagem informando que a transferência foi realizada com sucesso.
            MessageBox.Show("Transferência realizada com sucesso!!!");

        } // fim botaoTransfere_Click

    } // fim Form1

} // fim namespace