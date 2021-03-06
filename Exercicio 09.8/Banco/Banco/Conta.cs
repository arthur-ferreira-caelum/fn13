﻿
namespace Banco
{
    /// <summary>
    /// Classe que define uma conta de banco
    /// </summary>
    class Conta
    {
        // Propriedades
        public int Numero { get; set; }
        public Cliente Titular { get; set; }
        public double Saldo { get; private set; }

        /// <summary>
        /// Realiza um depósito na conta
        /// </summary>
        /// <param name="valor">O valor a ser depositado</param>
        public void Deposita(double valor)
        {
            this.Saldo += valor;

        } // fim Deposita

        /// <summary>
        /// Realiza um saque na conta
        /// </summary>
        /// <param name="valor">O valor a ser retirado</param>
        public void Saca(double valor)
        {
            this.Saldo -= valor;

        } // fim Saca

    } // fim Conta

} // fim namespace