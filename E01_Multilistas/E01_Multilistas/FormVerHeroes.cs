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
    public partial class FormVerHeroes : Form
    {
        private HeroeServicios heroeServicios = new HeroeServicios();
        private String codigoAlbum;
        public FormVerHeroes()
        {
            InitializeComponent();
        }

        private void FormVerHeroes_Load(object sender, EventArgs e)
        {

        }

        private void MostrarHeroe(List<Heroe> heroes)
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

        public FormVerHeroes(String codigoAlbum)
        {
            InitializeComponent();
            this.codigoAlbum = codigoAlbum;
            MostrarHeroe(heroeServicios.ListarTodoPorAlbum(codigoAlbum));
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //validacion de campos
            if(tbNombre.Text=="" || tbCodigo.Text=="" || tbCaracteristica.Text=="" || tbPoder.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            Heroe heroe = new Heroe()
            {
                Codigo = tbCodigo.Text,
                Nombre = tbNombre.Text,
                Poder = double.Parse(tbPoder.Text),
                Carcteristica = tbCaracteristica.Text
            };
            //registramos
            bool registrado = heroeServicios.Registrar(codigoAlbum, heroe);
            //msotrar
            MostrarHeroe(heroeServicios.ListarTodoPorAlbum(codigoAlbum));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
