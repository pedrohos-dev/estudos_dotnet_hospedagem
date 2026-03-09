using System.Text.Json.Nodes;
using hospedagem.Models;

List<Pessoa> hospedes = new List<Pessoa>();

hospedes.Add(new Pessoa("José", "Maria"));
hospedes.Add(new Pessoa("Maria", "Da Silva"));
hospedes.Add(new Pessoa("Fulano", "De Tal"));
hospedes.Add(new Pessoa("Ciclano", "Beltrano"));

Suite suite = new Suite("Premium", 10, 50M);

Reserva reserva = new Reserva(diasReservados: 20);

reserva.CadastrarSuite(suite);
try
{
    reserva.CadastrarHospedes(hospedes);
    Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes}");
    Console.WriteLine($"Valor: {reserva.CalcularValorDiaria}");

}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}


