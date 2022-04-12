using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MateriaController : ControllerBase
    {
        //[HttpGet] //Obtener GetAll, GetById
        //[HttpPost] //Add
        //[HttpPut] //Update
        //[HttpDelete] //Delete

        // GET: api/<MateriaController>
        [HttpGet]
        public IActionResult Get()
        {
            ML.Result result = BL.Materia.GetAll();

            if(result.Correct)
            {
                return Ok(result);
            }
            else
            {
                return NotFound();
            }
        }


        // GET api/<MateriaController>/5
        //[Route("api/Materia/{IdMateria}")]

        [HttpGet("{IdMateria}")]
        public IActionResult Get(int IdMateria)
        {
            ML.Result result = BL.Materia.GetById(IdMateria);
            
            if(result.Correct)
            {
                return Ok(result);
            }
            else
            {
                return NotFound();
            }
        }

        // POST api/<MateriaController>
        [HttpPost]
        public IActionResult Add([FromBody] ML.Materia materia)
        {
            ML.Result result = BL.Materia.Add(materia);
            if (result.Correct)
            {
                return Ok(result);
            }
            else
            {
                return NotFound();
            }
        }

        // PUT api/<MateriaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MateriaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
