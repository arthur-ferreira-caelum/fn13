using Caelum.Banco.Contas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Caelum.Banco.Forms
{
    /// <summary>
    /// Classe do formulário de relatórios onde iremos filtrar a lista de contas de acordo com algumas condições
    /// 
    /// Essa classe é partial, pois ela tem uma segunda parte no arquivo Form1.designer.cs que contém todo o código usado para desenhar os componentes. 
    /// Quando você altera qualquer coisa no modo Design, ele escreve nesse arquivo. Por isso é importante que não alteremos esse arquivo na mão, 
    /// quem manipula ele é o Visual Studio.
    /// </summary>
    public partial class FormRelatorios : Form
    {
        // Atributos
        private List<Conta> contas;

        /// <summary>
        /// Construtor que recebe a referência para a lista de contas.
        /// </summary>
        public FormRelatorios(List<Conta> contas)
        {
            // Inicializando os componentes visuais.
            InitializeComponent();

            // Incializando os atributos.
            this.contas = contas;

        } // fim construtor

        /// <summary>
        /// Método acionado quando botão de filtro de saldo for clicado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botaoFiltroSaldo_Click(object sender, EventArgs e)
        {
            // Limpando o listbox de possíveis resultados anteriores
            this.listaResultado.Items.Clear();
            
            // Filtra a lista de contas com saldo maior do que 5000
            var resultado = this.contas.Where(c => c.Saldo > 5000)
                                       .OrderBy(c => c.Titular.Nome)
                                       .ThenBy(c => c.Numero);
            
            // Adiciona cada conta ao listbox
            foreach(var conta in resultado)
            {
                this.listaResultado.Items.Add(conta);

            } // fim foreach
            
            // Recuperando a soma total de todos os saldos das contas filtradas
            double saldoTotal = this.contas.Sum(c => c.Saldo);

            // Recuperando o saldo de maior valor das contas filtradas
            double maiorSaldo = this.contas.Max(c => c.Saldo);

            // Atribuindo os valores às labels criadas
            this.labelSaldoTotal.Text = Convert.ToString(saldoTotal);
            this.labelMaiorSaldo.Text = Convert.ToString(maiorSaldo);

        } // fim botaoFiltroSaldo_Click

        /// <summary>
        /// Método acionado quando o botão antigas é clicado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botaoAntigas_Click(object sender, EventArgs e)
        {
            // Limpando o listbox de possíveis resultados anteriores
            this.listaResultado.Items.Clear();

            // Filtra a lista de contas com saldo maior do que 10000
            var resultado = this.contas.Where(c => c.Numero < 10 && c.Saldo > 10000);

            // Adiciona cada conta ao listbox           
            foreach (var conta in resultado)
            {
                this.listaResultado.Items.Add(conta);

            } // fim foreach

        } // fim botaoAntigas_Click

    } // fim FormRelatorios

} // fim namespace
