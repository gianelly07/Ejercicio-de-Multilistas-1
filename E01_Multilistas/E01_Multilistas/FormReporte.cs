using System;
using System.Collections.Generic;
using System.ComponentModel;
using E01_Multilistas.Entities;
using E01_Multilistas.Services;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E01_Multilistas
{
    public partial class FormReporte : Form
    {
        private AlbumServicios albumServicios = new AlbumServicios();
        private HeroeServicios heroeServicios = new HeroeServicios();
        public FormReporte()
        {
            InitializeComponent();
        }

        private void MostrarAlbumes(List<Album> albums)
        {
            dgvAlbumes.DataSource = null;
            if(albums.Count == 0)
            {
                return;
            }
            else
            {
                dgvAlbumes.DataSource = albums;
            }
        }
        private void MostrarHeroes(List<Heroe> heroes)
        {
            dgvHeroes.DataSource = null;
            if(heroes.Count == 0)
            {
                return;
            }
            else
            {
                dgvHeroes.DataSource = heroes;
            }
        }

        private void btnObtenerAlbumConMasHeroe_Click(object sender, EventArgs e)
        {
            MostrarAlbumes(albumServicios.ListarAlbumConMasHeroe());
        }

        private void btnListarAbumSegunHeroes_Click(object sender, EventArgs e)
        {
            if (tbCodigoAlbum.Text == "")
            {
                MessageBox.Show("Ingrese codigo");
                return;
            }
            String codigoHeroe = tbCodigoHeroe.Text;
            MostrarAlbumes(albumServicios.BuscarAlbumQueTengaHeroe(codigoHeroe));
        }

        private void btnObtenerHeroeConMenorPoder_Click(object sender, EventArgs e)
        {
            if(tbCodigoAlbum.Text == "")
            {
                MessageBox.Show("Ingrese codigo");
                return;
            }
            String codigoAlbum = tbCodigoAlbum.Text;
            MostrarHeroes(heroeServicios.ListarHeroeDeMenorPoder(codigoAlbum));
        }

        private void btnObtenerHeroeConMayorPoder_Click(object sender, EventArgs e)
        {
            if (tbCodigoAlbum.Text == "")
            {
                MessageBox.Show("Ingrese codigo");
                return;
            }
            String codigoAlbum = tbCodigoAlbum.Text;
            MostrarHeroes(heroeServicios.ListarHeroeDeMayorPoder(codigoAlbum));
        }
    }
}
