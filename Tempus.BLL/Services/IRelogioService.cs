using System.Collections.Generic;
using Tempus.Data.Model;

namespace Tempus.BLL.Services
{
    public interface IRelogioService
    {
        public IEnumerable<Relogio> GetAll();
    }
}
