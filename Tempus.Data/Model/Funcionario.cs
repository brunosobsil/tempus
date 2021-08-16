using System;
namespace Tempus.Data.Model
{
    public class Funcionario
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public string PIS { get; set; }
        public string CTPS { get; set; }
        public Empresa Empresa { get; set; }
        public Horario Horario { get; set; }
        public Funcao Funcao { get; set; }
        public Departamento Departamento { get; set; }
        public DateTime Admissao { get; set; }
        public DateTime Demissao { get; set; }
        public string MotivoDemissao { get; set; }

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
    }
}
