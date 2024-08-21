namespace DesafioFundamentos.Models
{
	public class Estacionamento
	{
		private decimal precoInicial = 0;
		private decimal precoPorHora = 0;
		private List<string> veiculos = new();

		public Estacionamento(decimal precoInicial, decimal precoPorHora)
		{
				this.precoInicial = precoInicial;
				this.precoPorHora = precoPorHora;
		}

		// Este método permite alterar os valores das variáveis de preço
		public void AlterarPreco()
		{
			Console.WriteLine("Digite o novo valor do preço de entrada:");
			precoInicial = Convert.ToDecimal(Console.ReadLine());

			Console.WriteLine("Agora digite o novo preço por hora:");
			precoPorHora = Convert.ToDecimal(Console.ReadLine());
		}

		public void AdicionarVeiculo()
		{
			Console.WriteLine("Digite a placa do veículo para estacionar:");
			
			// O usuário digita uma placa (ReadLine) e ela é adicionada na lista "veiculos"
			veiculos.Add(Console.ReadLine());
		}

		public void RemoverVeiculo()
		{
			Console.WriteLine("Digite a placa do veículo para remover:");

			string placa = Console.ReadLine();

			// Verifica se o veículo existe
			if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
			{
				Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
				
				int horas = Convert.ToInt32(Console.ReadLine());
				decimal valorTotal = 0; 

				// Realiza um cálculo de preço com base nas horas em que o veículo esteve estacionado
				while (horas >= 1)
				{
					valorTotal = precoInicial + precoPorHora * horas;
					break;
				}

				// Remover a placa digitada da lista de veículos
				veiculos.Remove(placa);

				Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
			}
			else
			{
					Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
			}
		}

		public void ListarVeiculos()
		{
				// Verifica se há veículos no estacionamento
			if (veiculos.Any())
			{
				Console.WriteLine("Os veículos estacionados são:");
				// Realizar um laço de repetição, exibindo os veículos estacionados
				for (int i = 0; i < veiculos.Count; i++)
				{
					Console.WriteLine($"O veículo {veiculos[i]} está na vaga N°{i}");
				}
			}
			else
			{
				Console.WriteLine("Não há veículos estacionados.");
			}
		}
	}
}
