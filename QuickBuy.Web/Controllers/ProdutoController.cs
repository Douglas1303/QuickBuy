using Microsoft.AspNetCore.Mvc;
using QuickBuy.Dominio.Contrates;
using QuickBuy.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickBuy.Web.Controllers
{
    [Route("api/[Controller]")]
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepositorio _produtoRepositorio; 
        public ProdutoController(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio; 
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_produtoRepositorio.ObterTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString()); 
            }     
        }

        [HttpPost]
        public IActionResult Post([FromBody]Produto produto)
        {
            try
            {
                _produtoRepositorio.Adicionar(produto);

                //Se der certo devolve para a api/produto com o produto q foi adicionado
                return Created("api/produto", produto); 
            }
            catch (Exception ex)
            {

                return BadRequest(ex.ToString()); 
            }
        }
    }
}
