using System.Collections.Generic;
using Tempus.Data.Model;
using Tempus.Data.Repository;

namespace Tempus.BLL.Services
{
    public class FuncaoService : IFuncaoService
    {
        IFuncaoRepository funcaoRepository;

        public FuncaoService(IFuncaoRepository funcaoRepository)
        {
            this.funcaoRepository = funcaoRepository;
        }

        public IEnumerable<Funcao> GetAll()
        {
            return this.funcaoRepository.GetAll();
        }

        public Funcao Get(int codigo)
        {
            Funcao funcao = new Funcao();
            funcao.Codigo = codigo;
            return this.funcaoRepository.Get(funcao);
        }

        public Funcao Add(Funcao funcao)
        {
            return this.funcaoRepository.Add(funcao);
        }

        public void Update(Funcao funcao)
        {
            this.funcaoRepository.Update(funcao);
        }

        public void Delete(Funcao funcao)
        {
            this.funcaoRepository.Delete(funcao);
        }
    }
}
