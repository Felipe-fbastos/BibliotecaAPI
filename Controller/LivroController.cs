using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BibliotecaAPi.Data;
using BibliotecaAPi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaAPi.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class LivroController : ControllerBase
    {
        private readonly DataContext _context;
        public LivroController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("GetAll")]

        public async Task<IActionResult> GetAll(){
            try{
            List<Livro> livros = await _context.TB_LIVRO.ToListAsync();

            return Ok(livros);

            }
            catch(System.Exception ex){

                return BadRequest(ex.Message);
            }
        }

        [HttpPost("AddBook")]

        public async Task<IActionResult> Addbook(Livro livro){

            try{
                //Fazer uma verifacao para não deixar dois livros com mesmo titulo

            }
        }


    }
}