
namespace Banco
{
    /// <summary>
    /// Classe que define uma conta corrente do banco.
    /// 
    /// Ela herda as propriedades e métodos não-privados da classe Conta.
    /// </summary>
    class ContaCorrente : Conta
    {
        /// <summary>
        /// Realiza um depósito na conta com uma taxa de 5 centavos por operação.
        /// 
        /// O método sobrescreve o comportamento original da classe Conta. 
        /// Isso só é possível por causa da herança e devido ao método da superclasse ser virtual.
        /// </summary>
        /// <param name="valor">O valor a ser depositado</param>
        public override void Deposita(double valor)
        {
            // Aqui usamos o operador "base" para reaproveitar o código que já existe na superclasse.
            // Basta subtrairmos a taxa a ser cobrada no valor do depósito.
            base.Deposita(valor - 0.05);

        } // fim Deposita

        /// <summary>
        /// Realiza um saque na conta com uma taxa de 10 centavos por operação.
        /// 
        /// O método é virtual para poder ser sobrescrito pelas classes filhas de conta.
        /// </summary>
        /// <param name="valor">O valor a ser retirado</param>
        public override void Saca(double valor)
        {
            // Aqui usamos o operador "base" para reaproveitar o código que já existe na superclasse.
            // Basta adicionarmos a taxa a ser cobrada no valor do depósito.
            base.Saca(valor + 0.10);

        } // fim Saca

    } // fim ContaCorrente

} // fim namespace
