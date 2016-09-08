
namespace Banco
{
    /// <summary>
    /// Classe que define uma conta de banco
    /// 
    /// A classe precisa agora ser pública, pois poderá ser utilizada fora do assembly por causa do método Adiciona na classe Form1
    /// </summary>
    public class Conta
    {
        // Propriedades
        public int Numero { get; set; }
        public Cliente Titular { get; set; }
        public double Saldo { get; private set; }

        /// <summary>
        /// Realiza um depósito na conta.
        /// 
        /// O método é virtual para poder ser sobrescrito pelas classes filhas de conta.
        /// </summary>
        /// <param name="valor">O valor a ser depositado</param>
        public virtual void Deposita(double valor)
        {
            this.Saldo += valor;

        } // fim Deposita

        /// <summary>
        /// Realiza um saque na conta.
        /// 
        /// O método é virtual para poder ser sobrescrito pelas classes filhas de conta.
        /// </summary>
        /// <param name="valor">O valor a ser retirado</param>
        public virtual void Saca(double valor)
        {
            this.Saldo -= valor;

        } // fim Saca

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