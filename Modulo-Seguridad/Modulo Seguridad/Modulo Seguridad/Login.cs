using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modulo_Seguridad
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ucLogin1_Load(object sender, EventArgs e)
        {
          
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Formularios form = new Formularios();
           
            form.Show();
           
        }
    }
}
