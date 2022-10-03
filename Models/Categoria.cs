using System.ComponentModel.DataAnnotations;

namespace AdminIngresosGastos.Models {
    public class Categoria {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        [Display(Name ="Nombre Categoria")]
        public string NombreCategoria { get; set; }
        [Required]
        [MaxLength (2)]
        [Display(Name ="Tipo")]
        public string Tipo { get; set; } // IN Ingreso, GA Gasto
        [Required]
        public bool Estado { get; set; } //True, False
    }
}
