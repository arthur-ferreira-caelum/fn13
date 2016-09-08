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
        private int numeroDeContas;

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

            // Criando três contas e adicionando ao vetor com o método Adiciona.

            // Agora não podemos mais instanciar uma conta. Somos obrigados a escolher uma de suas filhas.
            //Conta c1 = new Conta();
            Conta c1 = new ContaCorrente();
            //c1.Numero = 1;
            c1.Titular = new Cliente("Victor");
            c1.Deposita(100);
            this.Adiciona(c1);

            ContaPoupanca c2 = new ContaPoupanca();
            //c2.Numero = 2;
            c2.Titular = new Cliente("Maurício");
            c2.Deposita(200);
            this.Adiciona(c2);

            ContaCorrente c3 = new ContaCorrente();
            //c3.Numero = 3;
            c3.Titular = new Cliente("Nico");
            c3.Deposita(300);
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

            // TENTA realizar um saque na conta, passando o valor que recuperamos do campo no formulário.
            try
            {
                // Se houver alguma exception aqui, nenhuma linha abaixo dessa será executada.
                // Daqui vai pular direto para o catch.
                selecionada.Saca(valor);

                // Tenho que me lembrar de colocar a atualização do campo e a mensagem DENTRO do try.
                // Se deixarmos fora do try, ele será atualizado e a mensagem exibida tanto no sucesso quanto no erro.
                // Dentro do try, ele só vai exibir se for sucesso.

                // Atualiza o campo saldo do formulario, com o novo saldo depois de fazer o saque.
                textoSaldo.Text = Convert.ToString(selecionada.Saldo);

                // Exibe uma mensagem informando que o saque foi realizado com sucesso.
                MessageBox.Show("Saque realizado com sucesso!!!");

            } // fim try
            catch (ArgumentException)
            {
                MessageBox.Show("Argumento inválido!");

            } // fim ArgumentException
            catch (SaldoInsuficienteException ex) // Se eu quiser recuperar o valor da propriedade Message da classe Exception, precisamos de uma variável no catch.
            {
                // Recupero a mensagem que foi definida na propriedade "Message" da classe Exception
                MessageBox.Show(ex.Message);

            } // fim SaldoInsuficienteException

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

            // TENTA realizar um depósito na conta, passando o valor que recuperamos do campo no formulário.
            try
            {
                // Se houver alguma exception aqui, nenhuma linha abaixo dessa será executada.
                // Daqui vai pular direto para o catch.
                selecionada.Deposita(valor);

                // Tenho que me lembrar de colocar a atualização do campo e a mensagem DENTRO do try.
                // Se deixarmos fora do try, ele será atualizado e a mensagem exibida tanto no sucesso quanto no erro.
                // Dentro do try, ele só vai exibir se for sucesso.

                // Atualiza o campo saldo do formulario, com o novo saldo depois de fazer o depósito.
                textoSaldo.Text = Convert.ToString(selecionada.Saldo);

                // Exibe uma mensagem informando que o depósito foi realizado com sucesso.
                MessageBox.Show("Depósito realizado com sucesso!!!");

            } // fim try
            catch (ArgumentException)
            {
                // Caso o valor seja negativo, exibe a mensagem...
                MessageBox.Show("Argumento inválido!");

            } // fim catch

        } // fim botaoDeposita_Click
        
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

        /// <summary>
        /// Metodo que adiciona uma conta ao vetor de contas.
        /// </summary>
        /// <param name="conta">A conta a ser adicionada</param>
        public void Adiciona(Conta conta)
        {
            // Verifica se o vetor de contas está cheio
            if (this.numeroDeContas == this.contas.Length)
            {
                // Cria um novo vetor, com tamanho maior
                Conta[] novoVetor = new Conta[this.contas.Length + 1];

                // Copia o conteúdo do vetor de contas para o novo vetor criado acima
                for (int i = 0; i < this.contas.Length; i++)
                {
                    novoVetor[i] = this.contas[i];
                }

                // A variável do vetor de contas recebe a referência do novo vetor criado. 
                this.contas = novoVetor;

            } // fim for

            // Insere a nova conta na última posição disponível no vetor.
            this.contas[this.numeroDeContas] = conta;

            // Incrementa o número de contas cadastradas no sistema.
            this.numeroDeContas++;

            // Adiciona a nova conta às combos do formulário.
            comboContas.Items.Add(conta.Titular.Nome);
            comboDestino.Items.Add(conta.Titular.Nome);

        } // fim Adiciona

        /// <summary>
        /// Método executado quando o botão nova conta é clicado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botaoNovaConta_Click(object sender, EventArgs e)
        {
            // Cria uma nova instância do Form de cadastro, passando a referência de Form1 (this)
            FormCadastroConta fcc = new FormCadastroConta(this);

            // Exibe o formulário de cadastro na tela do usuário.
            fcc.ShowDialog();

        } // fim botaoNovaConta_Click

        /// <summary>
        /// Método executado quando o botão impostos é clicado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botaoImpostos_Click(object sender, EventArgs e)
        {
            // Instancia e deposita um valor na conta
            ContaCorrente c1 = new ContaCorrente();
            c1.Deposita(100);

            // Exibe o calculo dos tributos da conta
            MessageBox.Show("Imposto da conta corrente = " + c1.CalculaTributos());

            // Mostrando que o polimorfismo também funciona com interfaces
            ITributavel t = c1;

            // Exibindo o mesmo resultado do imposto que fizemos pela classe. Em ambos os casos, é o mesmo método executado.
            MessageBox.Show("Imposto da conta pela interface = " + t.CalculaTributos());

            // Criando um seguro de vida
            SeguroDeVida sv = new SeguroDeVida();
            
            // Exibindo o imposto do seguro de vida
            MessageBox.Show("Imposto do seguro de vida = " + sv.CalculaTributos());

            // Polimorfismo de novo...
            t = sv;

            // Exibindo o mesmo resultado novamente.
            MessageBox.Show("Imposto do segudo de vida pela interface = " + t.CalculaTributos());

            // Criando uma instância do totalizador para praticar o polimorfismo
            TotalizadorDeTributos tdc = new TotalizadorDeTributos();

            // Adicionando a conta ao cálculo de tributos no totalizador
            tdc.Adiciona(c1);
            MessageBox.Show("Total: " + tdc.Total);

            // Adicionando a conta ao cálculo de tributos no totalizador
            tdc.Adiciona(t);
            MessageBox.Show("Total: " + tdc.Total);


        } // fim  botaoImpostos_Click

    } // fim Form1

} // fim namespace