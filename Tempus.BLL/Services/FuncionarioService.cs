using System.Collections.Generic;
using Tempus.Data.Model;
using Tempus.Data.Repository;

namespace Tempus.BLL.Services
{
    public class FuncionarioService : IFuncionarioService
    {
        IFuncionarioRepository funcionarioRepository;

        public FuncionarioService(IFuncionarioRepository funcionarioRepository)
        {
            this.funcionarioRepository = funcionarioRepository;
        }

        public IEnumerable<Funcionario> GetAll()
        {
            return this.funcionarioRepository.GetAll();
        }

        public IEnumerable<Funcionario> GetByEmpresa(Empresa empresa)
        {
            return this.funcionarioRepository.GetByEmpresa(empresa);
        }

        public IEnumerable<Funcionario> GetByEmpresaAtivos(Empresa empresa)
        {
            return this.funcionarioRepository.GetByEmpresaAtivos(empresa);
        }

        public IEnumerable<Funcionario> GetByEmpresaAndDepartamento(Empresa empresa, Departamento departamento)
        {
            return this.funcionarioRepository.GetByEmpresaAndDepartamento(empresa, departamento);
        }

        public IEnumerable<Funcionario> GetByEmpresaAndDepartamentoAtivos(Empresa empresa, Departamento departamento)
        {
            return this.funcionarioRepository.GetByEmpresaAndDepartamentoAtivos(empresa, departamento);
        }

        public Funcionario Get(Funcionario funcionario)
        {
            return this.funcionarioRepository.Get(funcionario); 
        }

        public Funcionario GetByPIS(Funcionario funcionario)
        {
            return this.funcionarioRepository.GetByPIS(funcionario);
        }

        public Funcionario Add(Funcionario funcionario)
        {
            return this.funcionarioRepository.Add(funcionario);
        }

        public void Update(Funcionario funcionario)
        {
            this.funcionarioRepository.Update(funcionario);
        }

        public void Delete(Funcionario funcionario)
        {
            this.funcionarioRepository.Delete(funcionario);
        }
    }
}