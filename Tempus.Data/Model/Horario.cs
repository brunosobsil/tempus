using System;
namespace Tempus.Data.Model
{
    public class Horario
    {
        public DiasDaSemana DiaDaSemana { get; set; }
        public DateTime Entrada1 { get; set; }
        public DateTime Saida1 { get; set; }
        public DateTime Entrada2 { get; set; }
        public DateTime Saida2 { get; set; }
        public DateTime Entrada3 { get; set; }
        public DateTime Saida3 { get; set; }

        public Horario(DiasDaSemana diaDaSemana,
                       DateTime entrada1,
                       DateTime saida1,
                       DateTime entrada2,
                       DateTime saida2,
                       DateTime entrada3,
                       DateTime saida3)
        {
            this.DiaDaSemana = diaDaSemana;
            this.Entrada1 = entrada1;
            this.Saida1 = saida1;
            this.Entrada2 = entrada2;
            this.Saida2 = saida2;
            this.Entrada3 = entrada3;
            this.Saida3 = saida3;
        }
    }
}
