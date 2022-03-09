using Nexos.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexos.Core.Interfaces
{
    public interface IRepository
    {

        Libro CreateLibro(Libro Lib);
        Autores CreateAutor(Autores Aut);
        Editoriales CreateEditorial(Editoriales Edi);
        List<Libro> ListaLibros();
        List<Editoriales> ListaEditorial();
        List<Autores> ListaAutor();
        List<Libro> BuscaLibros(int id);


    }
}
