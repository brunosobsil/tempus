using System.Collections.Generic;
using Tempus.Data.Model;

namespace Tempus.BLL.Services
{
    public class EmpresaService : IEmpresaService
    {
        public IEnumerable<Empresa> GetAll()
        {
            var empresas = new List<Empresa>();
            var e1 = new Empresa(1, "TechnoLogic", "10000000000100", "Leandro Nunes");
            var e2 = new Empresa(2, "Tempus", "10000000000100", "Bruno Sobral");
            var e3 = new Empresa(3, "BRL", "10000000000100", "Raphael Azen");

            empresas.Add(e1);
            empresas.Add(e2);
            empresas.Add(e3);

            return empresas;
        }
    }
}
