using System;
using System.Collections.Generic;
using Tempus.Data.Model;

namespace Tempus.Data.Repository
{
    public interface IFuncionarioRepository
    {
        IEnumerable<Funcionario> GetAll();
        IEnumerable<Funcionario> GetByEmpresa(Empresa empresa);
        IEnumerable<Funcionario> GetByEmpresaAtivos(Empresa empresa);
        IEnumerable<Funcionario> GetByEmpresaAndDepartamento(Empresa empresa, Departamento departamento);
        IEnumerable<Funcionario> GetByEmpresaAndDepartamentoAtivos(Empresa empresa, Departamento departamento);
        Funcionario Get(Funcionario funcionario);
        Funcionario GetByPIS(Funcionario funcionario);
        Funcionario Add(Funcionario funcionario);
        void Update(Funcionario funcionario);
        void Delete(Funcionario funcionario);
    }
}
