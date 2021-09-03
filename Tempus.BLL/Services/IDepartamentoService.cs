using System.Collections.Generic;
using Tempus.Data.Model;

namespace Tempus.BLL.Services
{
    public interface IDepartamentoService
    {
        public IEnumerable<Departamento> GetAll();
        public Departamento GetById(int codigo);
        public Departamento Add(Departamento departamento);
        public void Update(Departamento departamento);
        public void Delete(Departamento departamento);
    }
}
