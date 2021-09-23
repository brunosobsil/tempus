using System.Collections.Generic;
using Tempus.Data.Model;

namespace Tempus.BLL.Services
{
    public interface IFuncionarioService
    {
        public IEnumerable<Funcionario> GetAll();
        public IEnumerable<Funcionario> GetByEmpresa(Empresa empresa);
        public IEnumerable<Funcionario> GetByEmpresaAtivos(Empresa empresa);
        public IEnumerable<Funcionario> GetByEmpresaAndDepartamento(Empresa empresa, Departamento departamento);
        public IEnumerable<Funcionario> GetByEmpresaAndDepartamentoAtivos(Empresa empresa, Departamento departamento);
        public Funcionario Get(Funcionario funcionario);
        public Funcionario GetByPIS(Funcionario funcionario);
        public Funcionario Add(Funcionario funcionario);
        void Update(Funcionario funcionario);
        void Delete(Funcionario funcionario);
    }
}
