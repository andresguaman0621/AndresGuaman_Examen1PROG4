using System.ComponentModel.DataAnnotations;

namespace AndresGuaman_Examen1PROG.Models
{
    public class AndresGuaman_tabla
    {
        [Key]
        [Required]
        public int agEmpleadoId { get; set; }
        [Range(400.00, 1500.00)]
        public decimal agSalario { get; set; }
        [StringLength(50)]
        public String? agNombre { get; set; }
        public bool agConNombramiento { get; set; }
        public DateTime agFecha { get; set; }
        [ValidarCedula]
        public String agCedula { get; set; }
    }

    public class ValidarCedula : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            String cedula = (String)value;
            if (cedula.Length == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
