namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            int control = 0;
            string placa = "";

            // Pede para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            placa = Console.ReadLine();

            // Verifica se o veiculo ja esta no estacionamento
            foreach(var estacionados in veiculos)
            {
                if(estacionados == placa)
                {
                    control+=1;
                    Console.WriteLine("Este veículo ja esta em nosso estacionamento.");
                }
            }
            
            if(control==0)
                veiculos.Add(placa);
            
        }

        public void RemoverVeiculo()
        {
            string placa = "";

            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pede para o usuário digitar a placa e armazenar na variável placa
            placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                
                // Pede para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                int horas = 0;
                horas = Convert.ToInt32(Console.ReadLine());

                // Realiza o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                decimal valorTotal = 0;
                valorTotal = (precoInicial + precoPorHora) * horas;

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

                // Realiza um laço de repetição, exibindo os veículos estacionados
                foreach(var estacionados in veiculos)
                {
                    Console.WriteLine($"{estacionados}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
