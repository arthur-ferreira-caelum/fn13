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

    } // fim Form1

} // fim namespace