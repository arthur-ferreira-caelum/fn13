
namespace Banco
{
    /// <summary>
    /// Classe que define uma conta poupança do banco.
    /// 
    /// Ela herda as propriedades e métodos não-privados da classe Conta.
    /// </summary>
    class ContaPoupanca : Conta
    {
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

    } // fim ContaPoupanca

} // fim namespace
