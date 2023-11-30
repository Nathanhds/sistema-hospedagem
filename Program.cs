using System.Text;
using hospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Nathan");
Pessoa p2 = new Pessoa(nome: "Beatriz");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a Suíte 
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hospedes
Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor total
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor total: {reserva.CalcularValorTotal()}");







