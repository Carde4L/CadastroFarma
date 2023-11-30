
using API.Context;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class categoriaController :  ControllerBase
    {
        private readonly cadastroContext _context;

        public categoriaController(cadastroContext context)
        {
            _context = context;
        }
        [HttpGet("ObterTodosCadastros")]
        public async Task<ActionResult<IEnumerable<Cadastro>>> ObterTodosCadastros()
        {
            try
            {
                if (_context.Cadastros_Farmacia.Count() == 0)
                {
                    return NotFound("Não existe usuario na lista");
                }

                var usuario = await _context.Cadastros_Farmacia.ToListAsync();

                return Ok(usuario);
            }
            catch (Exception)
            {
                return BadRequest("Ocorreu um erro na solicitação...");
            }
        }
        [HttpGet("ObterCadastrosPorCPF/{Id:long}")]
        public async Task<ActionResult<IEnumerable<Cadastro>>> ObterCadastrosPorCPF(long Id)
        {
            try
            {
                if (_context.Cadastros_Farmacia.Count() == 0)
                {
                    return NotFound("Não existe usuario na lista");
                }

                var usuario = await _context.Cadastros_Farmacia.FindAsync(Id);

                if (usuario == null)
                {
                    return NotFound("O usuario não foi encontrado");
                }

                return Ok(usuario);
            }
            catch (Exception)
            {
                return BadRequest("Ocorreu um erro na solicitação...");
            }
        }
        [HttpPost("AdicionarCadastros")]
        public async Task<ActionResult<IEnumerable<Cadastro>>> AdicionarCadastros(Cadastro cadastros)
        {
            try
            {
                await _context.Cadastros_Farmacia.AddAsync(cadastros);
                await _context.SaveChangesAsync();
                return Ok(cadastros);
            }
            catch (Exception ex)
            {
                return BadRequest("Ocorreu um erro na solicitação...");
            }
        }
        [HttpDelete("DeletarCadastros")]
        public async Task<ActionResult<IEnumerable<Cadastro>>> DeletarCadastros(long Id)
        {
            try
            {
                if (_context.Cadastros_Farmacia.Count() == 0)
                {
                    return NotFound("Não existem usuarios na lista");
                }

                var cadastro = await _context.Cadastros_Farmacia.FindAsync(Id);

                if (cadastro == null)
                {
                    return NotFound("O usuario não foi encontrado");
                }

                var deleteCadastros = _context.Cadastros_Farmacia.Remove(cadastro);
                await _context.SaveChangesAsync();

                return Ok(new { Mensagem = "Usuario excluído com sucesso", CadastroExcluido = deleteCadastros.Entity });
            }
            catch (Exception)
            {
                return BadRequest("Ocorreu um erro na solicitação...");
            }
        }
        [HttpPut("AtualizarCadastros")]
        public async Task<ActionResult<IEnumerable<Cadastro>>> AtualizarFilmes(long Id, Cadastro cadastros)
        {
            try
            {
                if (_context.Cadastros_Farmacia.Count() == 0)
                {
                    return NotFound("A lista está vazia");
                }

                var procurarCadastro = await _context.Cadastros_Farmacia.FindAsync(Id);


                procurarCadastro.Nome = cadastros.Nome;
                procurarCadastro.email = cadastros.email;
                procurarCadastro.CPF = cadastros.CPF;
                procurarCadastro.dNascimento = cadastros.dNascimento;
                procurarCadastro.Ncontato = cadastros.Ncontato;
                procurarCadastro.Endereco = cadastros.Endereco;
                procurarCadastro.Convenios = cadastros.Convenios;

                _context.Cadastros_Farmacia.Update(procurarCadastro);
                await _context.SaveChangesAsync();

                return Ok(cadastros);
            }
            catch (Exception)
            {
                return BadRequest("Ocorreu um erro na solicitação...");
            }
        }
    }

}
