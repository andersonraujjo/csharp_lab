using System;
using System.Collections.Generic; // Necessário para usar List<>

public class Menu {
    public static void Main() {
        // 1. Variáveis de configuração (Configuradas uma vez ao iniciar)
        List<string> listaVeiculos = new List<string>();
        
        Console.WriteLine("--- Bem-vindo ao Sistema de Estacionamento ---");
        
        Console.Write("Digite o preço inicial: ");
        decimal precoInicial = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Digite o preço por hora: ");
        decimal precoHora = Convert.ToDecimal(Console.ReadLine());

        int opcao = 0;

        // 2. Loop do Menu
        do {
            Console.WriteLine("\nDigite sua ação:");
            Console.WriteLine("1 - Cadastrar veículo");
            Console.WriteLine("2 - Remover veículo");
            Console.WriteLine("3 - Listar veículos");
            Console.WriteLine("4 - Encerrar");
            
            if (!int.TryParse(Console.ReadLine(), out opcao)) continue;

            switch (opcao) {
                case 1:
                    Console.Write("Digite a placa do veículo para estacionar: ");
                    string placa = Console.ReadLine().ToUpper(); // .ToUpper() deixa tudo em maiúsculo
                    listaVeiculos.Add(placa); 
                    Console.WriteLine($"Veículo {placa} cadastrado com sucesso!");
                    break;

                case 2:
                    Console.Write("Digite a placa do veículo para remover: ");
                    string placaRemover = Console.ReadLine().ToUpper();
                    
                    if (listaVeiculos.Contains(placaRemover)) {
                        Console.Write("Digite a quantidade de horas que o veículo permaneceu: ");
                        int horas = Convert.ToInt32(Console.ReadLine());
                        
                        // Cálculo: Preço Inicial + (Preço por Hora * Horas)
                        decimal valorTotal = precoInicial + (precoHora * horas);
                        
                        listaVeiculos.Remove(placaRemover);
                        Console.WriteLine($"O veículo {placaRemover} foi removido e o preço total foi de: R$ {valorTotal}");
                    } else {
                        Console.WriteLine("Desculpe, esse veículo não está estacionado aqui.");
                    }
                    break;

                case 3:
                    Console.WriteLine("--- Veículos Estacionados ---");
                    if (listaVeiculos.Count > 0) {
                        foreach (string v in listaVeiculos) {
                            Console.WriteLine($"- {v}");
                        }
                    } else {
                        Console.WriteLine("Não há veículos estacionados.");
                    }
                    break;

                case 4:
                    Console.WriteLine("Programa encerrado.");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        } while (opcao != 4);
    }
}