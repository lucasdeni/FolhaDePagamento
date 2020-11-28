using System;
using System.Collections.Generic;
using System.Text;

namespace FolhaDePagamento
{
    class FuncionarioTercerizado : Funcionário
    {
        public double Adicional { get; set; } //Declaração das variaveis e encapsulamento
        public FuncionarioTercerizado()
        {
            //Construtor padrão
        }
        public FuncionarioTercerizado(string nome, int horas, double valor, double adicional) : base(nome, horas, valor) //Construtor com parametros
        {
            Adicional = adicional;
        }
        public override double Pagamento() //Calcular o pagamento do funcionário tercerizado
        {
            return Horas * Valor + Adicional * 1.1;
        }
    }
}
