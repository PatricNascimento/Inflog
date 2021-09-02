namespace Infolog.Domain.Entities
{
    public class Entregador : BaseEntity
    {
        public Entregador(string nome, string sobrenome, string telefone, string celular, string endereco, string veiculo, string placa)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Telefone = telefone;
            Celular = celular;
            Endereco = endereco;
            Veiculo = veiculo;
            Placa = placa;

        }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Endereco { get; set; }
        public string Veiculo { get; set; }
        public string Placa { get; set; }
    }
}
