using System;
using System.IO;
using System.Windows.Forms;

namespace Caelum.EditorDeTexto
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
    public partial class Form1 : Form
    {
        /// <summary>
        /// Construtor da classe
        /// </summary>
        public Form1()
        {
            InitializeComponent();

        } // fim Construtor

        /// <summary>
        /// Método acionado quando o formulário é carregado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // Verifica se o arquivo existe.
            if (File.Exists("texto.txt"))
            {
                // NÃO É BOA PRÁTICA CRIAR STREAM SEM USING!
                //Stream entrada = File.Open("texto.txt", FileMode.Open);
                //StreamReader leitor = new StreamReader(entrada);


                // Se existir, criam um stream para ler o arquivo em bytes.
                // Com o stream criado, criamos um processo para ler os bytes do stream.
                using (Stream entrada = File.Open("texto.txt", FileMode.Open))
                using (StreamReader leitor = new StreamReader(entrada))
                {
                    //// Fazemos uma primeira leitura do arquivo para saber se tem conteúdo.
                    //string linha = leitor.ReadLine();

                    //// Enquanto a linha lida for diferente de nulo, continuamos a ler o arquivo. 
                    //// Nulo significa que chegou no final do arquivo.
                    //while(linha != null)
                    //{
                    //    // Escrevemos a linha no campo texto
                    //    this.textoConteudo.Text += linha;

                    //    // Pedimos uma nova linha para ler, se não o while fica em loop infinito 
                    //    // e nunca passaremos para a próxima linha.
                    //    linha = leitor.ReadLine();

                    //} // fim while

                    // Caso queira ler o arquivo inteiro e não precisa tratar linha por linha,
                    // O método ReadToEnd é melhor do que o código comentado acima
                    this.textoConteudo.Text = leitor.ReadToEnd();

                } // fim using
                
                // Fechando os processos. NÃO É UMA BOA PRÁTICA 
                // A boa prática é usar o using lá na criação do stream.
                //leitor.Close();
                //entrada.Close();

            } // fim if

        } // fim Form1_Load

        private void botaoGrava_Click(object sender, EventArgs e)
        {
            // Criamos um stream para escrever os bytes no arquivo.
            Stream saida = File.Open("texto.txt", FileMode.Create);

            // Criamos um processo para escrever em bytes no arquivo. 
            StreamWriter escritor = new StreamWriter(saida);

            // Escrevendo o conteúdo do campo texto inteiro no arquivo.
            escritor.Write(this.textoConteudo.Text);

            // Fechando os processos
            escritor.Close();
            saida.Close();

        } // fim botaoGrava_Click

    } // fim Form1

} // fim namespace
