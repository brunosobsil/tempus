using System.Collections.Generic;
using Tempus.Data.Model;
using Tempus.Data.Repository;

namespace Tempus.BLL.Services
{
    public class DepartamentoService : IDepartamentoService
    {
        IDepartamentoRepository departamentoRepository;

        public DepartamentoService(IDepartamentoRepository departamentoRepository)
        {
            this.departamentoRepository = departamentoRepository;
        }

        public IEnumerable<Departamento> GetAll()
        {
            return this.departamentoRepository.GetAll();
        }

        public Departamento GetById(int codigo)
        {
            Departamento departamento = new Departamento();
            departamento.Codigo = codigo;
            return this.departamentoRepository.Get(departamento);
        }

        public Departamento Add(Departamento departamento)
        {
            return this.departamentoRepository.Add(departamento);
        }

        public void Update(Departamento departamento)
        {
            this.departamentoRepository.Update(departamento);
        }

        public void Delete(Departamento departamento)
        {
            this.departamentoRepository.Delete(departamento);
        }
    }
}
