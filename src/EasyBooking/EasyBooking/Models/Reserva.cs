using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyBooking.Models
{
    [Table("Reserva")]
    public class Reserva
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Data e Hora de Início")]
        public DateTime DataHoraInicio { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Data e Hora de Término")]
        public DateTime DataHoraTermino { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Id do usuário")]
        public int UserId { get; set; }

        //[ForeignKey("UserId")]
        //public User User{ get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Id do ambiente")]
        public int AmbienteId { get; set; }

        [ForeignKey("AmbienteId")]
        public AmbienteDev AmbienteDev { get; set; }

        
    }
    
}
