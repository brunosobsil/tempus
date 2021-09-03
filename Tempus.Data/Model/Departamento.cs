using System;
namespace Tempus.Data.Model
{
    public class Departamento
    {
        public virtual int Codigo { get; set; }
        public virtual string Descricao { get; set; }

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
