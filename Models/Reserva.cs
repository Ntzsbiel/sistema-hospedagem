using System.Linq.Expressions;

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
            // Verifica se a capacidade é maior ou igual ao número de hóspedes sendo recebido

            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                // Retorna uma exception caso a capacidade seja menor que o número de hóspedes recebido
                throw new Exception("Capacidade de Hospedes não suportada");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public string ObterQuantidadeHospedes()
        {
            // Retorna a quantidade de hóspedes (propriedade Hospedes)
            return $"A quantidade de hóspedes é: {Hospedes.Count }";
        }

        public string CalcularValorDiaria()
        {
            // Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%

            decimal valor = 0M;

            if (DiasReservados >= 10)
            {
                valor = (Suite.ValorDiaria * DiasReservados) * 0.90M ;
            }else{
                valor = (Suite.ValorDiaria * DiasReservados);
            }

            return $"O valor total para {DiasReservados} dias é: {valor.ToString("C")}";
        }
    }
}