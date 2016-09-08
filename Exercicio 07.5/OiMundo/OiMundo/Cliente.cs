
namespace OiMundo
{
    /// <summary>
    /// Classe que define um cliente de banco
    /// </summary>
    class Cliente
    {
        // Atributos (agora como propriedades)
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Endereco { get; set; }
        public int Idade { get; set; }

        /// <summary>
        /// Metodo que identifica se o cliente é maior de idade ou não
        /// </summary>
        /// <returns>Verdadeiro, se maior de idade. Falso, caso contrário.</returns>
        public bool EhMaiorDeIdade()
        {
            // Não precisamos usar um "if" aqui. Basta testar se a idade é maior ou igual a 18. Isso já retorna um valor booleano.
            return Idade >= 18;

        } // fim EhMaiorDeIdade()

    } // fim Cliente

} // fim namespace
