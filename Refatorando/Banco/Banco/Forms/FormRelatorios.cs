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
            InitializeComponent();
            this.contas = contas;
        } // fim construtor

        /// <summary>
        /// Método acionado quando botão de filtro de saldo for clicado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botaoFiltroSaldo_Click(object sender, EventArgs e)
        {
            this.listaResultado.Items.Clear();
            var resultado = this.contas.Where(c => c.Saldo > 5000)
                                       .OrderBy(c => c.Titular.Nome)
                                       .ThenBy(c => c.Numero);
            
            foreach(var conta in resultado)
                this.listaResultado.Items.Add(conta);
            
            var saldoTotal = this.contas.Sum(c => c.Saldo);
            var maiorSaldo = this.contas.Max(c => c.Saldo);

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
            this.listaResultado.Items.Clear();
            var resultado = this.contas.Where(c => c.Numero < 10 && c.Saldo > 10000);
            foreach (var conta in resultado)
                this.listaResultado.Items.Add(conta);
        } // fim botaoAntigas_Click

    } // fim FormRelatorios

} // fim namespace
