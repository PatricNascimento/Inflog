namespace Infolog.Domain.Entities
{
    public class Endereco : BaseEntity
    {
        public Endereco(string logradouro, string numero, string complemento, string cep, string cidade, string uf)
        {
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Cep = cep;
            Cidade = cidade;
            Uf = uf;
        }

        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }

    }
}
