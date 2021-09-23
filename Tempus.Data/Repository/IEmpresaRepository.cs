using System;
using System.Collections.Generic;
using Tempus.Data.Model;

namespace Tempus.Data.Repository
{
    public interface IEmpresaRepository
    {
        IEnumerable<Empresa> GetAll();
        Empresa Get(Empresa emp);
        Empresa GetByCNPJ(Empresa emp);
        Empresa Add(Empresa empresa);
        void Update(Empresa empresa);
        void Delete(Empresa empresa);
    }
}
