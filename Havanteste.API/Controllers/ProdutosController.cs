using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HavanTeste.Domain.Entity;
using HavanTeste.Domain.Interfaces;
using HavanTeste.Services.Services;

namespace Havanteste.API.Controllers
{
    [Route("api/[controller]/[action]")]

    [ApiController]
    public class ProdutosController : ControllerBase
    {

        private IProdutoService ProdutoServices { get; }

        public ProdutosController(IProdutoService produtoServices)
        {
            ProdutoServices = produtoServices;
        }


        [HttpGet]
        public IActionResult Get(int id)
        {
            return Ok(ProdutoServices.GetById(id));
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(ProdutoServices.GetAll());
        }
    }
}
