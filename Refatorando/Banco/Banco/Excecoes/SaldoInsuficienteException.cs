using System;

namespace Caelum.Banco.Excecoes
{
    /// <summary>
    /// Exception em casos de saldo insuficiente numa conta ao realizar qualquer operação que retire dinheiro de uma conta.
    /// </summary>
    class SaldoInsuficienteException : Exception
    {
        // Mensagem padrão
        private static string mensagemPadrao = "Não há saldo suficiente na conta para este valor!";

        /// <summary>
        /// Construtor sem argumentos
        /// </summary>
        public SaldoInsuficienteException() : base(SaldoInsuficienteException.mensagemPadrao) { }

        /// <summary>
        /// Construtor que recebe uma mensagem
        /// </summary>
        /// <param name="mensagem"></param>
        public SaldoInsuficienteException(string mensagem) : base(mensagem) { }
         
    } // fim SaldoInsuficienteException

} // fim namespace
