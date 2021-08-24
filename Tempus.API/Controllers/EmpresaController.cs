using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Tempus.BLL.Services;
using Tempus.Data.Model;

namespace Tempus.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpresaController : ControllerBase
    {
        IEmpresaService empresaService;
        
        public EmpresaController(IEmpresaService empresaService)
        {
            this.empresaService = empresaService;
        }

        [HttpGet]
        public IEnumerable<Empresa> GetAll()
        {
            return empresaService.GetAll();
        }
    }
}
