using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Tempus.BLL.Services;
using Tempus.Data.Model;

namespace Tempus.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        IFuncionarioService funcionarioService;

        public FuncionarioController(IFuncionarioService funcionarioService)
        {
            this.funcionarioService = funcionarioService;
        }

        [HttpGet]
        public IEnumerable<Funcionario> GetAll()
        {
            return funcionarioService.GetAll();
        }

        //[Route("{matricula}")]
        //[HttpGet]
        //public Funcionario Get()
        //{
        //    return this.funcionarioService.Get()
        //}
    }
}
