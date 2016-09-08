using Caelum.Banco.Busca;
using Caelum.Banco.Clientes;
using Caelum.Banco.Contas;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Caelum.Banco.Forms
{
    /// <summary>
    /// Formulário de cadastro de clientes
    /// 
    /// Essa classe é partial, pois ela tem uma segunda parte no arquivo Form1.designer.cs que contém todo o código usado para desenhar os componentes. 
    /// Quando você altera qualquer coisa no modo Design, ele escreve nesse arquivo. Por isso é importante que não alteremos esse arquivo na mão, 
    /// quem manipula ele é o Visual Studio.
    /// </summary>
    public partial class FormCadastroConta : Form
    {

        // Atributos
        // Referencia para o formPrincipal (Form1)
        private Form1 formPrincipal;
        // Lista de devedores. Como eu quero mudar a implementação várias vezes para testes e não vou usar nenhum método específico
        // de nenhuma classe, melhor usar a interface.
        private ICollection<string> devedores;

        // Enum para a combo de tipo. Não falamos de Enums no curso, mas é uma ferramenta bastante útil para trabalharmos com tipos
        // como valor.
        enum TipoConta
        {
            // Nos enums, as opções sempre começam com o índice 0. Ou seja, o valor POUPANCA terá o índice 0
            POUPANCA,
            // Como o valor CORRENTE é o segundo, o índice dele será 1
            CORRENTE

        } // fim TipoConta

        /// <summary>
        /// Construtor que recebe o formPrincipal. O form de cadastro precisa obrigatoriamente da referência do form principal por causa 
        /// do vetor de contas, mais precisamente do método Adiciona que adiciona a nova conta ao vetor. Por esse motivo não temos o 
        /// construtor padrão nessa classe.
        /// </summary>
        /// <param name="formPrincipal"></param>
        public FormCadastroConta(Form1 formPrincipal)
        {
            // Instanciando atributo
            this.formPrincipal = formPrincipal;

            // Inicializando os componentes visuais (botões, labels, textboxes, etc.)
            InitializeComponent();

            GeradorDeDevedores gerador = new GeradorDeDevedores();
            this.devedores = gerador.GeraLista();
            
        } // fim Construtor

        /// <summary>
        /// Método executado quando o formulário termina de carregar e todos os componentes estão prontos para serem utilizados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCadastroConta_Load(object sender, EventArgs e)
        {
            // Exibindo no campo de texto o número que a conta receberá ao ser criadas.
            this.textoNumero.Text = Convert.ToString(Conta.ProximoNumero());

            // Populando a combo de tipo de conta
            comboTipo.Items.Add("Poupança");
            comboTipo.Items.Add("Corrente");

        } // fim FormCadastroConta_Load

        /// <summary>
        /// Metodo executado quando o botao cadastrar é clicado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botaoCadastrar_Click(object sender, EventArgs e)
        {
            // Recupero o nome digitado no campo do formulário
            string titular = this.textoTitular.Text;
            // Verifico se o nome existe na lista. A não ser que você tenha digitado um nome como "devedor 1", não será encontrado.
            // E não tem problema não encontrar! É de propósito. Queremos que o código percorra a coleção procurando pelo nome e não encontrar.
            bool ehDevedor = false;
            // Esse loop também não tem sentido prático nenhum, a não ser para testar a diferença de desempenho entre List e Set.
            for (int i = 0; i < 30000; i++)
            {
                ehDevedor = this.devedores.Contains(titular);

            } // fim for

            // Se for um devedor...
            if (ehDevedor)
            {
                // ...exibe mensagem de devedor
                MessageBox.Show("Devedor!");

            } // fim if
            else // ...caso contrário, continuar a criar a nova conta. 
            {
                // Declarando a variável da nova conta. Não foi incializada, pois vai depender do tipo de conta selecionado no formulário.
                Conta novaConta;

                // Recupera o índice selecionado na combo de tipo de conta.
                var indiceTipo = comboTipo.SelectedIndex;

                // Não falamos de switch no curso, mas ele é muito útil, principalmente nesses casos de tipo
                // Passamos para o switch a opção a ser verificada...
                switch (indiceTipo)
                {
                    // ...caso o indiceTipo seja do mesmo indice da POUPANCA no enum (ou seja, 0)
                    case (int)TipoConta.POUPANCA:
                        // Instancio a nova conta como poupança.
                        novaConta = new ContaPoupanca();

                        // Preciso colocar break aqui, pois já encontrei a opção que queria. Se não colocar break, o código
                        // continuará testando as outras opções do switch. Não é o que queremos.
                        break;
                    // ...caso o indiceTipo seja do mesmo indice da CORRENTE no enum (ou seja, 1)
                    case (int)TipoConta.CORRENTE:
                        // Instancio a nova conta como corrente.
                        novaConta = new ContaCorrente();

                        // Preciso colocar break aqui, pois já encontrei a opção que queria. Se não colocar break, o código
                        // continuará testando as outras opções do switch. Não é o que queremos.
                        break;

                    // Se não cair em nenhum caso acima, temos o cenário default
                    default:
                        // Agora não podemos mais instanciar uma Conta. Temos que escolher um dos tipos para ser o default.
                        //novaConta = new Conta();
                        novaConta = new ContaPoupanca();

                        // Apesar do default sempre ser a última opção do switch, é uma boa prática colocar o break.
                        break;

                } // fim switch

                // Atribui o número digitado no formulário à propriedade da instância criada.
                // Esse código agora não é mais utilizado. O número é gerado automaticamente.
                // novaConta.Numero = Convert.ToInt32(textoNumero.Text);

                // Cria uma nova instância do Cliente com o nome digitado no formulário.
                novaConta.Titular = new Cliente(textoTitular.Text);

                // Adiciona a nova conta criada ao vetor de contas em Form1
                this.formPrincipal.Adiciona(novaConta);

                // Exibe mensagem para o usuário informando que a conta foi criada com sucesso.
                MessageBox.Show("Conta criada com sucesso!");

                // Fecha o formulário de cadastro.
                this.Close();

            } // fim else

        } // fim botaoCadastrar_Click
        
    } // fim FormCadastroConta

} // fim namespace
