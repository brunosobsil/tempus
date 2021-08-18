using System;
using System.Collections.Generic;
using Tempus.Data.Model;

namespace Tempus.Data.Repository
{
    public interface IAcessoUsuarioRepository
    {
        IEnumerable<AcessoUsuario> GetAll();
        AcessoUsuario GetById(int id);
        AcessoUsuario Include(AcessoUsuario acessoUsuario);
        void Update(AcessoUsuario acessoUsuario);
        void Delete(AcessoUsuario acessoUsuario);

    }
}
