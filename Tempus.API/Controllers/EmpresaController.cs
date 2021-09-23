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

        [Route("{id}")]
        [HttpGet]
        public Empresa Get(int id)
        {
            return this.empresaService.Get(id);
        }

        [Route("cnpj/{cnpj")]
        [HttpGet]
        public Empresa GetByCnpj(string cnpj)
        {
            return this.empresaService.GetByCNPJ(cnpj);
        }

        [HttpPost]
        public Empresa Add([FromBody] Empresa empresa)
        {
            return this.empresaService.Add(empresa);
        }

        [HttpPut]
        public void Update([FromBody] Empresa empresa)
        {
            this.empresaService.Update(empresa);
        }

        [HttpDelete]
        public void Delete([FromBody] Empresa empresa)
        {
            this.empresaService.Delete(empresa);
        }






    }
}
