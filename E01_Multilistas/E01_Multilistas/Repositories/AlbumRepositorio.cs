using System;
using E01_Multilistas.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_Multilistas.Repositories
{
    internal class AlbumRepositorio
    {
        private static List<Album> albumes = new List<Album>();
        public bool Existe(String codigo)
        {
            return albumes.Exists(a => a.Codigo.Equals(codigo));
        }

        public void Registrar(Album album)
        {
            albumes.Add(album);
        }

        public static List<Album> Listartodo()
        {
            return albumes;
        }

        public List<Album> ListarAlbumConMasHeroe()
        {
            int mayorCantidadHerores = albumes.Count == 0 ? 0 : albumes.Max(a => a.Heroes.Count);

            //buscar los albumes
            return albumes.Where(a => a.Heroes.Count == mayorCantidadHerores).ToList();
        }

        public List<Album> BuscarAlbumQueTengaHeroe(String codigoHeroe)
        {
            return albumes.Where(a => a.Heroes.Exists(h => h.Codigo.Equals(codigoHeroe))).ToList();
        }
    }
}
