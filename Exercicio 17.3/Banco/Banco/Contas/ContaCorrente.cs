using Caelum.Banco.Excecoes;
using Caelum.Banco.Tributacoes;
using System;

namespace Caelum.Banco.Contas
{
    /// <summary>
    /// Classe que define uma conta corrente do banco.
    /// 
    /// Ela herda as propriedades e métodos não-privados da classe Conta.
    /// </summary>
    class ContaCorrente : Conta, ITributavel
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
            // Se o valor for negativo...
            if (valor < 0)
            {
                // ... Criamos uma exceção (erro) do tipo ArgumentException (Erro de argumento)
                throw new ArgumentException();

            } // fim if

            //base.Deposita(valor - 0.05);
            this.Saldo += (valor - 0.05);
        }

        /// <summary>
        /// Realiza um saque na conta com uma taxa de 10 centavos por operação.
        /// 
        /// O método é virtual para poder ser sobrescrito pelas classes filhas de conta.
        /// </summary>
        /// <param name="valor">O valor a ser retirado</param>
        public override void Saca(double valor)
        {
            // Se o valor for negativo...
            if (valor < 0)
            {
                // ... Criamos uma exceção (erro) do tipo ArgumentException (Erro de argumento)
                throw new ArgumentException();

            } // fim if

            // Se o saldo da conta for menor do que o valor de saque...
            if (this.Saldo < valor)
            {
                // ... criamos uma exceção de saldo insuficiente. Aqui eu não passei nenhuma mensagem.
                throw new SaldoInsuficienteException();

            } // fim if

            //base.Saca(valor + 0.10);
            this.Saldo -= (valor + 0.1);

        } // fim Saca

        /// <summary>
        /// Método implementado da interface ITributavel onde calcula os tributos da conta corrente.
        /// </summary>
        /// <returns>O gasto em tributos</returns>
        public double CalculaTributos()
        {
            return this.Saldo * 0.05;

        } // fim CalculaTributos

    } // fim ContaCorrente

} // fim namespace