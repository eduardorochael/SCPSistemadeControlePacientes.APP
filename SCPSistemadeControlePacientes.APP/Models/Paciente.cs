using SQLite;

namespace MeuAppPacientes.Models
{
    public class Paciente
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
    }
}