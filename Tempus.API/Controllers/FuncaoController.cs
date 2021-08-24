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

    }
}