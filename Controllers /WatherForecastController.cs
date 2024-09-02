using Microsoft.AspNetCore.Mvc;
using MiApiRest.Models;
using System.Collections.Generic;
using System.Linq;

namespace MiApiRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private static List<Producto> productos = new List<Producto>
        {
            new Producto { Id = 1, Nombre = "Producto 1", Precio = 10.0M },
            new Producto { Id = 2, Nombre = "Producto 2", Precio = 20.0M },
        };

        // GET: api/productos
        [HttpGet]
        public ActionResult<IEnumerable<Producto>> GetProductos()
        {
            return productos;
        }

        // GET: api/productos/{id}
        [HttpGet("{id}")]
        public ActionResult<Producto> GetProducto(int id)
        {
            var producto = productos.FirstOrDefault(p => p.Id == id);

            if (producto == null)
            {
                return NotFound();
            }

            return producto;
        }

        // POST: api/productos
        [HttpPost]
        public ActionResult<Producto> PostProducto(Producto producto)
        {
            producto.Id = productos.Count + 1;
            productos.Add(producto);
            return CreatedAtAction(nameof(GetProducto), new { id = producto.Id }, producto);
        }

        // PUT: api/productos/{id}
        [HttpPut("{id}")]
        public IActionResult PutProducto(int id, Producto producto)
        {
            var existingProducto = productos.FirstOrDefault(p => p.Id == id);

            if (existingProducto == null)
            {
                return NotFound();
            }

            existingProducto.Nombre = producto.Nombre;
            existingProducto.Precio = producto.Precio;

            return NoContent();
        }

        // DELETE: api/productos/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteProducto(int id)
        {
            var producto = productos.FirstOrDefault(p => p.Id == id);

            if (producto == null)
            {
                return NotFound();
            }

            productos.Remove(producto);

            return NoContent();
        }
    }
}
