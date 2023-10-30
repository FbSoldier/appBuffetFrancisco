using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appBuffetFrancisco.view
{
    public partial class LoginTela : Form
    {
        public LoginTela()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_acessar_Click(object sender, EventArgs e)
        {
            string usuario = txb_usuario.Text;
                string senha = txb_senha.Text;
            
            if(usuario== "admin" && senha == "123")
            {
                this.Visible = false;
               MenuTela Menu = new MenuTela();
                Menu.Show(this);
            }
            else
            {
                MessageBox.Show("Senha ou Usuario Incorretos");
            }
        }
    }
}
