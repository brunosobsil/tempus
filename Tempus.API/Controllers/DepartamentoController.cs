using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Tempus.BLL.Services;
using Tempus.Data.Model;

namespace Tempus.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentoController : ControllerBase
    {
        IDepartamentoService departamentoService;

        public DepartamentoController(IDepartamentoService departamentoService)
        {
            this.departamentoService = departamentoService;
        }

        [HttpGet]
        public IEnumerable<Departamento> GetAll()
        {
            return departamentoService.GetAll();
        }
    }
}
