using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_Multilistas.Entities
{
    internal class Album
    {
        public Album() { }
        public String Codigo { get; set; }
        public String Nombre { get; set; }
        public List<Heroe> Heroes { get; set; }
        //debe tener en cuenta que un álbum se compone de muchos héroes
    }
}
