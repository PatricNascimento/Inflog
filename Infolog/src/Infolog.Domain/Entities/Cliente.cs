namespace Infolog.Domain.Entities
{
    public class Cliente : BaseEntity
    {
        public Cliente()
        {

        }

        public Cliente(string nomeFantasia, string razaoSocial, string telefone, string celular, string cnpj, Endereco enderecoPrincipal)
        {
            NomeFantasia = nomeFantasia;
            RazaoSocial = razaoSocial;
            Telefone = telefone;
            Celular = celular;
            Cnpj = cnpj;
            EnderecoPrincipal = enderecoPrincipal;

        }

        #region Propriedades
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        #endregion

        #region Agregados
        // cria um propriedade virtual 
        public int CodEnderecoPrincipal { get; set; }
        public virtual Endereco EnderecoPrincipal { get; set; }


        #endregion

        //Criar a entidade endereço e relacionar na entidade cliente 1:1
        //public virtual int CodEndereco { get; set; }
        //public virtual Endereco Endereco { get; set; }
    }
}