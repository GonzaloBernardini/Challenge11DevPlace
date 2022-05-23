using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConcesionarioChallenge11.Interfaces
{
    public interface IUnitOfWork
    {
        IUnidadesRepository Unidades { get; }
        int Complete();
    }
}
