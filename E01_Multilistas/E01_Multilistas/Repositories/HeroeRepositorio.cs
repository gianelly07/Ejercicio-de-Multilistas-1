using System;
using System.Collections.Generic;
using E01_Multilistas.Repositories;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E01_Multilistas.Entities;

namespace E01_Multilistas.Repositories
{
    internal class HeroeRepositorio
    {
        public bool Existe(String codigoAlbum, String cosigoHeroe)
        {
            List<Album> albumes = AlbumRepositorio.Listartodo();

            //encontrar el album
            Album album =albumes.Find(a => a.Codigo.Equals(codigoAlbum));
            return album.Heroes.Exists(h => h.Codigo.Equals(cosigoHeroe));
        }

        public void Registrar(String codigoAlbums, Heroe heroe)
        {
            List<Album> albumes = AlbumRepositorio.Listartodo();

            //encontrar el album
            Album album = albumes.Find(a => a.Codigo.Equals(codigoAlbums));
            album.Heroes.Add(heroe);
        }

        public List<Heroe> ListarTodoPorAlbum(String codigoAlbum)
        {
            List<Album> albumes = AlbumRepositorio.Listartodo();
            Album album = albumes.Find(a => a.Codigo.Equals(codigoAlbum));
            return album.Heroes;

        }

        public List<Heroe> ListarHeroeDeMayorPoder(String codigoAlbum)
        {
            List<Album> albumes = AlbumRepositorio.Listartodo();
            Album album = albumes.Find(a => a.Codigo.Equals(codigoAlbum));

            if (album.Heroes.Count == 0) return new List<Heroe>();
            double mayorPoder = album.Heroes.Max(h => h.Poder);

            return album.Heroes.Where(h => h.Poder == mayorPoder).ToList();
        }

         public List<Heroe> ListarHeroeDeMenorPoder(String codigoAlbum)
         {
            List<Album> albumes = AlbumRepositorio.Listartodo();
            Album album = albumes.Find(a => a.Codigo.Equals(codigoAlbum));

            if (album.Heroes.Count == 0) return new List<Heroe>();
            double menorPoder = album.Heroes.Min(h => h.Poder);

            return album.Heroes.Where(h => h.Poder == menorPoder).ToList();
         }
    }
}
