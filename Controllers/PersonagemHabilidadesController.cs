using Microsoft.AspNetCore.Mvc;
using RpgApi.Data;
using RpgApi.Models; 
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Linq;

namespace RpgApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class PersonagemHabilidadesController : ControllerBase
    {
        //Programação de toda a classe ficará aqui abaixo
        private readonly DataContext _context; //Declaração do atributo

        public PersonagemHabilidadesController(DataContext context)
        {
            //Inicialização do atributo a partir de um parâmetro          
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> AddPersonagemHabilidadeAsync(PersonagemHabilidade novoPersonagemHabilidade)
        {
            try
            {
                Personagem personagem = await _context.Personagens
                    .Include(p => p.Arma)
                    .Include(p => p.PersonagemHabilidades).ThenInclude(ps => ps.Habilidade)
                    .FirstOrDefaultAsync(p => p.Id == novoPersonagemHabilidade.PersonagemId);

                if(personagem == null)
                    throw new System.Exception("Personagem não encontrado para o Id informado.");

                Habilidade habilidade = await _context.Habilidades
                    .FirstOrDefaultAsync(h => h.Id == novoPersonagemHabilidade.HabilidadeId);

                if(habilidade == null)
                    throw new System.Exception("Habilidade não encontrada.");

                PersonagemHabilidade ph = new PersonagemHabilidade();
                ph.Personagem = personagem;
                ph.Habilidade = habilidade;
                await _context.PersonagemHabilidades.AddAsync(ph);
                int linhasAfetadas = await _context.SaveChangesAsync();

                return Ok(linhasAfetadas);    
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{personagemId}")]
        public async Task<IActionResult> ListarAsync(int personagemId)
        {
            try
            {
            List<PersonagemHabilidade> habilidades = await _context.PersonagemHabilidades
                .Include(ph => ph.Habilidade)
                .Where(ph => ph.PersonagemId == personagemId)
                .ToListAsync();
            
                return Ok(habilidades);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetHabilidades")]
        public async Task<IActionResult> Get()
        {
            try
            {
                List<Habilidade> lista = await _context.Habilidades.ToListAsync();
                return Ok(lista);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("DeletePersonagemHabilidade")]
        public async Task<IActionResult> DeletePersonagemHabilidade(PersonagemHabilidade phId)
        {
            try
            {
                PersonagemHabilidade phDelete = await _context.PersonagemHabilidades
                    .FirstOrDefaultAsync(ph => ph.PersonagemId == phId.PersonagemId && ph.HabilidadeId == phId.HabilidadeId);

                    _context.PersonagemHabilidades.Remove(phDelete);
                    int linhasAfetadas = await _context.SaveChangesAsync();
                    return Ok(linhasAfetadas);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}