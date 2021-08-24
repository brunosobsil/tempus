using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Tempus.BLL.Services;
using Tempus.Data.Model;

namespace Tempus.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RelogioController : ControllerBase
    {
        IRelogioService relogioService;

        public RelogioController(IRelogioService relogioService)
        {
            this.relogioService = relogioService;
        }

        [HttpGet]
        public IEnumerable<Relogio> GetAll()
        {
            return relogioService.GetAll();
        }
    }
}
