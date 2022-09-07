using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_sin_basedatos
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Ingresarbtn_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {
                MessageBox.Show("tiene q ingresar un usuario");
                return;
            }

            MessageBox.Show("usted a ingreasado al sistema");
            this.Close();
        }
    }
}
