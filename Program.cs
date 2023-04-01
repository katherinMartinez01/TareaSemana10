using System;
using TareaSemana8;
using TareaSemana8.Models;
using TareaSemana8.DAO;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System.Collections;
using Microsoft.Identity.Client;
using System.Data.Common;
using System.Security.Permissions;
using System.Runtime.CompilerServices;
using System.Linq.Expressions;

while (true)
{
    Console.WriteLine("Por Favor Seleccione una Opción del Menú");
    Console.WriteLine("1 - Guardar");
    Console.WriteLine("2 - Listar");
    Console.WriteLine("3 - Actualizar");
    Console.WriteLine("4 - Eliminar");
    Console.WriteLine("5 - Salirr");
    int op = int.Parse(Console.ReadLine());
    Producto producto = new Producto();
    crudProductos crudProductos = new crudProductos();


    switch (op)
    {
        case 1:

            Console.WriteLine("Ingrese el Nombre de un Producto de su elección ");
            producto.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la Descripción de un Producto de su elección ");
            producto.Descripcion = Console.ReadLine();
            Console.WriteLine("Ingrese el Precio de un Producto de su elección");
            producto.Precio = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Stock de un Producto de su elección");
            producto.Stock = int.Parse(Console.ReadLine());
            crudProductos.guardar(producto);
            break;
        case 2:
            

            var lista = crudProductos.Listar();
            foreach (var item in lista)
            {
                Console.WriteLine($"ID : {item.Id}");
                Console.WriteLine($"Nombre : {item.Nombre}");
                Console.WriteLine($"Descripcion : {item.Descripcion}");
                Console.WriteLine($"Stock :{item.Stock}");
            }
            break;
        case 3:

            Console.WriteLine("Por Favor Ingrese el ID que desee actualizar");
            producto.Id = Convert.ToInt32(Console.ReadLine());
            if (crudProductos.Validar(producto) != null)
            {
                Console.WriteLine("Se Esta Actualizando El Nombre...");
                producto.Nombre = Console.ReadLine();
                Console.WriteLine("Se Esta Actualizando La Descripción...");
                producto.Descripcion = Console.ReadLine();
                Console.WriteLine("Se Esta Actualizando El Precio...");
                producto.Precio = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Se Esta Actualizando El Stock...");
                producto.Stock = int.Parse(Console.ReadLine());

                crudProductos.Actualizar(producto);
                Console.WriteLine("Su Producto se Esta Actualizando...");
                Console.WriteLine("¡¡Su Producto Se Actualizo Exitosamente!!");
            }
            break;
        case 4:
            Console.WriteLine("Por Favor Ingresar el ID que desee eliminar");
            producto.Id = Convert.ToInt32(Console.ReadLine());
            if (crudProductos != null)
            {
                crudProductos.Eliminar(producto);
                Console.WriteLine("¡¡Su Producto Se Esta Eliminando En Estos Momentos...");
                Console.WriteLine("¡¡El Producto Se Elimino Exitosamente!!");
            }
            break;
    }
    Console.WriteLine("¿Desea Querido Usuario volver a Ejecutar de Nuevo el Programa? Si= S/ No= N");
    String seguir = Console.ReadLine();
    if (!seguir.Equals("S")) { 
        break;   

    }
}

    

