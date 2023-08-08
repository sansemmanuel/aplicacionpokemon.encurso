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
//using pokemonnegocio;
namespace POKEMON
{
    public partial class frmAltaPokemon : Form
    {
        private pokemon Pokemon = null;
        public frmAltaPokemon()
        {
            InitializeComponent();
        }
        public frmAltaPokemon(pokemon Pokemon)
        {
            InitializeComponent();
            this.Pokemon = Pokemon;
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
                poke.UrlImagen = tbUrl.Text;
                poke.Tipo = (Elementos)cboType.SelectedItem;
                poke.Debilidad = (Elementos)cboWeak.SelectedItem;
                negocio.agregar(poke);
                MessageBox.Show("agregado exitosamente");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaPokemon_Load(object sender, EventArgs e)
        {
            elementonegocio elementoNegocio = new elementonegocio();
            try
            {
                cboType.ValueMember = "Id";
                cboType.DisplayMember = "Descripcion";
                cboWeak.DisplayMember = "Descripcion";
                cboWeak.DataSource = elementoNegocio.listar();
                cboType.DataSource = elementoNegocio.listar();
                cboWeak.DataSource = elementoNegocio.listar();
                if(Pokemon != null)
                {
                    tboxNumber.Text = Pokemon.Numero.ToString();
                    tboxName.Text = Pokemon.Nombre;
                    tbUrl.Text = Pokemon.UrlImagen;
                    tboxDesc.Text = Pokemon.Descripcion;
                    tbUrl.Text = Pokemon.UrlImagen;
                    cargarImagen(Pokemon.UrlImagen);
                    cboType.SelectedValue = Pokemon.Tipo.Id;
                    cboWeak.SelectedValue = Pokemon.Debilidad.Id;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void tboxDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblType_Click(object sender, EventArgs e)
        {

        }

        private void tbUrl_Leave(object sender, EventArgs e)
        {
            cargarImagen(tbUrl.Text);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxPokemon.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxPokemon.Load("https://images.pexels.com/photos/2882552/pexels-photo-2882552.jpeg");

            }
        }
    }
}
