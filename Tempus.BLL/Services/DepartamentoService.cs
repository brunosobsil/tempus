using System.Collections.Generic;
using Tempus.Data.Model;

namespace Tempus.BLL.Services
{
    public class DepartamentoService : IDepartamentoService
    {
        public IEnumerable<Departamento> GetAll()
        { 
            var departamentos = new List<Departamento>();
            var d1 = new Departamento(1, "Diretoria Geral");
            var d2 = new Departamento(2, "Gerência de Recursos Humanos");
            var d3 = new Departamento(3, "Gerência Administrativa");

            departamentos.Add(d1);
            departamentos.Add(d2);
            departamentos.Add(d3);

            return departamentos;
        }
    }
}
