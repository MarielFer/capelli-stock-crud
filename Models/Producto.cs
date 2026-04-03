using System.ComponentModel.DataAnnotations;

namespace CapelliStock.Models
{
    public class Producto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La peluquería es obligatoria")]
        [StringLength(100, ErrorMessage = "La peluquería no puede exceder los 100 caracteres")]
        public string Peluqueria { get; set; }

        [Required(ErrorMessage = "El precio es obligatorio")]
        [Range(1, 100000, ErrorMessage = "El precio debe ser mayor a 0")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "El stock es obligatorio")]
        [Range(0, 10000, ErrorMessage = "El stock no puede ser negativo")]
        public int Stock { get; set; }


    }
}