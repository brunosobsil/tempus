using System;
namespace Tempus.Data.Model
{
    public class Justificativa
    {

        public int Codigo { get; set; }
        public string Descricao { get; set; }

        public Justificativa(int codigo, string descricao)
        {
            this.Codigo = codigo;
            this.Descricao = descricao;
        }
        
    }
}
