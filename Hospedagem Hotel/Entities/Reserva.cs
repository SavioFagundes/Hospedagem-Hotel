using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospedagem_Hotel.Entities
{
    internal class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }
        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }
        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            //Checa se passou da capacidade
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception($"A quantidade de hóspedes não pode exceder a capacidade da suíte que é de: {Suite.Capacidade} pessos");
            }
        }
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }
        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }
        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;

            if(DiasReservados >= 10)
            {
                decimal desconto = valor * Convert.ToDecimal(0.10);
                valor = valor - desconto;
            }
            return valor;
        }
    }
}
