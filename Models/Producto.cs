namespace ApiProducto.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public decimal Precio { get; set; }
        public DateTime FechaAlta { get; set; }
        public bool Activo { get; set; }
    }
}