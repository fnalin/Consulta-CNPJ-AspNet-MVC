
namespace Demo.ConsultaCNPJ.Models
{
    public class Empresa
    {

        public Empresa(string cnpj, string razaosocial, string nomefantasia, string endereco, string bairro, string cep,
            string cnae, string cidade, string estado)
        {
            this.CNPJ = cnpj;
            this.Razaosocial = razaosocial;
            this.NomeFantasia = nomefantasia;
            this.Endereco = endereco;
            this.Bairro = bairro;
            this.Cep = cep;
            this.Cnae = cnae;
            this.Cidade = cidade;
            this.Estado = estado;
        }

        public string CNPJ { get; private set; }

        public string Razaosocial { get; private set; }

        public string NomeFantasia { get; private set; }

        public string Endereco { get; private set; }

        public string Bairro { get; private set; }

        public string Cep { get; private set; }

        public string Cnae { get; private set; }

        public string Cidade { get; private set; }

        public string Estado { get; private set; }
    }
}