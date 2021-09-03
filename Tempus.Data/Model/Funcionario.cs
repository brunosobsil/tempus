using System;
namespace Tempus.Data.Model
{
    public class Funcionario
    {
        public virtual int Matricula { get; set; }
        public virtual string Nome { get; set; }
        public virtual string PIS { get; set; }
        public virtual string CTPS { get; set; }
        public virtual Empresa Empresa { get; set; }
        public virtual Horario Horario { get; set; }
        public virtual Funcao Funcao { get; set; }
        public virtual Departamento Departamento { get; set; }
        public virtual DateTime Admissao { get; set; }
        public virtual DateTime Demissao { get; set; }
        public virtual string MotivoDemissao { get; set; }

        public Funcionario(int matricula,
                           string nome,
                           string pis,
                           string ctps,
                           Empresa empresa,
                           Horario horario,
                           Funcao funcao,
                           Departamento departamento,
                           DateTime admissao,
                           DateTime demissao,
                           string motivoDemissao)
        {
            this.Matricula = matricula;
            this.Nome = nome;
            this.PIS = pis;
            this.CTPS = ctps;
            this.Empresa = empresa;
            this.Horario = horario;
            this.Funcao = funcao;
            this.Departamento = departamento;
            this.Admissao = admissao;
            this.Demissao = demissao;
            this.MotivoDemissao = motivoDemissao;

        }

        public Funcionario() { }
    }
}
