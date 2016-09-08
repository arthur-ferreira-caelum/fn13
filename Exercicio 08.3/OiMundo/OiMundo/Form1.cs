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
            // Declaranado variáveis
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

        /// <summary>
        /// Qual valor é exibido no seguinte código?
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exercicio541_Click(object sender, EventArgs e)
        {
            // Declarando variável
            int total = 2;

            // Veja que a forma de incrementar o i é diferente do convencional.
            // Porém, fazer "i += 1" e "i++" dão no mesmo no final das contas, acrescenta 1 à variável "i".
            for (int i = 0; i < 5; i += 1)
            {
                total = total * 2;
            } // fim for

            // exibindo o total
            MessageBox.Show("O total é: " + total);

        } // fim exercicio541_Click

        /// <summary>
        /// Faça um programa que imprima a soma dos números de 1 até 1000.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exercicio542_Click(object sender, EventArgs e)
        {
            // variável onde será acumulado a soma e exibido o valor no final
            int soma = 0;

            // Loop que irá repetir de 1 até 1000
            for (int i = 1; i <= 1000; i++)
            {
                // acumula a soma
                // lembrando que esse código é a mesma coisa que "soma = soma + i"
                soma += i;

            } // fim for

            // exibindo o valor total da soma
            MessageBox.Show("A soma de 1 até 1000 é: " + soma);

            // Outra forma de fazer este exercício é usando a fórmula da Soma da Progressão Aritimética (P.A.)
            // A fórmula é: Sn = n/2 * (a1 + an)

            // Declarando as variáveis utilizadas na fórmula
            int sn = 0;
            int a1 = 1;
            int n = 1000;
            int an = 1000;

            // Fórmula da soma da P.A.
            sn = n / 2 * (a1 + an);

            // exibindo o valor total da soma
            MessageBox.Show("sn: " + sn);

        } // fim exercicio542_Click

        /// <summary>
        /// Faça um programa que imprima todos os múltiplos de 3, entre 1 e 100.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exercicio543_Click(object sender, EventArgs e)
        {
            // variável onde serão concatenados os múltiplos, separados por espaço em branco
            String multiplos = "";

            // Loop que irá repetir de 1 até 100
            for (int i = 1; i <= 100; i++)
            {
                // SE for múltiplo de 3...
                if (i % 3 == 0)
                    multiplos += i + " "; // ...concatena o número deixando um espaço em branco para o próximo
            } // fim for

            // exibindo os mútiplos
            MessageBox.Show(multiplos);

        } // fim exercicio543_Click

        /// <summary>
        /// Escreva um programa que some todos os números de 1 a 100, pulando os múltiplos
        /// de 3. O programa deve imprimir o resultado nal em um MessageBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exercicios544_Click(object sender, EventArgs e)
        {
            // variável onde serão concatenados os múltiplos, separados por espaço em branco
            String multiplos = "";

            // Loop que irá repetir de 1 até 100
            for (int i = 1; i <= 100; i++)
            {
                // SE for múltiplo de 3...
                if (i % 3 == 0)
                    continue; // ...pula o múltiplo e passa para o próximo número

                // Essa linha só será executada se a condição do "if" acima for "false"
                // Concatena o número deixando um espaço em branco para o próximo
                multiplos += i + " ";
            } // fim for

            // exibindo os múltiplos
            MessageBox.Show(multiplos);

        } // fim exercicios544_Click

        /// <summary>
        /// Escreva um programa que imprima todos os números que são divisíveis por 3 ou
        /// por 4 entre 0 e 30.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exercicio545_Click(object sender, EventArgs e)
        {
            // variável onde serão concatenados os múltiplos, separados por espaço em branco
            String multiplos = "";

            // loop que irá repetir de 0 a 30
            for (int i = 0; i <= 30; i++)
            {
                // SE for múltiplo de 3 E 4...
                if (i % 3 == 0 || i % 4 == 0)
                    multiplos += i + " "; // ...concatena o número deixando um espaço em branco para o próximo
            } // fim for

            // exibindo os múltiplos
            MessageBox.Show(multiplos);

        } // fim exercicio545_Click

        /// <summary>
        /// Faça um programa em C# que imprima os fatoriais de 1 a 10.
        /// 
        /// O fatorial de um número n é n * n-1* n-2...até n = 1.
        /// 
        /// O fatorial de 0 é 1
        /// O fatorial de 1 é (0!) * 1 = 1
        /// O fatorial de 2 é (1!) * 2 = 2
        /// O fatorial de 3 é (2!) * 3 = 6
        /// O fatorial de 4 é (3!) * 4 = 24
        /// 
        /// Faça um "for" que inicie uma variável "n" (número) como 1 e "fatorial" (resultado) como 1 e varia "n" de 1 até 10:
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exercicio546_Click(object sender, EventArgs e)
        {
            // O resultado do fatorial anterior. Como estamos declarando ainda, iniciamos com 1
            int fatorialAnterior = 1;

            // O resultado do fatorial atual. COmo estamos declarando ainda, iniciamos com 1
            int fatorialAtual = 1;

            // Declarando a mensagem inicial, quebrando a linha no final com o caractere "\n"
            string mensagem = "O fatorial de 0 é 1\n";

            // Loop de 1 até 10
            for (int n = 1; n <= 10; n++)
            {
                // Cálculo do fatorial
                fatorialAtual = fatorialAnterior * n;

                // Compondo a mensagem para ser concatenada
                mensagem += "O fatorial de " + n + " é " + fatorialAtual + "\n";

                // Atribui o fatorial atual ao fatorial anterior para reiniciar o ciclo
                fatorialAnterior = fatorialAtual;

            } // fim for

            // Exibindo a mensagem com as linhas dos fatoriais
            MessageBox.Show(mensagem);

        } // fim exercicio546_Click

        /// <summary>
        /// Faça um programa em C# que imprima os primeiros números da série de Fibonacci até
        /// passar de 100. 
        /// 
        /// A série de Fibonacci é a seguinte: 0, 1, 1, 2, 3, 5, 8, 13, 21 etc...
        /// 
        /// Para calculá-la, o primeiro elemento vale 0, o segundo vale 1, daí por diante, o n-ésimo elemento vale o (n-1)-ésimo elemento
        /// somado ao (n-2)-ésimo elemento(ex: 8 = 5 + 3).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exercicio547_Click(object sender, EventArgs e)
        {
            // Declarando as variáveis
            int n2 = 0; // valor n-2
            int n1 = 1; // valor n-1
            int n = 0; // valor atual
            string fibonacci = "0, 1"; // exibindo os valores já preenchidos em n-2 e n-1 por padrão

            // Repetir enquanto o valor atual for menor do que 100
            while (n < 100)
            {
                // Cálculo do valor
                n = n2 + n1;

                // Concatenando o resultado à string para ser exibida depois
                fibonacci += ", " + n;

                // O valor n-2 recebe o valor de n-1
                n2 = n1;

                // O valor de n-1 recebe o valor atual
                n1 = n;

            }// fim while

            // Exibe a sequência fibonacci calculada
            MessageBox.Show(fibonacci);

        } // exercicio547_Click

        /// <summary>
        /// Faça um programa que imprima a seguinte tabela, usando fors encadeados:
        /// 
        /// 1
        /// 2 4
        /// 3 6 9
        /// 4 8 12 16
        /// n n*2 n*3 .... n* n
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exercicio548_Click(object sender, EventArgs e)
        {
            // Mensagem formatada a ser exibida
            string mensagem = "";

            // Total de linhas
            int totalDeLinhas = 4;

            // Repete enquanto a linha for menor ou igual ao total de linhas a serem exibidas
            for (int linha = 1; linha <= totalDeLinhas; linha++)
            {
                // O número de colunas é equivalente ao primeiro valor da linha
                for (int coluna = 1; coluna <= linha; coluna++)
                {
                    // Cada VALOR da COLUNA é o primeiro NÚMERO, multiplicado pelo NÚMERO da COLUNA.
                    mensagem += linha * coluna + " ";

                } // fim for de colunas
                mensagem += "\n";

            } // fim for de linhas

            // Exibir as linhas processadas
            MessageBox.Show(mensagem);

        } // fim exercicio548_Click

        /// <summary>
        /// Testes criando várias contas com atributos diferentes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exercicio675_Click(object sender, EventArgs e)
        {
            // Cria uma nova conta
            Conta contaVictor = new Conta();

            // Preenche seus atributos, agora eles são propriedades
            // Agora o atributo titular não é mais do tipo String...é do tipo Cliente...
            //mauricio2.titular = "Mauricio";
            contaVictor.Titular = new Cliente();
            contaVictor.Titular.Nome = "Victor";
            contaVictor.Numero = 1;
            // Agora o saldo não pode mais ser alterado diretamente. Só utilizando métodos.
            //contaVictor.Saldo = 100.0;
            contaVictor.Deposita(100);

            // Exibe o nome do titular preenchido.
            MessageBox.Show(contaVictor.Titular.Nome);

            // Repetindo a operacao anterior com novos valores
            Conta contaLeo = new Conta();
            // Agora o atributo titular não é mais do tipo String...é do tipo Cliente...
            //mauricio2.titular = "Mauricio";
            contaLeo.Titular = new Cliente();
            contaLeo.Titular.Nome = "Leo";
            contaLeo.Numero = 2;
            // Agora o saldo não pode mais ser alterado diretamente. Só utilizando métodos.
            //contaLeo.Saldo = 200.0;
            contaLeo.Deposita(200);

            // Exibe o saldo da conta do Leo
            MessageBox.Show("Saldo: " + contaLeo.Saldo);

        } // exercicio675_Click

        /// <summary>
        /// Qual a saída do código?
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exercicio678_Click(object sender, EventArgs e)
        {
            // Criando a conta do mauricio e preenchendo o saldo
            Conta mauricio = new Conta();
            // Agora o saldo não pode mais ser alterado diretamente. Só utilizando métodos.
            //mauricio.Saldo = 2000.0;
            mauricio.Deposita(2000);

            // Criando a conta do guilherme e preenchendo o saldo
            Conta guilherme = new Conta();
            // Agora o saldo não pode mais ser alterado diretamente. Só utilizando métodos.
            //guilherme.Saldo = 5000.0;
            guilherme.Deposita(5000);

            // Alterando os saldos das contas
            // Agora o saldo não pode mais ser alterado diretamente. Só utilizando métodos.
            //mauricio.Saldo -= 200.0;
            mauricio.Deposita(-200);
            // Agora o saldo não pode mais ser alterado diretamente. Só utilizando métodos.
            //guilherme.Saldo += 200.0;
            guilherme.Deposita(200);

            // Exibindo os saldos das contas
            MessageBox.Show("mauricio = " + mauricio.Saldo);
            MessageBox.Show("guilherme = " + guilherme.Saldo);

        } // fim exercicio678_Click

        /// <summary>
        /// Qual a saída do código?
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exercicio679_Click(object sender, EventArgs e)
        {
            // Criando a conta do mauricio e preenchendo os atributos
            Conta mauricio = new Conta();
            mauricio.Numero = 1;
            // Agora o atributo titular não é mais do tipo String...é do tipo Cliente...
            //mauricio2.titular = "Mauricio";
            mauricio.Titular = new Cliente();
            mauricio.Titular.Nome = "Maurício";
            //mauricio.Saldo = 100.0;
            mauricio.Deposita(100);

            // Criando outra conta do mauricio e preenchendo os atributos com os mesmos valores
            Conta mauricio2 = new Conta();
            mauricio2.Numero = 1;
            // Agora o atributo titular não é mais do tipo String...é do tipo Cliente...
            //mauricio2.titular = "Mauricio";
            mauricio2.Titular = new Cliente();
            mauricio2.Titular.Nome = "Maurício";
            //mauricio2.Saldo = 100.0;
            mauricio2.Deposita(100);

            // SE mauricio e mauricio2 forem iguais...
            if (mauricio == mauricio2)
            {
                // ... Exibe mensagem de iguais
                MessageBox.Show("As contas são iguais");
            } // fim if
            else // CASO CONTRÁRIO...
            {
                // ... Exibe mensagem de diferentes
                // Neste caso, as contas são diferentes, mesmo que seus valores sejam idênticos.
                // Como criamos duas referências diferentes (fizemos "new" duas vezes"), são objetos diferentes, com valores de atributos iguais.
                // Isso faz diferença.
                MessageBox.Show("As contas são diferentes");
            } // fim else

        } // fim exercicio679_Click/

        /// <summary>
        /// Qual é a saída do código?
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exercicio6710_Click(object sender, EventArgs e)
        {
            // Criando a conta do mauricio e atribuindo um saldo
            Conta mauricio = new Conta();
            //mauricio.saldo = 2000.0;
            mauricio.Deposita(2000);

            // Copiando a referência da variavel mauricio e colando na variavel copia
            Conta copia = mauricio;

            // Alterando o atributo saldo do objeto da referência de copia
            //copia.saldo = 3000.0;
            copia.Deposita(3000);

            // Exibindo os saldos.
            // Nesse caso, os saldos serão iguais. Como mauricio e copia possuem a referência para um mesmo objeto, 
            // se um deles modificar um atributo, o outro irá enxergar a mudança automaticamente.
            MessageBox.Show("mauricio = " + mauricio.Saldo);
            MessageBox.Show("copia = " + copia.Saldo);

        } // fim exercicio6710_Click

        /// <summary>
        /// Implementando e usando o método transfere
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exercicio6711_Click(object sender, EventArgs e)
        {
            // Valor a ser transferido
            double valor = 1000;

            // Criando a conta de origem
            Conta origem = new Conta();
            //origem.Saldo = 2000.0;
            origem.Deposita(2000);

            // Criando a conta de destino
            Conta destino = new Conta();

            // Transferindo um valor da conta de origem para a conta de destino
            origem.Transfere(destino, valor);

            // Exibe uma mensagem com o valor de transferência e os saldos das duas contas
            MessageBox.Show("Valor transferido: " + valor + "\nSaldo c1: " + origem.Saldo + "\nSaldo c2: " + destino.Saldo);

        } // fim exercicio6711_Click

        /// <summary>
        /// Adicionando uma validação no método Saca
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exercicio6712_Click(object sender, EventArgs e)
        {
            // Criando uma conta e inicializando seu saldo
            Conta c1 = new Conta();
            //c1.Saldo = 2000.0;
            c1.Deposita(2000);

            // Realiza um saque e recupera o resultado
            bool sucesso = c1.Saca(500);

            // SE foi um sucesso ...
            if (sucesso)
                // ... exibe a mensagem de sucesso
                MessageBox.Show("Saque efetuado com sucesso!");
            else // CASO CONTRÁRIO...
                // ... exibe a mensagem de saldo insuficiente
                MessageBox.Show("Saldo insuficiente");

        } // fim exercicio6712_Click

        /// <summary>
        /// Alterando o método Saca para retornar o valor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exercicio6713_Click(object sender, EventArgs e)
        {
            // Cria uma conta e preenche seus atributos
            Conta c1 = new Conta();
            //c1.Saldo = 2000.0;
            c1.Deposita(2000);

            // Agora a idade não fica mais em conta, fica na classe cliente. Para acessar esse valor, preciso criar um cliente e acessar o atributo titular.
            //c1.idade = 16;
            c1.Titular = new Cliente();
            c1.Titular.Nome = "Ana";
            c1.Titular.Idade = 16;

            // SE o saque for um sucesso...
            if (c1.Saca(500))
                // Exibe a mensagem de sucesso
                MessageBox.Show("Saque efetuado com sucesso");
            else
                // Exibe a mensage de saldo insuficiente
                MessageBox.Show("Saldo insuficiente");

        } // fim exercicio6713_Click

        /// <summary>
        /// Alterando o método Saca para trabalhar com limite 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exercicio6714_Click(object sender, EventArgs e)
        {
            // Declarando uma conta e preenchendo atributos
            Conta c1 = new Conta();
            //c1.Saldo = 2000.0;
            c1.Deposita(2000);

            // Agora a idade não fica mais em conta, fica na classe cliente. Para acessar esse valor, preciso criar um cliente e acessar o atributo titular.
            //c1.idade = 16;
            c1.Titular = new Cliente();
            c1.Titular.Nome = "Ana";
            c1.Titular.Idade = 16;

            // Testa o metodo saca agora com limite por idade. SE retornou "true" ...
            if (c1.Saca(500))
                // ... exibir mensagem de saque efetuado com sucesso.
                MessageBox.Show("Saque efetuado com sucesso");
            else // CASO CONTRÁRIO ...
                // ... exibir mensagem de erro genérico, já que pode ser tanto saldo insuficiente quanto limite inválido.
                MessageBox.Show("Ocorreu um erro ao sacar");

        } // fim exercicio6714_Click

        /// <summary>
        /// Mudando o atributo titular de String para Cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exercicio691_Click(object sender, EventArgs e)
        {
            // Criando nova instancia de conta e preenchendo seus atributos
            Conta conta = new Conta();

            // Criando uma nova instância de cliente e preenchendo seus atributos
            Cliente cliente = new Cliente();

            // Atribuindo a referência criada de cliente para o atributo titular da conta
            conta.Titular = cliente;
            conta.Titular.Nome = "Victor";

            // Exibindo o nome do titular da conta
            MessageBox.Show(conta.Titular.Nome);

        } // fim exercicio691_Click

        /// <summary>
        /// O que é impresso na tela?
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exercicio692_Click(object sender, EventArgs e)
        {
            // Criando uma instância de conta
            Conta umaConta = new Conta();

            // Criando uma instância de cliente e preenchendo o nome
            Cliente guilherme = new Cliente();
            guilherme.Nome = "Guilherme Silveira";

            // Atribuindo a referência do cliente ao atributo titular da conta
            umaConta.Titular = guilherme;

            // Exibindo o nome do titular da conta
            MessageBox.Show(umaConta.Titular.Nome);

        } // fim exercicio692_Click

        /// <summary>
        /// O que é impresso na tela?
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exercicio693_Click(object sender, EventArgs e)
        {
            // Criando uma instancia de conta
            Conta umaConta = new Conta();

            // Criando uma instancia de cliente e preenchendo o RG
            Cliente guilherme = new Cliente();
            guilherme.Rg = "12345678-9";

            // Atribuindo a instância de cliente criada ao atributo titular da conta criada
            umaConta.Titular = guilherme;

            // Alterando o RG da conta
            umaConta.Titular.Rg = "98765432-1";

            // Exibindo o valor RG do Cliente
            MessageBox.Show(guilherme.Rg);

        } // fim exercicio693_Click

    } // fim Form1

} // fim namespace
