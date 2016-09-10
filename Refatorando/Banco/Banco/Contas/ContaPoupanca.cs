using Caelum.Banco.Excecoes;
using System;

namespace Caelum.Banco.Contas
{
    /// <summary>
    /// Classe que define uma conta poupança do banco.
    /// </summary>
    class ContaPoupanca : Conta
    {
        /// <summary>
        /// Realiza um saque na conta com uma taxa de 10 centavos por operação.
        /// </summary>
        /// <param name="valor">O valor a ser retirado</param>
        public override void Saca(double valor)
        {
            if (valor < 0)
                throw new ArgumentException();

            if (this.Saldo < valor)
                throw new SaldoInsuficienteException("Saldo insuficiente!");

            this.Saldo -= (valor + 0.10);
        } // fim Saca


        /// <summary>
        /// Realiza um depósito na conta com uma taxa de 5 centavos por operação.
        /// </summary>
        /// <param name="valor">O valor a ser depositado</param>
        public override void Deposita(double valor)
        {
            if (valor < 0)
                throw new ArgumentException();

            this.Saldo += (valor);
        } // fim Deposita

    } // fim ContaPoupanca

} // fim namespace
