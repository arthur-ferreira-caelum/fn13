namespace Caelum.Banco.Clientes
{
    /// <summary>
    /// Classe que define um cliente de banco
    /// </summary>
    public class Cliente
    {
        // Propriedades
        public string Nome { get; set; }
        public int Rg { get; set; }

        /// <summary>
        /// Construtor que recebe o nome do cliente.
        /// </summary>
        /// <param name="nome">O nome do cliente</param>
        public Cliente(string nome)
        {
            this.Nome = nome;
        } // fim Construtor com nome

        /// <summary>
        /// Sobrescreve o comportamento padrão do equals da classe object comparando o nome e o rg desta referência
        /// com a referência passada por parâmetro
        /// </summary>
        /// <param name="obj">Uma instância de object recebida por parâmetro</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (! (obj is Cliente) )
            {
                return false;
            } // fim if

            var outroCliente = (Cliente) obj;

            return this.Nome.Equals(outroCliente.Nome) && this.Rg == outroCliente.Rg;
        } // fim Equals

        /// <summary>
        /// Sobrescrevendo o método ToString da classe Object para exibir o nome do titular e o Rg
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Nome + " - " + this.Rg;
        } // fim ToString

    } // fim Cliente

} // fim namespace