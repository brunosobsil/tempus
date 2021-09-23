using System.Collections.Generic;
using Tempus.Data.Model;

namespace Tempus.Data.Repository
{
    public interface IDepartamentoRepository
    {
        IEnumerable<Departamento> GetAll();
        Departamento Get(Departamento departamento);
        Departamento Add(Departamento departamento);
        void Update(Departamento departamento);
        void Delete(Departamento departamento);
    }
}
