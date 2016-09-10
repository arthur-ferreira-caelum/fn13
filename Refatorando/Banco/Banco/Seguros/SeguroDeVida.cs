
using Caelum.Banco.Tributacoes;

namespace Caelum.Banco.Seguros
{
    /// <summary>
    /// Classe que representa um seguro de vida
    /// </summary>
    class SeguroDeVida : ITributavel
    {
        /// <summary>
        /// Método implementado da interface ITributavel com o cálculo de tributos de um seguro de vida.
        /// </summary>
        /// <returns>O tributo calculado</returns>
        public double CalculaTributos()
        {
            return 42;
        } // fim CalculaTributos

    } // fim SeguroDeVida

} // fim namespace
