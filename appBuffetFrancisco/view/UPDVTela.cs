using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appBuffetFrancisco.view
{
    public partial class UPDVTela : Form
    {
        int totalfinal = 0;
        public UPDVTela()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            lbl_valortotal.Text = string.Empty;
            tbx_codigo.Text = string.Empty;
            numericUpDown1.Value = 0;
            dataGridView1.Rows.Clear();
            totalfinal = 0;
        }

        private void btn_pastel_Click(object sender, EventArgs e)
        {
            string registrosPastel = "12";
            tbx_codigo.Text = registrosPastel;
        }

        private void btn_coxinha_Click(object sender, EventArgs e)
        {
            string registrosCoxinha = "13";
            tbx_codigo.Text = registrosCoxinha;
        }

        private void btn_esfiha_Click(object sender, EventArgs e)
        {
            string registrosEsfiha = "14";
            tbx_codigo.Text = registrosEsfiha;
        }

        private void btn_bolin_Click(object sender, EventArgs e)
        {
            string registrosBolin = "15";
            tbx_codigo.Text = registrosBolin;
        }

        private void btn_suco_Click(object sender, EventArgs e)
        {
            string registrosSuco = "16";
            tbx_codigo.Text = registrosSuco;
        }

        private void btn_cafe_Click(object sender, EventArgs e)
        {
            String registrosCafe = "17";
            tbx_codigo.Text = registrosCafe;
        }

        private void btn_refri_Click(object sender, EventArgs e)
        {
            string registrosRefri = "18";
            tbx_codigo.Text = registrosRefri;
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(tbx_codigo.Text);
            int qtd = ((int)numericUpDown1.Value);

            string[] itens = { "pastel", "coxinha", "esfiha", "Bolin", "suco", "cafe", "refri" };
            int[] valor = { 8, 8, 8, 8, 12, 12, 12 };

            int total = qtd * valor[codigo - 12];

            totalfinal += total;

            dataGridView1.Rows.Add(itens[codigo - 12], qtd, valor[codigo - 11], total);

            lbl_valortotal.Text = "R$" + totalfinal.ToString() + ",00";


        }

        private void btn_receber_Click(object sender, EventArgs e)
        {
            TelaFechar telaFechar = new TelaFechar();

            telaFechar.Show();
        }
    }
}
