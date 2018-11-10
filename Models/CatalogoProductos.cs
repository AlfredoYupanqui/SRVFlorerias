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
                Foto = "https://www.marysfloreria.com/wp-content/uploads/2018/08/plush-y-tulip.jpg"
                
            });
           
            _datos.Add(new Producto {
                Id = 2,
                Nombre = "Girasoles",
                Foto = "https://www.marysfloreria.com/wp-content/uploads/2016/08/centro-girasoles2.jpg"
            
            });
            _datos.Add(new Producto {
                Id = 3,
                Nombre = "Coronas",
                Foto = "https://www.marysfloreria.com/wp-content/uploads/2018/08/lila.jpg"
                
                
            });
            _datos.Add(new Producto {
                Id = 4,
                Nombre = "Tulipanes Primaveral",
                Foto = "https://www.marysfloreria.com/wp-content/uploads/2016/07/Tulipanes05.jpg"
               
                
            });
             _datos.Add(new Producto {
                Id = 5,
                Nombre = "Inaguración",
                Foto = "https://www.marysfloreria.com/wp-content/uploads/2016/07/Inaguraciones07.jpg"
               
                
            });
            _datos.Add(new Producto {
                Id = 5,
                Nombre = "Cumpleaños",
                Foto = "https://www.marysfloreria.com/wp-content/uploads/2018/08/ana.jpg"
                
                
            });
            _datos.Add(new Producto {
                Id = 6,
                Nombre = "Bouquets",
                Foto = "https://www.marysfloreria.com/wp-content/uploads/2016/07/4-bouquet-04-1006x1024.jpg"
               
                
            });
              _datos.Add(new Producto {
                Id = 7,
                Nombre = "Nacimiento",
                Foto = "https://www.marysfloreria.com/wp-content/uploads/2016/07/ES-NENA.jpg"
               
                
            });
              _datos.Add(new Producto {
                Id = 8,
                Nombre = "Ramos",
                Foto = "https://www.marysfloreria.com/wp-content/uploads/2016/08/ramo-cono-gerberas2.jpg"
               
                
            });
              _datos.Add(new Producto {
                Id = 9,
                Nombre = "Arreglo con Vino",
                Foto = "https://www.marysfloreria.com/wp-content/uploads/2016/07/cesta-vino.jpg"
               
                
            });
              _datos.Add(new Producto {
                Id = 10,
                Nombre = "Florero con Gerberas",
                Foto = "https://www.marysfloreria.com/wp-content/uploads/2016/07/florero-primaveral-gerberas.jpg"
               
                
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