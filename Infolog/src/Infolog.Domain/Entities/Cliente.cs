namespace Infolog.Domain.Entities
{
    public class Cliente : BaseEntity
    {
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }

        //Criar a entidade endereço e relacionar na entidade cliente 1:1
        //public virtual int CodEndereco { get; set; }
        //public virtual Endereco Endereco { get; set; }
    }
}