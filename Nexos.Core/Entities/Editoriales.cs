using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexos.Core.Entities
{
    public class Editoriales
    {
        [Key]
        public Int32 IdEditorial { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public Int32 Telefono { get; set; }
        public string Correo { get; set; }
        public int Maximo { get; set; }


    }
}
