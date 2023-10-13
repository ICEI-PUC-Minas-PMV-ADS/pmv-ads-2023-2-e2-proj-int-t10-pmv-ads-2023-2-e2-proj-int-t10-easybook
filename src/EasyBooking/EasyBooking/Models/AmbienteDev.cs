using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyBooking.Models
{
    [Table("AmbienteDevs")]
    public class AmbienteDev
    {
        [Key]

        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome do ambiente!")]
        public int NomeAmbiente { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a descrição do ambiente!")]
        public int Descricao { get; set; }
        
        public int Capacidade { get; set; }
        
        public int Disponibilidade { get; set; }
    }
}
