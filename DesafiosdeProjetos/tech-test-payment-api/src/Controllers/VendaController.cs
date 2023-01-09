using System.Net;
using Microsoft.AspNetCore.Mvc;
using src.Models;
using src.Persintence;
using Microsoft.EntityFrameworkCore;

namespace src.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendaController : ControllerBase
    {
        private DatabaseContext _context { get; set; }

        public VendaController(DatabaseContext context)
        {
            this._context = context;
        }

        [HttpPost]
        public IActionResult RegistrarVenda(Venda venda)
        {
            try
            {
                venda.status = "Aguardando pagamento";                
                _context.Vendas.Add(venda);
                _context.SaveChanges();

            }
            catch
            {
                return BadRequest(new
                {
                    msg = "Ocorreu um erro ao tentar criar a Venda",
                    status = HttpStatusCode.BadRequest
                });
            }

            return Created("Criado ", venda);
        }

        [HttpGet("{id}")]
        public IActionResult BuscarVendaById(int id)
        {
            var venda = _context.Vendas.Find(id);    

           if(venda is null) return BadRequest(new {
            msg = "Conteúdo inexistente, solicitação inválida",
            status = HttpStatusCode.BadRequest
        });
           // var vendaAll = _context.Vendas.
           return Ok(venda);
        }
    }
}