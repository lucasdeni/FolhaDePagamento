using System;
using System.Collections.Generic;
using System.Text;

namespace FolhaDePagamento
{
    class Funcionário
    {
        //Declaração das variaveis e encapsulamento
        public string Nome { get; private set; }
        public int Horas { get; private set; }
        public double Valor { get; private set; }
        public Funcionário()
        {
            //Construtor padrão
        }
        public Funcionário(string nome, int horas, double valor) //Construtor com parametros
        {
            Nome = nome;
            Horas = horas;
            Valor = valor;
        }
        public virtual double Pagamento() //Calcular o pagamento do funcionário
        {
            return Horas * Valor;
        }
    }
}
