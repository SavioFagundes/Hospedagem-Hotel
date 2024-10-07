using Hospedagem_Hotel.Entities;
namespace Hospedagem_Hotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> hospedes = new List<Pessoa>();

            Pessoa p1 = new Pessoa("Savio","Fagundes");
            Pessoa p2 = new Pessoa("Thassyano","Fagundes");
            
            hospedes.Add(p1);
            hospedes.Add(p2);
            

            Suite suite = new Suite("Premium", 3, 30);

            Reserva reserva = new Reserva(10);
            reserva.CadastrarSuite(suite);
            reserva.CadastrarHospedes(hospedes);
            Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
            Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");

        }
    }
}