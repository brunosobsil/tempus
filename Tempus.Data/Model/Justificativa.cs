using System;
namespace Tempus.Data.Model
{
    public class Justificativa
    {

        public virtual int Codigo { get; set; }
        public virtual string Descricao { get; set; }

        public Justificativa(int codigo, string descricao)
        {
            this.Codigo = codigo;
            this.Descricao = descricao;
        }

        public Justificativa() { }
        
    }
}
