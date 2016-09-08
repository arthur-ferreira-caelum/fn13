using System;

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
            // Se o valor for negativo...
            if (valor < 0)
            {
                // ... Criamos uma exceção (erro) do tipo ArgumentException (Erro de argumento)
                throw new ArgumentException();

            } // fim if

            // Se o saldo da conta for menor do que o valor de saque...
            if (this.Saldo < valor)
            {
                // ... criamos uma exceção de saldo insuficiente. Aqui eu resolvi passar a mensagem pelo construtor.
                throw new SaldoInsuficienteException("Saldo insuficiente!");
                
            } // fim if

            // Agora não podemos mais usar o operador "base" para acessar o método da superclasse, pois ele é abstrato e não tem corpo.
            // O método é obrigado a implementar seu comportamento exclusivo.
            //base.Saca(valor + 0.10);
            this.Saldo -= (valor + 0.10);

        } // fim Saca


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

            // Agora não podemos mais usar o operador "base" para acessar o método da superclasse, pois ele é abstrato e não tem corpo.
            // O método é obrigado a implementar seu comportamento exclusivo.
            this.Saldo += (valor);

        } // fim Deposita

    } // fim ContaPoupanca

} // fim namespace
