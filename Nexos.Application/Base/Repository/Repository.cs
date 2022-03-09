using Nexos.Core.Entities;
using Nexos.Core.Interfaces;
using Nexos.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexos.Application.Base.Repository
{
    public class Repository : IRepository
    {
        private readonly NexosContext _context;
        public Repository(NexosContext context)
        {
            _context = context;
        }

        public Autores CreateAutor(Autores Aut)
        {
            _context.Autores.Add(Aut);
            _context.SaveChanges();
            return Aut;
        }

        public Editoriales CreateEditorial(Editoriales Edi)
        {
            _context.Editoriales.Add(Edi);
            _context.SaveChanges();
            return Edi;
        }

        public Libro CreateLibro(Libro Lib)
        {

            if (!ExisteAutor(Lib.IdAutor))
                throw new Exception("El autor no está registrado");
            if (!ExisteEditorial(Lib.IdEditorial))
                throw new Exception("La editorial no está registrada");
            if (EditorialMAximo(Lib.IdEditorial))
                throw new Exception("No es posible registrar el libro, se alcanzó el máximo permitido.");

            _context.Libro.Add(Lib);
            _context.SaveChanges();
            return Lib;
        }

        public List<Libro> ListaLibros()
        {
            return _context.Libro.ToList();
        }

        public List<Editoriales> ListaEditorial()
        {
            return _context.Editoriales.ToList();
        }

        public List<Autores> ListaAutor()
        {
            return _context.Autores.ToList();
        }

        private bool EditorialMAximo (int IdEdi)
        {
            var maximunBook = _context.Editoriales.Where(e => e.IdEditorial == IdEdi).FirstOrDefault().Maximo; 
            if (maximunBook.Equals("-1"))
            {
                return false;
            }
            else
            {
                if (maximunBook.Equals(_context.Libro.Count(e => e.IdEditorial == IdEdi)))
                {
                    return true;
                }
                return false;
            }
        }
        
        private bool ExisteAutor(int IdAut)
        {
            var existe = _context.Autores.Where(e => e.IdAutor == IdAut).Count();
            if (existe > 0)
                return true;
            else
                return false;

        }

        private bool ExisteEditorial(int IdEdi)
        {
            var existe = _context.Editoriales.Where(e => e.IdEditorial == IdEdi).Count();
            if (existe > 0)
                return true;
            else
                return false;

        }

        public List<Libro> BuscaLibros(int id)
        {
            return _context.Libro.Where(a => a.IdLibro == id).ToList();

        }
    }
}
