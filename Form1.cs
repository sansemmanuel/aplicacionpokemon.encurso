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
namespace POKEMON
{
    public partial class Form1 : Form
    {
        private List<pokemon> listapokemon;
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>

        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)


        {
            cargar();
        }


        private void dgvPokemon_SelectionChanged(object sender, EventArgs e)
        {
            pokemon seleccionado = (pokemon)dgvPokemon.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);
            //Elementos elem = new Elementos();
            //elem.ToString
        }

        private void cargar()
        {
            try
            {
                pokemonnegocio negocio = new pokemonnegocio();
                listapokemon = negocio.listar();
                dgvPokemon.DataSource = negocio.listar();
                dgvPokemon.Columns["UrlImagen"].Visible = false;
                cargarImagen(listapokemon[0].UrlImagen);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBoxPokemon.Load(imagen);
            }
            catch (Exception ex)
            {
                pictureBoxPokemon.Load("https://images.pexels.com/photos/2882552/pexels-photo-2882552.jpeg");

            }
        }


        private int currentIndex = 0;

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Verificar si hay al menos un registro en el DataGridView
            if (dgvPokemon.Rows.Count > 0)
            {
                // Incrementar el índice actual y asegurarse de que no se exceda del límite
                currentIndex++;
                if (currentIndex >= dgvPokemon.Rows.Count)
                {
                    currentIndex = 0;
                }

                dgvPokemon.ClearSelection();

                // Seleccionar la fila correspondiente al índice actual
                dgvPokemon.Rows[currentIndex].Selected = true;
                dgvPokemon.CurrentCell = dgvPokemon.Rows[currentIndex].Cells[0];
                dgvPokemon.FirstDisplayedScrollingRowIndex = currentIndex;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAltaPokemon alta = new frmAltaPokemon();
            alta.ShowDialog();
            cargar();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pokemon selected;
            selected = (pokemon)dgvPokemon.CurrentRow.DataBoundItem;
            frmAltaPokemon edit = new frmAltaPokemon(selected);
            edit.ShowDialog();
            cargar();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void btnLogi_Click(object sender, EventArgs e)
        {
            eliminar(true);
        }
        private void eliminar(bool logico = false)
        {
            pokemonnegocio negocio = new pokemonnegocio();
            pokemon seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (pokemon)dgvPokemon.CurrentRow.DataBoundItem;
                    if (logico)
                        negocio.eliminarLogi(seleccionado.Id);
                    else
                        negocio.eliminar(seleccionado.Id);
                    negocio.eliminar(seleccionado.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<pokemon> listaFiltrada;

            listaFiltrada = listapokemon.FindAll(x => x.Nombre == tbSearch.Text);

            dgvPokemon.DataSource = null;
            dgvPokemon.DataSource = listaFiltrada;
        }
    }
}

