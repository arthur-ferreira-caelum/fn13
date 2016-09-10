using Caelum.Banco.Excecoes;
using Caelum.Banco.Tributacoes;
using System;

namespace Caelum.Banco.Contas
{
    /// <summary>
    /// Classe que define uma conta corrente do banco.
    /// </summary>
    class ContaCorrente : Conta, ITributavel
    {
        /// <summary>
        /// Realiza um depósito na conta com uma taxa de 5 centavos por operação.
        /// </summary>
        /// <param name="valor">O valor a ser depositado</param>
        public override void Deposita(double valor)
        {
            if (valor < 0)
                throw new ArgumentException();

            this.Saldo += (valor - 0.05);
        } // fim Deposita

        /// <summary>
        /// Realiza um saque na conta com uma taxa de 10 centavos por operação.
        /// </summary>
        /// <param name="valor">O valor a ser retirado</param>
        public override void Saca(double valor)
        {
            if (valor < 0)
                throw new ArgumentException();

            if (this.Saldo < valor)
                throw new SaldoInsuficienteException();

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