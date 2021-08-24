using System.Collections.Generic;
using Tempus.Data.Model;

namespace Tempus.BLL.Services
{
    public class RelogioService : IRelogioService
    {
        public IEnumerable<Relogio> GetAll()
        {
            var relogios = new List<Relogio>();
            var r1 = new Relogio("1", "11.111.111.111", "Modelo1", new Empresa());

            relogios.Add(r1);

            return relogios;
        }

    }
}
