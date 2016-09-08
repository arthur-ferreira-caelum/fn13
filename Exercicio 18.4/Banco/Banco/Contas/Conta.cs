
using Caelum.Banco.Clientes;

namespace Caelum.Banco.Contas
{
    /// <summary>
    /// Classe que define uma conta de banco
    /// 
    /// A classe precisa agora ser pública, pois poderá ser utilizada fora do assembly por causa do método Adiciona na classe Form1
    /// </summary>
    public abstract class Conta
    {
        // Atributo estático
        private static int numeroDeContas;

        // Propriedades
        // Agora que o número é gerado automaticamente pelo sistema, é uma boa prática tornar ele somente para leitura colocando private no set.
        public int Numero { get; private set; }
        public Cliente Titular { get; set; }
        // Agora o set é protected, para os filhos poderem manipular o Saldo tb
        public double Saldo { get; protected set; }

        /// <summary>
        /// Construtor sem argumentos de conta. 
        /// Sempre que uma conta for instanciada, independente de qual tipo, isso significa que aumentou o número de contas no nosso sistema.
        /// Logo, primeiro aumentamos o atributo estático que controla a quantidade de contas atualmente no sistema.
        /// Depois atribuimos esse valor ao número da nova conta. Assim, o número das contas será preenchido automaticamente.
        /// </summary>
        public Conta()
        {
            // Incrementa o número de contas todas as vezes que uma conta for construída.
            Conta.numeroDeContas++;

            // Atribui o novo valor ao número da conta criada neste momento.
            this.Numero = Conta.numeroDeContas;

        } // fim Construtor

        /// <summary>
        /// Realiza um depósito na conta.
        /// 
        /// O método é abstrato, forçando todas as subclasses de conta a terem estes métodos criados.
        /// </summary>
        /// <param name="valor">O valor a ser depositado</param>
        public abstract void Deposita(double valor);

        /// <summary>
        /// Realiza um saque na conta.
        /// 
        /// O método é abstrato, forçando todas as subclasses de conta a terem estes métodos criados.
        /// </summary>
        /// <param name="valor">O valor a ser retirado</param>
        public abstract void Saca(double valor);

        /// <summary>
        /// Realiza uma transferencia entre ontas.
        /// </summary>
        /// <param name="destino">A conta de destino para onde o valor deve ser transferido</param>
        /// <param name="valor">O valor a ser transferido</param>
        public void Transfere(Conta destino, double valor)
        {
            // Primeiro sacamos da conta de origem (this)
            this.Saca(valor);

            // Depois depositamos na conta de destino
            destino.Deposita(valor);

        } // fim Transfere

        /// <summary>
        /// Recupera o próximo número de conta que será utilizado.
        /// </summary>
        /// <returns>O número da próxima conta a ser criada</returns>
        public static int ProximoNumero()
        {
            return Conta.numeroDeContas + 1;

        } // fim ProximoNumero

        /// <summary>
        /// Sobrescrevendo o método ToString da classe Object para exibir o nome do titular
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            // Lembrando que a propriedade Titular tem que estar preenchida, se não vai dar NullReferenceException!
            return "Titular: " + this.Titular.Nome;

        } // fim ToString

    } // fim Conta

} // fim namespace