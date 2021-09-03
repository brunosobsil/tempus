using System;
namespace Tempus.Data.Model
{
    public class Funcao
    {
        public virtual int Codigo { get; set; }
        public virtual string Descricao { get; set; }

        public Funcao(int codigo, string descricao)
        {
            this.Codigo = codigo;
            this.Descricao = descricao;
        }

        public Funcao()
        {
        }
    }
}
