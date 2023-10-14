using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyBooking.Models
{
    [Table("AmbienteDevs")]
    public class AmbienteDev
    {
        [Key]

        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name = "Nome do Ambiente")]
        public string NomeAmbiente { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Display(Name = "Id do Ambiente")]
        public int Descricao { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public int Capacidade { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public int Disponibilidade { get; set; }

        public ICollection <Reserva> Reservas { get; set; }
    }
}
