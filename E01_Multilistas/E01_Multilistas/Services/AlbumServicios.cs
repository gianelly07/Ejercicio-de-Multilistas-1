using System;
using System.Collections.Generic;
using E01_Multilistas.Entities;
using E01_Multilistas.Repositories;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_Multilistas.Services
{
    internal class AlbumServicios
    {
        private AlbumRepositorio albumRepositorio = new AlbumRepositorio();
        public bool Registrar(Album album)
        {
            if (albumRepositorio.Existe(album.Codigo))
            {
                return false;
            }
            else
            {
                albumRepositorio.Registrar(album);
                return true;
            }
        }

        public List<Album> ListarTodo()
        {
            return AlbumRepositorio.Listartodo();
        }

        public List<Album> ListarAlbumConMasHeroe()
        {
            return albumRepositorio.ListarAlbumConMasHeroe();
        }

        public List<Album> BuscarAlbumQueTengaHeroe(String codigoHeroe)
        {
            return albumRepositorio.BuscarAlbumQueTengaHeroe(codigoHeroe);
        }
    }
}
