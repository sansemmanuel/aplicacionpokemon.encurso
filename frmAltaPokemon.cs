using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using pokemonnegocio;
namespace POKEMON
{
    public partial class frmAltaPokemon : Form
    {
        public frmAltaPokemon()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            pokemon poke = new pokemon();
            pokemonnegocio negocio = new pokemonnegocio();
            try
            {
                poke.Numero = int.Parse(tboxNumber.Text);
                poke.Nombre = tboxName.Text;
                poke.Descripcion = tboxDesc.Text;
                negocio.agregar(poke);
                MessageBox.Show("agregado exitosamente");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
