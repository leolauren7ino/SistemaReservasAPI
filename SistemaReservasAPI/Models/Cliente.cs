namespace SistemaReservasAPI.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        // Navegação: um Cliente tem várias Reservas
        public List<Reserva> Reservas { get; set; }
    }
}
