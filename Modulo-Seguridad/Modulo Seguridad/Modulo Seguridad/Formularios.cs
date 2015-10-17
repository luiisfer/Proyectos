using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seguridad;

namespace Modulo_Seguridad
{
    public partial class Formularios : Form
    {
        public Formularios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmManejoRoles roles = new frmManejoRoles();
            roles.Show();
        }

        private void Formularios_Load(object sender, EventArgs e)
        {

        }
    }
}
