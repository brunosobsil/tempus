using System.Collections.Generic;
using Tempus.Data.Model;

namespace Tempus.BLL.Services
{
    public class FuncaoService : IFuncaoService
    {
        public FuncaoService()
        {

        }

        public IEnumerable<Funcao> GetAll()
        {
            var funcoes = new List<Funcao>();
            var f1 = new Funcao(1, "Analista de Sistemas");
            var f2 = new Funcao(2, "Adminstrador");
            var f3 = new Funcao(2, "Gerente");

            funcoes.Add(f1);
            funcoes.Add(f2);
            funcoes.Add(f3);

            return funcoes;
        }
    }
}
