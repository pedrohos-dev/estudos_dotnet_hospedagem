using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa>? Hospedes { get; set; }
        public Suite? Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes.Count <= Suite!.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("A capacidade dos héspedes não pode exceder a capacidade da suíte");
            }

        }
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }
        public int ObterQuantidadeHospedes => Hospedes!.Count != 0 ? Hospedes!.Count : throw new ArgumentException("Não há hóspedes");

        public decimal CalcularValorDiaria => DiasReservados < 10 ? DiasReservados * Suite!.ValorDiaria : (DiasReservados) * (Suite!.ValorDiaria) * (0.9M);
    }
}