using System;
using System.IO;

namespace Caelum.TextoNoTerminal
{
    /// <summary>
    /// Classe de início do sistema. 
    /// 
    /// Ela possui o método Main, que a máquina virtual do .NET irá procurar para iniciar o programa.
    /// 
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método main padrão que o .NET procura para iniciar um sistema.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // A primeira coisa que o programa irá executar, é imprimir essa mensagem no terminal (console).
            Console.WriteLine("Mensagem que vai para o terminal");

            // Logo em seguida, esperamos o usuário digitar alguma coisa no terminal.
            using (TextReader leitor = Console.In)
            using (Stream saida = File.Open("texto.txt", FileMode.Create))
            using (TextWriter escritor = new StreamWriter(saida))
            {
                // Assim que ele escrever algo, o programa lê e imprime o que ele digitou em seguida.
                // Esse processo irá se repetir até que o usuário entre com o comando de fim de arquivo.
                // O atalho de fim de arquivo é o CTRL+Z
                string linha = leitor.ReadLine();
                while (linha != null)
                {
                    // Exibindo o texto digitado
                    Console.WriteLine("Texto digitado: " + linha);

                    // Isso não tem na apostila, mas seria legal também escrever num arquivo o que foi digitado
                    escritor.WriteLine(linha);

                    // Escrevemos uma linha vazia para dar um espaço em branco
                    Console.WriteLine("");

                    // Lemos a linha de novo para não entrar no loop infinito.
                    linha = leitor.ReadLine();

                } // fim while

            } // fim using

        } // fim Main

    } // fim Program

} // fim namespace
