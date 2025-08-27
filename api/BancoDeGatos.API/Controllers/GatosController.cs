using BancoDeGatos.Dados;
using BancoDeGatos.Dados.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BancoDeGatos.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GatosController : ControllerBase
    {
        private readonly AppDbContext _contexto;

        public GatosController(AppDbContext contexto)
        {
            _contexto = contexto;
        }

        [HttpGet]
        public async Task<IActionResult> ObterTodos()
        {
            var gatos = await _contexto.Gatos.ToListAsync();
            return Ok(gatos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObterPorId(int id)
        {
            var gato = await _contexto.Gatos.FindAsync(id);
            if (gato == null)
            {
                return NotFound();
            }
            return Ok(gato);
        }

        [HttpPost]
        public async Task<IActionResult> Adicionar([FromBody] Gato novoGato)
        {
            _contexto.Gatos.Add(novoGato);
            await _contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(ObterPorId), new { id = novoGato.Id }, novoGato);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Atualizar(int id, [FromBody] Gato gatoAtualizado)
        {
            if (id != gatoAtualizado.Id)
            {
                return BadRequest("O ID na URL não corresponde ao ID do gato.");
            }

            var gatoExistente = await _contexto.Gatos.FindAsync(id);
            if (gatoExistente == null)
            {
                return NotFound();
            }

            gatoExistente.Nome = gatoAtualizado.Nome;
            gatoExistente.Cor = gatoAtualizado.Cor;
            gatoExistente.Idade = gatoAtualizado.Idade;
            gatoExistente.Raca = gatoAtualizado.Raca;
            gatoExistente.Dono = gatoAtualizado.Dono;

            await _contexto.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remover(int id)
        {
            var gato = await _contexto.Gatos.FindAsync(id);
            if (gato == null)
            {
                return NotFound();
            }

            _contexto.Gatos.Remove(gato);
            await _contexto.SaveChangesAsync();
            return NoContent();
        }
    }
}