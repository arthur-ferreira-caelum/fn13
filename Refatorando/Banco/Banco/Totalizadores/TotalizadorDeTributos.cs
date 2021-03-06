﻿
using Caelum.Banco.Tributacoes;

namespace Caelum.Banco.Totalizadores
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
            this.Total += t.CalculaTributos();
        } // fim Adiciona

    } // fim TotalizadorDeTributos

} // fim namespace
