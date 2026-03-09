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

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            Hospedes.Add(new Pessoa());

        }
        public void CadastrarSuite(Suite suite)
        {

        }
        public dynamic ObterQuantidadeHospedes => Hospedes!.Count != 0 ? Hospedes!.Count : "Não há hóspedes";
        
        public decimal CalcularValorDiaria()
        {
            

        }
    }
}