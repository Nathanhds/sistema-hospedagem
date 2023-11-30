namespace hospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva(int diasReservados) {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes) 
        {
            bool capacidadeDisponivel = hospedes.Count() <= Suite.Capacidade;

            if(capacidadeDisponivel)
            {
                Hospedes = hospedes;
            }
            else
            {
                Console.WriteLine(new Exception("A Suite desejada não comporta o número de hospedes"));
            }
        }

        public void CadastrarSuite(Suite suite) 
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count();
        }

        public decimal CalcularValorTotal() 
        {
            decimal valor = Suite.ValorDiaria * DiasReservados;

            if(DiasReservados >= 10) 
            {
                valor = valor / 100 * 90;
            }

            return valor;
        }

    }
}