using System;
namespace Tempus.Data.Model
{
    public class Empresa
    {
        public int Id { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string Responsavel { get; set; }
        public DateTime DataLiberacao { get; set; }
        public string Logo { get; set; }

        public Empresa()
        {
        }
    }
}
