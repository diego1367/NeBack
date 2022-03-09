using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nexos.Core.Entities;
using Nexos.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nexos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibreriaController : ControllerBase
    {
        private readonly IRepository _Repository;
        public LibreriaController(IRepository repository)
        {
            _Repository = repository;
        }

        [Route("CreateLibro")]
        [HttpPost]
        public IActionResult CreateLibro([FromBody] Libro req)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var Repository = _Repository.CreateLibro(req);
                    return Ok(Repository);
                }
                else
                    return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("CreateAutor")]
        [HttpPost]
        public IActionResult CreateAutor([FromBody] Autores req)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var Repository = _Repository.CreateAutor(req);
                    return Ok(Repository);
                }
                else
                    return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [Route("CreateEditorial")]
        [HttpPost]
        public IActionResult CreateEditorial([FromBody] Editoriales req)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var Repository = _Repository.CreateEditorial(req);
                    return Ok(Repository);
                }
                else
                    return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [Route("ListaLibro")]
        [HttpGet]
        public IActionResult ListaLibro()
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var Repository = _Repository.ListaLibros();
                    return Ok(Repository);
                }
                else
                    return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [Route("ListaAutor")]
        [HttpGet]
        public IActionResult ListaAutor()
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var Repository = _Repository.ListaAutor();
                    return Ok(Repository);
                }
                else
                    return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [Route("ListaEditorial")]
        [HttpGet]
        public IActionResult ListaEditorial()
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var Repository = _Repository.ListaEditorial();
                    return Ok(Repository);
                }
                else
                    return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [Route("GetLibro{id}")]
        [HttpGet]

        public IActionResult GetLibro(int id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var Repository = _Repository.BuscaLibros(id);
                    return Ok(Repository);
                }
                else
                    return BadRequest();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
