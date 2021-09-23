namespace Tempus.Data.Model
{
    public class Relogio
    {
        public virtual string Numero { get; set; }
        public virtual string IP { get; set; }
        public virtual string Descricao { get; set; }
        public virtual Empresa Empresa { get; set; }

        public Relogio(string numero, string ip, string descricao, Empresa empresa)
        {
            this.Numero = numero;
            this.IP = ip;
            this.Descricao = descricao;
            this.Empresa = empresa;
        }

        public Relogio() { }
    }
}
