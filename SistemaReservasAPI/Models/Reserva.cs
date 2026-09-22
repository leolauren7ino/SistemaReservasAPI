namespace SistemaReservasAPI.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public DateTime DataHoraInicio { get; set; }
        public DateTime DataHoraFim { get; set; }

        public int RecursoId { get; set; }
        public Recurso Recurso { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
