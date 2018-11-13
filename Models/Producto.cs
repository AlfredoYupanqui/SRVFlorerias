using System.ComponentModel.DataAnnotations;

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
        //Stock
        public double Stock { get; set; }
        //Descuento
        public double Dscto { get; set; }
        //Descripción
        public string Descripcion { get; set; }
        //Foto
        public string Foto { get; set; }
    }       

}
