using FilmesAPI.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        private static List<Filmes> filmes = new List<Filmes>();
        private static int id = 1;
        
        [HttpPost]
        public void AdicionaFilme([FromBody] Filmes filme)
        {
            filme.Id = id++;
            filmes.Add(filme);
        }

        [HttpGet]
        public IEnumerable<Filmes> RecuperaFilmes()
        {
            return filmes;
        }
    }
}