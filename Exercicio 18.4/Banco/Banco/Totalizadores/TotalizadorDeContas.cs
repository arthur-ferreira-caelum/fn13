
using Caelum.Banco.Contas;

namespace Caelum.Banco.Totalizadores
{
    /// <summary>
    /// Classe que acumula o saldo total das contas adicionadas.
    /// 
    /// O objetivo dessa classe é só para testar e ver na prática como funciona o polimorfismo
    /// </summary>
    class TotalizadorDeContas
    {
        // Propriedades
        public double SaldoTotal { get; private set; }

        /// <summary>
        /// Metodo que adiciona o saldo de uma conta ao total. O método só precisa de uma referência de conta,
        /// não importando se o tipo do objeto é Conta, ContaCorrente, ContaPoupanca, etc. O polimorfismo garante
        /// que não importa o tipo de objeto, todos são uma conta que possuem saldo.
        /// </summary>
        /// <param name="conta">Referência da conta a ser adicionada</param>
        public void Adiciona(Conta conta)
        {
            this.SaldoTotal += conta.Saldo;

        } // fim Adiciona

    } // fim TotalizadorDeContas

} // fim namespace
