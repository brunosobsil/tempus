using System;
namespace Tempus.Data.Model
{
    public class Relogio
    {
        public string Numero { get; set; }
        public string IP { get; set; }
        public string Descricao { get; set; }
        public Empresa Empresa { get; set; }

        public Relogio(string numero, string ip, string descricao, Empresa empresa)
        {
            this.Numero = numero;
            this.IP = ip;
            this.Descricao = descricao;
            this.Empresa = empresa;
        }
    }
}
