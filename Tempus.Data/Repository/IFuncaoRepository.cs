using System;
using System.Collections.Generic;
using Tempus.Data.Model;

namespace Tempus.Data.Repository
{
    public interface IFuncaoRepository
    {
        IEnumerable<Funcao> GetAll();
        Funcao GetById(int id);
        Funcao Include(Funcao funcao);
        void Update(Funcao funcao);
        void Delete(Funcao funcao);

    }
}
