namespace SistemaReservasAPI.Models
{
    public class Recurso
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }

        // Navegação: um Recurso tem várias Reservas
        public List<Reserva> Reservas { get; set; }
    }
}
