namespace DesafioProjetoHospedagem.Models
{

    public class Reserva
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
            if (Suite.Capacidade <= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                Console.WriteLine("A quantidade de hospedes ultrapassa a capacidade da suíte");
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

            if (DiasReservados >= 10)
            {
                decimal valor1 = valor;
                double percentual = 10.0 / 100.0;
                double valorFinal = ((double)valor) - (percentual * ((double)valor));
                Console.WriteLine($"Você recebeu um desconto de 10% seu valor final é de: " + valorFinal);
            }

            return valor;
        }
    }
}