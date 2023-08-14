using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RpgApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ArmasController : ControllerBase
    {
        public class ArmasController
        {
            [HttpPost]
            public async Task<IActionResult> Add(Arma NovaArma)
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
            }

        }
    }
}