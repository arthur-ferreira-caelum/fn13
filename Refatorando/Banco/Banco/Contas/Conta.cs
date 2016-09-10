using Caelum.Banco.Clientes;

namespace Caelum.Banco.Contas
{
    /// <summary>
    /// Classe que define uma conta de banco
    /// </summary>
    public abstract class Conta
    {
        // Atributo estático
        private static int numeroDeContas;

        // Propriedades
        public int Numero { get; private set; }
        public Cliente Titular { get; set; }
        public double Saldo { get; protected set; }

        /// <summary>
        /// Construtor sem argumentos 
        /// </summary>
        public Conta()
        {
            Conta.numeroDeContas++;
            this.Numero = Conta.numeroDeContas;
        } // fim Construtor sem argumentos

        /// <summary>
        /// Realiza um depósito na conta.
        /// </summary>
        /// <param name="valor">O valor a ser depositado</param>
        public abstract void Deposita(double valor);

        /// <summary>
        /// Realiza um saque na conta.
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
            this.Saca(valor);
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
            return "Titular: " + this.Titular.Nome;
        } // fim ToString

    } // fim Conta

} // fim namespace