
namespace Banco
{
    /// <summary>
    /// Interface para qualquer classe que tenha o contrato de cálculo de tributos como comportamento obrigatório
    /// </summary>
    interface ITributavel
    {
        /// <summary>
        /// O método que a classe deve implementar com o cálculo de tributos segundo sua lógica específica.
        /// </summary>
        /// <returns>O valor do tributo calculado</returns>
        double CalculaTributos();

    } // fim ITributavel

} // fim namespace
