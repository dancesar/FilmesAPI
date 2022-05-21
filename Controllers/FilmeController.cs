using FilmesAPI.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        private static List<Filmes> filmes = new List<Filmes>();
        
        [HttpPost]
        public void AdicionaFilme([FromBody] Filmes filme)
        {
            filmes.Add(filme);
        }
    }
}