using System.Linq;
using EasyBooking.Models;

namespace EasyBooking.Services 
{
    public class AmbienteService 
    {
        

        public int CountAvailableAmbientes(List<AmbienteDev> ambientes)
        {
            return ambientes.Count(ambiente => ambiente.Disponibilidade > 0);
        }
    }
}
