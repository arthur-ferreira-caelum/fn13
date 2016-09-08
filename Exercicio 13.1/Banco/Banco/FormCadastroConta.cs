using System;
using System.Windows.Forms;

namespace Banco
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

            // Populando a combo de tipo de conta
            comboTipo.Items.Add("Poupança");
            comboTipo.Items.Add("Corrente");

        } // fim Construtor

        /// <summary>
        /// Metodo executado quando o botao cadastrar é clicado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botaoCadastrar_Click(object sender, EventArgs e)
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
            novaConta.Numero = Convert.ToInt32(textoNumero.Text);

            // Cria uma nova instância do Cliente com o nome digitado no formulário.
            novaConta.Titular = new Cliente(textoTitular.Text);

            // Adiciona a nova conta criada ao vetor de contas em Form1
            this.formPrincipal.Adiciona(novaConta);

            // Exibe mensagem para o usuário informando que a conta foi criada com sucesso.
            MessageBox.Show("Conta criada com sucesso!");

            // Fecha o formulário de cadastro.
            this.Close();

        } // fim botaoCadastrar_Click

    } // fim FormCadastroConta

} // fim namespace
