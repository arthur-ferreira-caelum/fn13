using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OiMundo
{
    /// <summary>
    /// Classe que define uma conta de banco
    /// </summary>
    class Conta
    {
        // Atributos
        public int numero;
        public double saldo;
        // Agora o titular não é mais somente uma String que recebe o nome, agora é uma classe composta de atributos com informações específicas do cliente.
        // public String titular;
        //public int idade;
        public Cliente titular;
        
        // Agora a o atributo idade não pertence mais à Conta. Ele é uma informação do cliente, logo, deve pertencer à classe Cliente. 
        // Portanto, vou deixar comentado só por motivos de registro, mas poderíamos excluir esse atributo se fosse no mercado de trabalho.
        //public int idade;

        /// <summary>
        /// Realiza um depósito na conta
        /// </summary>
        /// <param name="valor">O valor a ser depositado</param>
        public void Deposita(double valor)
        {
            // this.saldo = this.saldo + valor;
            // É uma boa prática sempre utilizar o operador "this" quando fizer referência a um atributo ou propriedade da classe.
            this.saldo += valor;

        } // fim deposita

        /// <summary>
        /// Realiza um saque na conta
        /// </summary>
        /// <param name="valor">O valor a ser retirado</param>
        /// <returns>Se for um sucesso, retorna verdadeiro. Caso contrário, retorna falso.</returns>
        //public void Saca(double valor)
        public bool Saca(double valor)
        {
            // saldo = saldo - valor;
            // SE o saldo for maior do que valor E idade menor do que 18 E valor menor do que 200...
            if ((valor > 0) && (this.saldo >= valor) && (!this.titular.EhMaiorDeIdade() && valor < 200))
            { 
                // ... realiza o saque
                this.saldo -= valor;
                return true;

            } // fim if

            // Caso contrário, falhou
            return false;

        } // fim Saca
        
        /// <summary>
        /// Realiza uma transferencia entre contas
        /// </summary>
        /// <param name="destino">A referência para a conta de destino</param>
        /// <param name="valor">O valor a ser transferido</param>
        public void Transfere(Conta destino, double valor)
        {
            // Tenta realizar um saque da conta de origem (this)
            bool sucesso = this.Saca(valor);

            // SE foi um sucesso...
            if (sucesso)
            {
                // ... deposita na conta de destino
                destino.Deposita(valor);

            } // fim if

        } // fim Transfere

    } // fim Conta

} // fim namespace
