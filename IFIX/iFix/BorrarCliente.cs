using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iFix
{
    public partial class BorrarCliente : Form
    {
        ifix_DBDataContext dc = new ifix_DBDataContext();
        public BorrarCliente()
        {
            InitializeComponent();
            this.CenterToScreen();
            mostrarClientes();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //dc.borrarCliente(cboxUsuarioEliminar.Text.ToString());
            MessageBox.Show("El cliente ha sido eliminado");
            this.Hide();
            Clientes cliente = new Clientes("ADMIIFIX");
            cliente.Show();
        }

        void mostrarClientes()
        {
           /* var clientes = from clt in dc.mostrarClientes() select new { clt.nombre, clt.usuario, clt.email };
            cboxUsuarioEliminar.DataSource = clientes.ToList();
            cboxUsuarioEliminar.DisplayMember = "nombre";*/

        }

        private void BorrarCliente_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes("ADMIIFIX");
            cliente.Show();
            this.Hide();
        }
    }
}
