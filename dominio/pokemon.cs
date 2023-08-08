using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class pokemon
    {
        public int Id { get; set; }

        [DisplayName("Numero")]
        public int Numero { get; set; }
    public string Nombre { get; set; }
        [DisplayName("Descripcion")]

        public string Descripcion { get; set; }

    public string UrlImagen { get; set; }
    public Elementos Tipo { get; set; }
    public Elementos Debilidad { get; set; }

    }
}
