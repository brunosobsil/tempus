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

        [Route("codigo/{codigo}")]
        [HttpGet]
        public Departamento GetById(int codigo)
        {
            return this.departamentoService.GetById(codigo);
        }

        [HttpPost]
        public Departamento Add([FromBody] Departamento departamento)
        {
            return this.departamentoService.Add(departamento);
        }

        [HttpPut]
        public void Update([FromBody] Departamento departamento)
        {
            this.departamentoService.Update(departamento);   
        }

        [HttpDelete]
        public void Delete([FromBody] Departamento departamento)
        {
            this.departamentoService.Delete(departamento);
        }
    }
}
