namespace LHPet.Models
{
    public class Cliente
    {
        // Atributos da classe Cliente e seus getters e setters correspondentes.
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Paciente { get; set; }

        // Construtor da classe Cliente que recebe parâmetros na criação das instâncias.
        public Cliente(int id, string nome, string cpf, string email, string paciente)
        {
            this.Id = id;
            this.Nome = nome;
            this.Cpf = cpf;
            this.Email = email;
            this.Paciente = paciente;
        }
    }
}
