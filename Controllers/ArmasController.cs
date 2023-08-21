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
                    Personagem personagens = await _context.Personagens
                        .FirstOrDefaultAsync(p => p.Id == novaArma.PersonagemId);
              
                if (personagens == null)
                    throw new System.Exception("Seu usuário não contém personagens com o Id do personagem informado.");
                    
                Arma buscaArma = await _context.Armas
                .FirstOrDefaultAsync(a => a.PersonagemId == novaArma.PersonagemId);

                if (buscaArma != null)
                    throw new System.Exception("O personagem selecionado já contém uma arma atribuída a ele.");

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
