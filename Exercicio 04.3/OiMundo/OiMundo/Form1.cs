using System;
using System.Windows.Forms;

namespace OiMundo
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
        /// <summary>
        /// Construtor da classe
        /// </summary>
        public Form1()
        {
            // Inicializando os componentes visuais (botões, labels, textboxes, etc.)
            InitializeComponent();

        } // fim Construtor

        /// <summary>
        /// Olá Mundo!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello World!");
            MessageBox.Show("Curso de C# da Caelum");

        } // fim button1_Click

        /// <summary>
        /// Crie 3 variáveis com as idades dos seus melhores amigos e/ou familiares.
        /// 
        /// Em seguida, pegue essas ì idades e calcule a média delas. Exiba o resultado em um MessageBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exercicio351_Click(object sender, EventArgs e)
        {
            // Declarnado variáveis
            int idadeAragorn = 10;
            int idadeLegolas = 20;
            int idadeGimli = 30;

            // Calculando a média
            int media = (idadeAragorn + idadeLegolas + idadeGimli) / 3;

            // Exibindo a média
            MessageBox.Show("A média é: " + media);

        } // fim exercicio351_Click

        /// <summary>
        /// O que acontece com o código abaixo?
        /// int pi = 3.14;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exercicio352_Click(object sender, EventArgs e)
        {
            // Declarando variável
            double pi = 3.14;

            // Ao fazer o casting, houve o desperdício de .14, armazenando somente o inteiro (3)
            int piQuebrado = (int)pi;

            // Exibindo o valor quebrado
            MessageBox.Show("piQuebrado = " + piQuebrado);

        } // fim exercicio352_Click

        /// <summary>
        /// No colegial, aprendemos a resolver equações de segundo grau usando a fórmula de Bhaskara:
        /// 
        /// delta = b*b - 4*a*c;
        /// 
        /// Crie um programa com três variáveis inteiras, a, b, c, com quaisquer valores. Depois crie ì variáveis
        /// double, delta, a1, a2, com a fórmula anterior.
        /// 
        /// Imprima a1 e a2 em um MessageBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exercicio353_Click(object sender, EventArgs e)
        {
            // Declarando as variáveis da fórmula
            // Lembrando que para ter um resultado satisfatório nesse exercício, o valor da variável "b" tem que ser maior do que "a" e "c"
            // Se colocar menor, vai exibir a mensagem "NaN" de "Not a Number", indicando que o valor não é suportado.
            int a = 1;
            int b = 10;
            int c = 2;

            // Declarando e calculando delta
            double delta = b * b - 4 * a * c;

            // Declarando e Calculando a1 e a2;
            double a1 = a1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double a2 = (-b - Math.Sqrt(delta)) / (2 * a);

            // Exibindo os resultados de a1 e a2
            MessageBox.Show("a1 = " + a1 + "\na2 = " + a2);

        } // fim exercicio353_Click

        /// <summary>
        /// Testa como fica o saldo final.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exercicio451_Click(object sender, EventArgs e)
        {
            // Declarando as variáveis
            double saldo = 100.0;
            double valorSaque = 10.0;

            // SE o saldo for maior OU igual ao valor de saque...
            if (saldo >= valorSaque)
            {
                // ... subtraia o valor do saldo ...
                // Lembrando que escrever "saldo = saldo - valorSaque" tem o mesmo resultado, só escrevemos mais
                saldo -= valorSaque;

                // ... e exibe a mensagem de sucesso
                MessageBox.Show("Saque realizado com sucesso");

            } // fim if
            else // CASO CONTRÁRIO...
            {
                // ... exiba a mensagem de saldo insuficiente
                MessageBox.Show("Saldo Insuficiente");

            } // fim else
        } // fim exercicio451_Click

        /// <summary>
        /// Testa como fica o saldo final.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exercicio452_Click(object sender, EventArgs e)
        {
            // Declarando variáveis
            double saldo = 5.0;
            double valorSaque = 10.0;

            // SE o saldo for maior OU igual ao valor de saque...
            if (saldo >= valorSaque)
            {
                // ... subtraia o valor do saldo ...
                // Lembrando que escrever "saldo = saldo - valorSaque" tem o mesmo resultado, só escrevemos mais
                saldo -= valorSaque;

                // ... e exibe a mensagem de sucesso
                MessageBox.Show("Saque realizado com sucesso");
            } // fim if
            else // CASO CONTRÁRIO...
            {
                // ... exiba a mensagem de saldo insuficiente
                MessageBox.Show("Saldo Insuficiente");

            } // fim else

        } // fim exercicio452_Click

        /// <summary>
        /// Em alguns casos, podemos ter mais de duas decisões possíveis. O banco pode, por exemplo, decidir
        /// que contas com saldo menor que R$ 1000 pagam 1% de taxa de manutenção, contas com saldo entre
        /// R$ 1000 e R$ 5000 pagam 5% e contas com saldo maior que R$5000 pagam 10%.
        /// 
        /// Para representar esse tipo de situação, podemos usar o else if do C#, que funciona em conjunto
        /// com o if que já conhecemos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exercicio453_Click(object sender, EventArgs e)
        {
            // Declarando a variável
            double saldo = 500.0;

            // SE o saldo for menor do que 0...
            if (saldo < 0.0)
            {
                // ... exibir a mensagem de negativo
                MessageBox.Show("Você está no negativo!");

            } // fim if
            else if (saldo < 1000000.0) // CASO CONTRÁRIO, SE o saldo for MENOR do que 1000000.0 (Ficando entre 0 e 1000000) ...
            {
                // ... exibir a mensagem de bom cliente
                MessageBox.Show("Você é um bom cliente");

            } // fim else if
            else // CASO CONTRÁRIO ...
            {
                // ... exibir a mensagem de milionário
                MessageBox.Show("Você é milionário!");

            } // fim else

        } // fim exercicio453_Click

        /// <summary>
        /// Uma pessoa só pode votar em eleições brasileiras se ela for maior que 16 anos e for cidadã brasileira.
        /// 
        /// Crie um programa com duas variáveis, int idade, bool brasileira, e faça com que o
        /// programa diga se a pessoa está apta a votar ou não, de acordo com os dados nas variáveis.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exercicio454_Click(object sender, EventArgs e)
        {
            // Declarando variáveis
            int idade = 16;
            bool brasileira = true;

            // Não somos obrigados a abrir e fechar chave se houver apenas uma linha de instrução a ser executada num "if"
            if (idade >= 16 && brasileira) // não há a necessidade de fazer brasileira == true, já que a variável já é um boolean
                MessageBox.Show("Pode votar!");
            else
                MessageBox.Show("Não pode votar!");

        } // fim exercicio454_Click

        /// <summary>
        /// Crie um programa que tenha uma variável double valorDaNotaFiscal e, de acordo com esse
        /// valor, o imposto deve ser calculado. As regras de cálculo são:
        /// 
        /// • Se o valor for menor ou igual a 999, o imposto deve ser de 2%
        /// • Se o valor estiver entre 1000 e 2999, o imposto deve ser de 2.5%
        /// • Se o valor estiver entre 3000 e 6999, o imposto deve ser de 2.8%
        /// • Se for maior ou igual a 7000, o imposto deve ser de 3%
        /// 
        /// Imprima o imposto em um MessageBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exercicio455_Click(object sender, EventArgs e)
        {
            double valorNotaFiscal = 5000;

            if (valorNotaFiscal <= 999) // SE o valor for menor ou igual a 999...
                MessageBox.Show("Imposto de 2%"); // ... exibe a mensagem de imposto de 2%
            else if (valorNotaFiscal <= 2999) // CASO CONTRÁRIO, SE o valor estiver entre 1000 e 2999...
                MessageBox.Show("Imposto de 2.5%"); // ... exibe a mensagem de imposto de 2.5%
            else if (valorNotaFiscal <= 6999) // CASO CONTRÁRIO, SE o valor estiver entre 3000 e 6999...
                MessageBox.Show("Imposto de 2.8%"); // ... exibe a mensagem de imposto de 2.8%
            else // CASO CONTRÁRIO, ou seja, valor maior ou igual a 7000...
                MessageBox.Show("Imposto de 3%"); // ... exibe a mensagem de imposto de 3%

        } // fim exercicio455_Click

    } // fim Form1

} // fim namespace
