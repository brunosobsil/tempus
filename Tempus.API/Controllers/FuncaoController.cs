using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Tempus.Data.Model;
using Tempus.BLL.Services;

namespace Tempus.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncaoController : ControllerBase
    {
        IFuncaoService funcaoService;

        public FuncaoController(IFuncaoService funcaoService)
        {
            this.funcaoService = funcaoService;
        }

        [HttpGet]
        public IEnumerable<Funcao> GetAll()
        {
            return funcaoService.GetAll();
        }

        [Route("{codigo}")]
        [HttpGet]
        public Funcao Get(int codigo)
        {
            return this.funcaoService.Get(codigo);
        }

        [HttpPost]
        public Funcao Add([FromBody] Funcao funcao)
        {
            return this.funcaoService.Add(funcao);
        }

        [HttpPut]
        public void Update([FromBody] Funcao funcao)
        {
            this.funcaoService.Update(funcao);
        }

        [HttpDelete]
        public void Delete([FromBody] Funcao funcao)
        {
            this.funcaoService.Delete(funcao);
        }
    }
}