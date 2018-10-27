using System;

//namespace demomvc.Models
namespace SRVFlorerias.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public double Precio { get; set; }
        public double Stock { get; set; }
        public double Dscto { get; set; }
        public string Descripcion { get; set; }
        public string Foto { get; set; }
    }       

}