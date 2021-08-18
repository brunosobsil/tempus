using System;
using System.Collections.Generic;
using Tempus.Data.Model;

namespace Tempus.Data.Repository
{
    public interface IApontamentoRepository
    {
        IEnumerable<Apontamento> GetByFuncionarioAndData(Funcionario funcionario, DateTime data);
        Apontamento GetById(int id);
        Apontamento Include(Apontamento apontamento);
        void Update(Apontamento apontamento);
        void Delete(Apontamento apontamento);
    }
}
