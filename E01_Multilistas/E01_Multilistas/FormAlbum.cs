using E01_Multilistas.Entities;
using E01_Multilistas.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E01_Multilistas
{
    public partial class FormAlbum : Form
    {
        private AlbumServicios albumServicios = new AlbumServicios();
        public FormAlbum()
        {
            InitializeComponent();
            MostrarAlbumes(albumServicios.ListarTodo());
        }

        private void FormAlbum_Load(object sender, EventArgs e)
        {

        }

        private void MostrarAlbumes(List<Album> albumes)
        {
            dgvAlbumes.DataSource = null;
            if(albumes.Count == 0)
            {
                return;
            }
            else
            {
                dgvAlbumes.DataSource = albumes;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(tbCodigo.Text == "" || tbNombre.Text== "")
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }
            Album album = new Album();
            album.Codigo = tbCodigo.Text;
            album.Nombre = tbNombre.Text;
            album.Heroes = new List<Heroe>();

            if (albumServicios.Registrar(album))
            {
                MessageBox.Show("Album registrado correctamente");
                MostrarAlbumes(albumServicios.ListarTodo());
                tbCodigo.Clear();
                tbNombre.Clear();
                tbCodigo.Focus();
            }
            else
            {
                MessageBox.Show("Ya existe un album con ese codigo");
            }
        }

        private void btnVerHeroes_Click(object sender, EventArgs e)
        {

            if (dgvAlbumes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un registro");
                return;
            }
            String codigoAlbum = dgvAlbumes.SelectedRows[0].Cells[0].Value.ToString();
            FormVerHeroes form = new FormVerHeroes(codigoAlbum);
            form.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FormReporte form = new FormReporte();
            form.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
