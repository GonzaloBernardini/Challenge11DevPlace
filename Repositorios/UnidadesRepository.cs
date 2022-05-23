using ConcesionarioChallenge11.Data;
using ConcesionarioChallenge11.Interfaces;
using ConcesionarioChallenge11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConcesionarioChallenge11.Repositorios
{
    public class UnidadesRepository : GenericRepository<Unidades>,IUnidadesRepository
    {
        private ConcesionarioChallenge11Context _context;
        public UnidadesRepository(ConcesionarioChallenge11Context context) : base(context)
        {
            _context = context;
        }

        public void BorrarProducto(int IdProducto)
        {
            Delete(IdProducto);

        }

        public List<Unidades> BuscarProducto(int IdProducto)
        {
            //probar si esta bien.
            return Find(x => x.Id == IdProducto).ToList();
        }

        public List<Unidades> GetProductos()
        {
            /*_context.Productos.ToList();*/
            //Probar si esta bien.
            return GetAll().ToList();
        }

        public void InsertProducto(Unidades producto_)
        {
            Add(producto_);
        }

        public void GuardarCambios()
        {
            Save();
        }

    }
}
