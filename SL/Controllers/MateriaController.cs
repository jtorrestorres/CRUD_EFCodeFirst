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
        // GET: api/<MateriaController>
        [HttpGet]
        public ML.Result Get()
        {
            ML.Result result = BL.Materia.GetAll();
            return result;
        }


        // GET api/<MateriaController>/5
        //[Route("api/Materia/{IdMateria}")]
        [HttpGet("{IdMateria}")]
        public ML.Result Get(int IdMateria)
        {
            ML.Result result = BL.Materia.GetById(IdMateria);
            return result;
        }

        // POST api/<MateriaController>
        [HttpPost]
        public ML.Result Post([FromBody] ML.Materia materia)
        {
            ML.Result result = BL.Materia.Add(materia);
            return result;
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
