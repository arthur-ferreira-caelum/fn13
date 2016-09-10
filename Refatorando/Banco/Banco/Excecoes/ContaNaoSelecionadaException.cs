using System;

namespace Caelum.Banco.Excecoes
{
    /// <summary>
    /// Exception em casos uma conta não ter sido selecionada
    /// </summary>
    class ContaNaoSelecionadaException : Exception
    {
        /// <summary>
        /// Construtor que recebe uma mensagem
        /// </summary>
        /// <param name="mensagem"></param>
        public ContaNaoSelecionadaException(string mensagem) : base(mensagem) { }
         
    } // fim SaldoInsuficienteException

} // fim namespace
