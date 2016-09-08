
namespace Banco
{
    /// <summary>
    /// Classe que define uma conta de banco
    /// 
    /// A classe precisa agora ser pública, pois poderá ser utilizada fora do assembly por causa do método Adiciona na classe Form1
    /// </summary>
    public abstract class Conta
    {
        // Propriedades
        public int Numero { get; set; }
        public Cliente Titular { get; set; }
        // Agora o set é protected, para os filhos poderem manipular o Saldo tb
        public double Saldo { get; protected set; }

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

    } // fim Conta

} // fim namespace