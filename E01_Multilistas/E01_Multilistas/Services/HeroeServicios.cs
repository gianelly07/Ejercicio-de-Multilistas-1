using E01_Multilistas.Repositories;
using System;
using System.Collections.Generic;
using E01_Multilistas.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_Multilistas.Services
{
    internal class HeroeServicios
    {
        private HeroeRepositorio heroeRepositorio = new HeroeRepositorio();

        public bool Registrar(String codigoAlbum, Heroe heroe)
        {
            if (heroeRepositorio.Existe(codigoAlbum, heroe.Codigo))
            {
                return false;
            }
            else
            {
                heroeRepositorio.Registrar(codigoAlbum, heroe);
                return true;
            }
        }

        public List<Heroe> ListarTodoPorAlbum(String codigoAlbum)
        {
            return heroeRepositorio.ListarTodoPorAlbum(codigoAlbum);
        }

        public List<Heroe> ListarHeroeDeMayorPoder(String codigoAlbum)
        {
            return heroeRepositorio.ListarHeroeDeMayorPoder(codigoAlbum);
        }

        public List<Heroe> ListarHeroeDeMenorPoder(String codigoAlbum)
        {
            return heroeRepositorio.ListarHeroeDeMenorPoder(codigoAlbum);
        }
    }
}
