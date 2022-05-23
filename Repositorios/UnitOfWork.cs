using ConcesionarioChallenge11.Data;
using ConcesionarioChallenge11.Interfaces;
using ConcesionarioChallenge11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConcesionarioChallenge11.Repositorios
{
    public class UnitOfWork : IUnitOfWork
    {
        private ConcesionarioChallenge11Context _context;

        public UnitOfWork(ConcesionarioChallenge11Context context)
        {
            _context = context;
            Unidades = new UnidadesRepository(_context);


        }
        public IUnidadesRepository Unidades { get; private set; }
        public int Complete()
        {
            return _context.SaveChanges();
        }
    }
}
