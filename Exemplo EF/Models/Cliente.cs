namespace Exemplo_EF.Models
{
    public class Cliente
    {
        public Guid ClienteID { get; set; }
        public string ClienteName { get; set; }
        public DateTime Nascimento { get; set; }
    }
}
