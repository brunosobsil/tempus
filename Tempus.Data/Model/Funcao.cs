using System;
namespace Tempus.Data.Model
{
    public class Funcao
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }

        public Funcao(int codigo, string descricao)
        {
            this.Codigo = codigo;
            this.Descricao = descricao;
        }
    }
}
