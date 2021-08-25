namespace Infolog.Domain.Entities
{
    public class Entregador : BaseEntity
    {
        public Entregador(string nome, string sobrenome, string telefone, string celular, string endereco, string moto, string placa)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Telefone = telefone;
            Celular = celular;
            Endereco = endereco;
            Moto = moto;
            Placa = placa;

        }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Endereco { get; set; }
        public string Moto { get; set; }
        public string Placa { get; set; }
    }
}
