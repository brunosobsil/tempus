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
    }
}
