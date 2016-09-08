
namespace Caelum.Banco.Clientes
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
        public int Rg { get; set; }


        /// <summary>
        /// Construtor que recebe o nome do titular.
        /// </summary>
        /// <param name="nome"></param>
        public Cliente(string nome)
        {
            this.Nome = nome;

        } // fim Construtor com nome

        /// <summary>
        /// Sobrescreve o comportamento padrão do equals da classe object comparando o nome e o rg desta referência
        /// com a referência passada por parâmetro
        /// </summary>
        /// <param name="obj">Uma instância de object recebida por parâmetro. Como estamos sobrescrevendo o método de object, tem que ser do mesmo tipo. Nâo podemos mudar o tipo para Cliente, se não o override não funciona.</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            // Primeiro, testamos para saber se a referência passada é do tipo Cliente.
            // Se a referência não for um Cliente, nem adianta continuar. Obviamente não é igual
            if (! (obj is Cliente) )
            {
                return false;

            } // fim if

            // Agora que garantimos que a referência é um Cliente, podemos fazer um casting para uma variável do tipo Cliente:
            Cliente outroCliente = (Cliente) obj;

            // E agora podemos comparar as propriedades
            // Lembrando que nome é do tipo string e é uma classe!!! Ou seja, usar o método Equals!!! 
            // Não se compara strings com ==
            return this.Nome.Equals(outroCliente.Nome) && this.Rg == outroCliente.Rg;

        } // fim Equals

        /// <summary>
        /// Sobrescrevendo o método ToString da classe Object para exibir o nome do titular e o Rg
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Nome + " - " + this.Rg;
        }

    } // fim Cliente

} // fim namespace