
namespace OiMundo
{
    /// <summary>
    /// Classe que define uma conta de banco
    /// </summary>
    class Conta
    {
        // Atributos (agora como propriedades)
        public int Numero { get; set; }
        public Cliente Titular { get; set; }
        // Saldo com private set para evitar que não seja alterado fora da classe Conta.
        public double Saldo { get; private set; }

        /// <summary>
        /// Realiza um depósito na conta
        /// </summary>
        /// <param name="valor">O valor a ser depositado</param>
        public void Deposita(double valor)
        {
            // saldo = saldo + valor;
            this.Saldo += valor;

        } // fim deposita

        /// <summary>
        /// Realiza um saque na conta
        /// </summary>
        /// <param name="valor">O valor a ser retirado</param>
        /// <returns>Se for um sucesso, retorna verdadeiro. Caso contrário, retorna falso.</returns>
        //public void Saca(double valor)
        public bool Saca(double valor)
        {
            // saldo = saldo - valor;
            if ((valor > 0) && (this.Saldo >= valor) && (!this.Titular.EhMaiorDeIdade() && valor < 200))
            {
                this.Saldo -= valor;
                return true;
            }
            return false;

        } // fim Saca

        /// <summary>
        /// Realiza uma transferencia entre contas
        /// </summary>
        /// <param name="destino">A referência para a conta de destino</param>
        /// <param name="valor">O valor a ser transferido</param>
        public void Transfere(Conta destino, double valor)
        {
            // Tenta realizar um saque da conta de origem (this)
            bool sucesso = this.Saca(valor);

            // SE foi um sucesso...
            if (sucesso)
            {
                // ... deposita na conta de destino
                destino.Deposita(valor);

            } // fim if

        } // fim Transfere

    } // fim Conta

} // fim namespace
