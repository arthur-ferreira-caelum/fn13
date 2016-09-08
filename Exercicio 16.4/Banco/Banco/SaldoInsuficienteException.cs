using System;

namespace Banco
{
    /// <summary>
    /// Exception em casos de saldo insuficiente numa conta ao realizar qualquer operação que retire dinheiro de uma conta.
    /// </summary>
    class SaldoInsuficienteException : Exception
    {
        // Este código não está na apostila, mas eu acho legal colocar.
        // Se eu quiser ter uma mensagem padrão para este tipo de erro ao criar a exceção? Posso criar uma variável estática com a mensagem:
        private static string mensagem = "Não há saldo suficiente na conta para este valor!";

        // Para essa mensagem ser utilizada por padrão, precisamos enviar ela para o construtor da superclasse Exception
        // Isso é feito através do construtor...
        public SaldoInsuficienteException() : base(SaldoInsuficienteException.mensagem)
        {
            // Não precisamos de nada no corpo do construtor, o que precisamos já foi feito na assinatura, que foi passar a mensagem padrão.

        } // fim construtor

        // E se eu também quisesse, opcionalmente, dar a opção ao desenvolvedor que usar a classe de passar a mensagem que ele quiser?
        // Podemos ter outro construtor que receba essa mensagem...
        public SaldoInsuficienteException(string mensagem) : base(mensagem)
        {
            // Novamente, nao precisamos de nada no corpo do construtor.

        } // fim SaldoInsuficienteException

    } // fim SaldoInsuficienteException

} // fim namespace
