using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using RpgApi.Models;
using RpgApi.Data;

namespace RpgApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ArmasController : ControllerBase
    {
        private readonly DataContext _context; 

        public ArmasController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Add(Arma novaArma)
        {
            try
            {
                if (novaArma.Dano == 0)
                {
                    throw new System.Exception("O dano da arma não pode ser 0");
                }
                    Personagem p = await _context.Personagens.FirstOrDefaultAsync(p => p.Id == novaArma.PersonagemId);
              
                if (p == null)
                    throw new System.Exception("Não existe personagem com o Id informado.");
                    
                await _context.Armas.AddAsync(novaArma);
                await _context.SaveChangesAsync();

                return Ok(novaArma.Id);
            }
            catch(System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
