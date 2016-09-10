using System.Collections.Generic;

namespace Caelum.Banco.Busca
{
    /// <summary>
    /// Classe utilitária para gerar uma lista com muitos strings como nome.
    /// 
    /// Esse código não tem nenhuma aplicação prática, é apenas utilizado para testar o desempenho das listas.
    /// </summary>
    class GeradorDeDevedores
    {
        /// <summary>
        /// Método que gera uma lista de nomes genéricos somente para testar o desempenho das listas.
        /// </summary>
        /// <returns>Retorna a coleção de nomes</returns>
        public HashSet<string> GeraLista()
        {
            HashSet<string> nomes = new HashSet<string>();
            for (int i = 0; i < 30000; i++)
                nomes.Add("devedor " + i);

            return nomes;

        } // fim GeraLista
        //public List<string> GeraLista()
        //{
        //    List<string> nomes = new List<string>();
        //    for (int i = 0; i < 30000; i++)
        //        nomes.Add("devedor " + i);

        //    return nomes;
        //} // fim GeraLista

    } // fim GeradorDeDevedores

} // fim namespace
