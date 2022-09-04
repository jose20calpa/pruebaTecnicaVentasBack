using Core.Contratos;
using Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.Servicios
{
    public class ProductoServicio : IProductoServicio
    {
        private readonly IProductoRepository _repositoryProducto;
        public ProductoServicio(IProductoRepository repository)
        {
            _repositoryProducto = repository;
        }
        public Respuesta CrearProducto(ProductoE producto)
        {
            var creado = _repositoryProducto.CrearProducto(producto);
            if (creado == 1)
            {
                return new Respuesta
                {
                    Mensaje = "Creado Exitosamente",
                    Objeto = creado,
                    ok = true
                };
            }
            return new Respuesta
            {
                Mensaje = "Error al crear el Producto",
                Objeto = 0,
                ok = false
            };
        }
        public Respuesta ObtenerProductos()
        {
            var productos = _repositoryProducto.ObtenerProductos();
            if (productos.Count > 0)
            {
                return new Respuesta
                {
                    Mensaje = "Ok",
                    Objeto = productos,
                    ok = true
                };
            }
            return new Respuesta
            {
                Mensaje = "No se han encontrado productos",
                Objeto = null,
                ok = false
            };
        }
    }
}
