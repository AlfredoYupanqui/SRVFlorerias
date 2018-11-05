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
                Id = 6,
                Nombre = "Cumpleaños",
                Foto = "https://www.marysfloreria.com/wp-content/uploads/2018/08/ana.jpg"
                
                
            });
            _datos.Add(new Producto {
                Id = 7,
                Nombre = "Bouquets",
                Foto = "https://www.marysfloreria.com/wp-content/uploads/2016/07/4-bouquet-04-1006x1024.jpg"
               
                
            });
              _datos.Add(new Producto {
                Id = 8,
                Nombre = "Nacimiento",
                Foto = "https://www.marysfloreria.com/wp-content/uploads/2016/07/ES-NENA.jpg"
               
                
            });
            _datos.Add(new Producto {
                Id = 9,
                Nombre = "Burbuja Tulipanes",
                Foto = "https://www.marysfloreria.com/wp-content/uploads/2018/08/lenteja-tulipanes.jpg"
               
                
            });
            _datos.Add(new Producto {
                Id = 10,
                Nombre = "Tesoro 03",
                Foto = "https://www.marysfloreria.com/wp-content/uploads/2018/08/caja-nva.jpg"
               
                
            });
            _datos.Add(new Producto {
                Id = 11,
                Nombre = "Oso Paletas",
                Foto = "https://www.marysfloreria.com/wp-content/uploads/2018/08/conejo-paleta.jpg"
               
                
            });
            _datos.Add(new Producto {
                Id = 12,
                Nombre = "Teddy",
                Foto = "https://www.marysfloreria.com/wp-content/uploads/2018/08/ted.jpg"
               
                
            });
            _datos.Add(new Producto {
                Id = 13,
                Nombre = "Itham",
                Foto = "https://www.marysfloreria.com/wp-content/uploads/2018/06/rosane-3.jpg"
               
                
            });
            _datos.Add(new Producto {
                Id = 14,
                Nombre = "Vino Tinto",
                Foto = "https://www.marysfloreria.com/wp-content/uploads/2018/06/vino-tinto.jpg"
               
                
            });
            _datos.Add(new Producto {
                Id = 15,
                Nombre = "Spring 36",
                Foto = "https://www.marysfloreria.com/wp-content/uploads/2018/01/28-rosas.jpg"
               
                
            });
            _datos.Add(new Producto {
                Id = 16,
                Nombre = "Niño 05",
                Foto = "https://www.marysfloreria.com/wp-content/uploads/2017/10/N10.jpg"
               
                
            });
            _datos.Add(new Producto {
                Id = 17,
                Nombre = "Pareja de Amor",
                Foto = "https://www.marysfloreria.com/wp-content/uploads/2017/02/pareja-de-osos-floral.jpg"
               
                
            });
            _datos.Add(new Producto {
                Id = 18,
                Nombre = "Canasta Floral",
                Foto = "https://www.marysfloreria.com/wp-content/uploads/2017/02/canasta-floral.jpg"
               
                
            });
            _datos.Add(new Producto {
                Id = 19,
                Nombre = "Toque de Gerberas",
                Foto = "https://www.marysfloreria.com/wp-content/uploads/2017/02/arreglo-yerberas.jpg"
               
                
            });
            _datos.Add(new Producto {
                Id = 20,
                Nombre = "Pilar de Rosas",
                Foto = "https://www.marysfloreria.com/wp-content/uploads/2017/02/arreglo-rosas-rosas.jpg"
               
                
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