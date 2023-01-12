using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Models;
using System.Globalization;

namespace PruebaTecnica.Controllers
{
    [ApiController]
    [Route("producto")]
    public class ProductosControllers : ControllerBase
    {
        [HttpGet]
        [Route("productos")]
        public dynamic ProductosxRol(string rol)
        {
            List<Productos> productos = new List<Productos>
            {
                new Productos
                {
                    Id = 1,
                    rol = "Principal",
                    producto = "Prod_A"
                },
                new Productos
                {
                    Id = 2,
                    rol = "Principal",
                    producto = "Prod_B"
                },
                new Productos
                {
                    Id = 3,
                    rol = "Principal",
                    producto = "Prod_C"
                },
                new Productos
                {
                    Id = 4,
                    rol = "Delegado",
                    producto = "Prod_A"
                },
                new Productos
                {
                    Id = 5,
                    rol = "Delegado",
                    producto = "¨Prod_C"
                }
            };

            return productos.Where(x => x.rol == rol).ToList();
        }
    }
}
