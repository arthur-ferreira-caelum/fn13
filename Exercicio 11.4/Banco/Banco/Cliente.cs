
namespace Banco
{
    /// <summary>
    /// Classe que define um cliente de banco
    /// </summary>
    class Cliente
    {
        // Propriedades
        public string Nome { get; set; }

        /// <summary>
        /// Construtor que recebe o nome do titular.
        /// </summary>
        /// <param name="nome"></param>
        public Cliente(string nome)
        {
            this.Nome = nome;

        } // fim Construtor com nome

    } // fim Cliente

} // fim namespace