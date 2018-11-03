using System;

//namespace demomvc.Models
namespace SRVFlorerias.Models
{
    public class Producto
    {   
        //Id
        public int Id { get; set; }
        //Tipo
        public string Tipo { get; set; }
        //Nombre
        public string Nombre { get; set; }
        //Categoría
        public string Categoria { get; set; }
        //Precio
        public double Precio { get; set; }
        public double Stock { get; set; }
        public double Dscto { get; set; }
        public string Descripcion { get; set; }
        public string Foto { get; set; }
    }       

}
