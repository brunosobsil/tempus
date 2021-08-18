using System;
using System.Collections.Generic;
using Tempus.Data.Model;

namespace Tempus.Data.Repository
{
    public interface IEmpresaRepository
    {
        IEnumerable<Empresa> GetAll();
        Empresa GetById(int id);
        Empresa GetByCNPJ(string cnpj);
        Empresa Include(Empresa empresa);
        void Update(Empresa empresa);
        void Delete(Empresa empresa);
    }
}
