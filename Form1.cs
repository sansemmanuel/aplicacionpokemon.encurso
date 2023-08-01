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
            pokemonnegocio negocio = new pokemonnegocio();
            listapokemon = negocio.listar();
            dgvPokemon.DataSource = negocio.listar();
            dgvPokemon.Columns["UrlImagen"].Visible = false;
            cargarImagen(listapokemon[0].UrlImagen);
        }

        private void dgvPokemon_SelectionChanged(object sender, EventArgs e)
        {
           pokemon seleccionado =(pokemon) dgvPokemon.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);
            //Elementos elem = new Elementos();
            //elem.ToString
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBoxPokemon.Load(imagen);
            }
            catch (Exception ex)
            {
                pictureBoxPokemon.Load("https://upload.wikimedia.org/wikipedia/commons/6/65/No-Image-Placeholder.svg");
                
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
        }
    }
}

