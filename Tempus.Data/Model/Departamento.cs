using System;
namespace Tempus.Data.Model
{
    public class Departamento
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }

        public Departamento(int codigo, string descricao)
        {
            this.Codigo = codigo;
            this.Descricao = descricao;
        }

        public Departamento()
        {
        }
    }
}
