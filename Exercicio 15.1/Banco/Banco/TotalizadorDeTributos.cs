
namespace Banco
{
    /// <summary>
    /// Classe para acumular os tributos das contas.
    /// </summary>
    class TotalizadorDeTributos
    {
        // Propriedades
        public double Total { get; private set; }

        /// <summary>
        /// Adiciona o valor de tributo de uma referência tributável ao valor total.
        /// </summary>
        /// <param name="t">Referencia para um objeto tributável</param>
        public void Adiciona(ITributavel t)
        {
            // Adiciona o cálculo do tributo à variável total
            this.Total += t.CalculaTributos();

        } // fim Adiciona

    } // fim TotalizadorDeTributos

} // fim namespace
