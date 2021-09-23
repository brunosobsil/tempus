using System;
using System.Collections.Generic;
using Tempus.Data.Model;

namespace Tempus.Data.Repository
{
    public interface IFuncaoRepository
    {
        IEnumerable<Funcao> GetAll();
        Funcao Get(Funcao funcao);
        Funcao Add(Funcao funcao);
        void Update(Funcao funcao);
        void Delete(Funcao funcao);
    }
}
