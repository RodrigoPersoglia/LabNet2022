using LabNet2022.TP7.DataAccess.Commands;
using LabNet2022.TP7.Domain.Entities;
using LabNet2022.TP7.Domain.EntitiesDTO;
using LabNet2022.TP7.Domain.Exceptions;
using LabNet2022.TP7.Logic.Services;
using System;
using System.Web.Http;

namespace LabNet2022.TP8.APIREST.Controllers
{
    /// <summary>
    ///  
    /// </summary>
    public class CategoriesController : ApiController
    {

        private readonly IServiceCategories _service = new ServiceCategories(new CategoriesRepository());

        // GET api/Categories
        ///<Summary>
        /// Obtiene todas las categorias
        ///</Summary>
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(_service.VerTodos());
            }
            catch (Exception) { return InternalServerError(); }
        }

        // GET api/Categories/{id}
        ///<Summary>
        /// Obtiene una categoria por id
        ///</Summary>
        public IHttpActionResult Get(int id)
        {
            try
            {
                return Ok(_service.BuscarPorID(id));
            }

            catch (NoExisteException) { return NotFound(); }
            catch (Exception) { return InternalServerError(); }
        }


        // POST api/Categories
        ///<Summary>
        /// Crear una categoria
        ///</Summary>
        public IHttpActionResult Post([FromBody] CategoryDTO2 category)
        {
            try
            {
                _service.Agregar(category);
                return Ok();
            }
            catch (DatosException ex) { return BadRequest(ex.Message); }
            catch (Exception) { return InternalServerError(); }
        }


        // PUT api/Categories/{id}
        ///<Summary>
        /// Modificar una categoria
        ///</Summary>
        public IHttpActionResult Put([FromUri] int id, [FromBody] CategoryDTO2 category)
        {
            try
            {
                _service.Modificar(id, category);
                return Ok();
            }
            catch (DatosException ex) { return BadRequest(ex.Message); }
            catch (NoExisteException) { return NotFound(); }
            catch (Exception) { return InternalServerError(); }
        }


        //DELETE api/Categories/{id}
        ///<Summary>
        /// Eliminar una categoria
        ///</Summary>
        public IHttpActionResult Delete(int id)
        {
            try
            {
                _service.Eliminar(id);
                return Ok();
            }
            catch (NoEliminaException ex) { return BadRequest(ex.Message); }
            catch (NoExisteException) { return NotFound(); }
            catch (Exception) { return InternalServerError(); }
        }


    }
}
