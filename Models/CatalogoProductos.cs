using System.Collections.Generic;
using System.Linq;

namespace SRVFlorerias.Models
{
    public class CatalogoProductos
    {
        private List<Producto> _datos = new List<Producto>();

        public CatalogoProductos() {
            _datos.Add(new Producto {
                Id = 1,
                Nombre = "Rosas",
                Foto = "https://www.florerialasdonas.com/upload/15149063011800flw.112s.jpg"
            });
            _datos.Add(new Producto {
                Id = 2,
                Nombre = "Girasoles",
                Foto = "https://www.florerialasdonas.com/upload/1501720178girasoles600.jpg"
            });
            _datos.Add(new Producto {
                Id = 3,
                Nombre = "Centro de mesa",
                Foto = "https://www.florerialasdonas.com/media/images/shopping-cart.png"

                
            });
        }
        public List<Producto> Listar() {
            return _datos;
        }

        public Producto ObtenerPorId(int id) {
            return _datos.FirstOrDefault(p => p.Id == id);
        }
    }
}