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
    [Route("[controller]")]
    public class AutorController : ControllerBase
    {
        private readonly DataContext _context;
        public AutorController(DataContext context)
        {
            _context = context;
        }


        [HttpGet("GetAll")]
        public async Task<IActionResult> Getsingle()
        {

            try
            {
                //Espera o context ir buscar todos dos autores no banco    
                List<Autor> lista = await _context.TB_AUTOR.ToListAsync();

                return Ok(lista);
            }
            catch (System.Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpPost("AddAuthor")]

        public async Task<IActionResult> AddAuthor(Autor autor)
        {
            try
            {
                if (autor.Nome.Length <= 3)
                {

                    throw new Exception("Nome Muito pequeno");
                }
                await _context.TB_AUTOR.AddAsync(autor);
                await _context.SaveChangesAsync();

                return Ok(autor);
            }
            catch (System.Exception ex)
            {

                return BadRequest(ex.Message);

            }
        }

        [HttpPut("UpdateAuthor")]
        public async Task<IActionResult> UpdateAuthor(Autor autor)
        {
            try
            {
                var autorExistente = await _context.TB_AUTOR.FindAsync(autor.Id);

                if (autorExistente == null)
                {
                    throw new Exception("Autor não existe");

                }

                if (autor.Nome.Length <= 3)
                {
                    throw new Exception("Nome Muito pequeno");
                }

                _context.TB_AUTOR.Update(autor);

                return Ok($"O {autor} foi atualizado");
            }
            catch (System.Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("DeleteAuthor")]
        public async Task<IActionResult> DeleteAuthor(int Id)
        {
            try
            {
                var autor = await _context.TB_AUTOR.FindAsync(Id);

                if (autor == null)
                {
                    return NotFound("Autor Não encontrado");
                }

                _context.TB_AUTOR.Remove(autor);
                await _context.SaveChangesAsync();

                return Ok($"Autor com o Id {Id} foi deletado");

            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}