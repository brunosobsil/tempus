using System.Collections.Generic;
using Tempus.Data.Model;

namespace Tempus.BLL.Services
{
    public class FuncionarioService : IFuncionarioService
    {
        public FuncionarioService()
        {

        }

        public IEnumerable<Funcionario> GetAll()
        {
            var funcionarios = new List<Funcionario>();
            /*
            var empresa = new Empresa();
            var hora = new Horario();
            var funcao = new Funcao();
            var depart = new Departamento();
            var f1 = new Funcionario(1, "Leandro Nunes e Silva", "123456", "123456", empresa, hora, funcao, depart, System.DateTime.Now, System.DateTime.Now, "Teste");
            var f2 = new Funcionario(2, "Bruno Sobral Silva", "123456", "123456", empresa, hora, funcao, depart, System.DateTime.Now, System.DateTime.Now, "Teste");
            var f3 = new Funcionario(3, "Fernando Cesar de Arantes Nicolau", "123456", "123456", empresa, hora, funcao, depart, System.DateTime.Now, System.DateTime.Now, "Teste");

            funcionarios.Add(f1);
            funcionarios.Add(f2);
            funcionarios.Add(f3);
            */
            return funcionarios;
        }
    }
}
