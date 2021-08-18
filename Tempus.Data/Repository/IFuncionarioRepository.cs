using System;
using System.Collections.Generic;
using Tempus.Data.Model;

namespace Tempus.Data.Repository
{
    public interface IFuncionarioRepository
    {
        IEnumerable<Funcionario> GetByEmpresa(Empresa empresa);
        IEnumerable<Funcionario> GetByEmpresaAtivos(Empresa empresa);
        IEnumerable<Funcionario> GetByEmpresaAndDepartamento(Empresa empresa, Departamento departamento);
        IEnumerable<Funcionario> GetByEmpresaAndDepartamentoAtivos(Empresa empresa, Departamento departamento);
        Funcionario GetByMatricula(int matricula);
        Funcionario GetByPIS(string pis);
        Funcionario Include(Funcionario funcionario);
        void Update(Funcionario funcionario);
        void Delete(Funcionario funcionario);
    }
}
