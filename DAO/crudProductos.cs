using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareaSemana8.Models;

namespace TareaSemana8.DAO
{
    public class crudProductos
    {
        public void guardar(Producto paramProducto)
        {
            using (AlmacenContext bd = new AlmacenContext())
            {
                Producto producto = new Producto();
                producto.Nombre = paramProducto.Nombre;
                producto.Descripcion = paramProducto.Descripcion;
                producto.Precio = paramProducto.Precio;
                producto.Stock = paramProducto.Stock;

                bd.Add(producto);
                bd.SaveChanges();
                Console.WriteLine("¡¡Su Producto Fue Ingresado Exitosamente!!");
            }
        }
        public List<Producto> Listar()
        {
            using (AlmacenContext db = new AlmacenContext())
            {
                var lista = db.Productos.ToList();
                return lista;
            }
        }
        public Producto Validar(Producto paramProducto)
        {
            using (AlmacenContext db = new AlmacenContext())
            {
                var buscar = db.Productos.FirstOrDefault(x => x.Id == paramProducto.Id);
                return buscar;
            }
        }

        public void Actualizar(Producto paramProducto)
        {
            using (AlmacenContext db = new AlmacenContext())
            {
                db.Update(paramProducto);
                db.SaveChanges();
            }
        }
        public void Eliminar(Producto paramProducto)
        {
            using (AlmacenContext db = new AlmacenContext())
            {
                db.Remove(paramProducto);
                db.SaveChanges();
            }

        }
    }

}
        

