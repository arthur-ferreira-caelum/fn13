
using Caelum.Banco.Contas;

namespace Caelum.Banco.Totalizadores
{
    /// <summary>
    /// Classe que acumula o saldo total das contas adicionadas.
    /// </summary>
    class TotalizadorDeContas
    {
        // Propriedades
        public double SaldoTotal { get; private set; }

        /// <summary>
        /// Metodo que adiciona o saldo de uma conta ao total. 
        /// </summary>
        /// <param name="conta">Referência da conta a ser adicionada</param>
        public void Adiciona(Conta conta)
        {
            this.SaldoTotal += conta.Saldo;
        } // fim Adiciona

    } // fim TotalizadorDeContas

} // fim namespace
