using FilmesAPI.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        private static List<Filmes> filmes = new List<Filmes>();
        private static int id = 1;
        
        [HttpPost]
        public IActionResult AdicionaFilme([FromBody] Filmes filme)
        {
            filme.Id = id++;
            filmes.Add(filme);
            return CreatedAtAction(nameof(RecuperaFilmePorId), new { Id = filme.Id }, filme);
        }

        [HttpGet]
        public IActionResult RecuperaFilmes()
        {
            return Ok(filmes);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaFilmePorId(int id)
        {
            Filmes filme = filmes.FirstOrDefault(filmes => filmes.Id == id);

            if(filme != null)
            {
                return Ok(filme);
            }
            return NotFound();
        }
    }
}