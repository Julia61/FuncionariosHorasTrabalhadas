using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionariosHorasTrabalhadas
{
    internal class Funcionarios
    {
        public string Nome {  get; private set; }

        private int[] _horas;


        public Funcionarios (string nome, int dias)
        {
            Nome = nome;
            _horas = new int[dias];
        }

        public void InserindoHoras()
        {
            for(int i = 0; i < _horas.Length; i ++)
            {
                Console.Write($"Horas de trabalho no {i}° dia: ");
                _horas[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
