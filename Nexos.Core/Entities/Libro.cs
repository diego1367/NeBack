using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexos.Core.Entities
{
    public class Libro
    {
        [Key]
        public Int32 IdLibro { get; set; }
        public string Titulo { get; set; }
        public DateTime Ano { get; set; }
        public string Genero { get; set; }
        public int NumPaginas { get; set; }
        public Int32 IdEditorial { get; set; }
        public Int32 IdAutor { get; set; }

                  
    }
}
