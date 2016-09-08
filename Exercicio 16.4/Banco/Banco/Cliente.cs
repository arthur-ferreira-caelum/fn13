
namespace Banco
{
    /// <summary>
    /// Classe que define um cliente de banco
    /// 
    /// A classe precisa agora ser pública, pois poderá ser utilizada fora do assembly por causa do método Adiciona na classe Form1
    /// </summary>
    public class Cliente
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