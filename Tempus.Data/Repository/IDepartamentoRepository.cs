using System;
using System.Collections.Generic;
using Tempus.Data.Model;

namespace Tempus.Data.Repository
{
    public interface IDepartamentoRepository
    {
        IEnumerable<Departamento> GetAll();
        Departamento GetById(int id);
        Departamento Include(Departamento departamento);
        void Update(Departamento departamento);
        void Delete(Departamento departamento);

    }
}
