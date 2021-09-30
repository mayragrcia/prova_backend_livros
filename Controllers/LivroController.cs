using System;
using System.Collections.Generic;
using System.Linq;
using Data;
using provaLivro.Models;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

namespace provaLivro.Controllers
{
    [ApiController]
    [Route("api/livro")]
    public class LivroController : ControllerBase
    {
        private readonly DataContext _context;

        //Construtor
        public LivroController(DataContext context) => _context = context;

        //POST: api/livro/create
        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody] Livro livro)
        {
            _context.Livro.Add(livro);
            _context.SaveChanges();
            return Created("", livro);
        }

        //GET: api/livro/list
        [HttpGet]
        [Route("list")]
        public IActionResult List() => Ok(_context.Livro.ToList());
    }
}