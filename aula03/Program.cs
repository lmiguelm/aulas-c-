using System;
using System.Collections.Generic;

namespace aula03 {
	class Program {
		static void Main(string[] args) {


			// agencia
			Agencia bancoBrasil = new Agencia("Banco do Brasil", 12345);
			Agencia caixa = new Agencia("Caixa", 42121);
			Agencia itau = new Agencia("Itau", 19289);

			List<Agencia> agencias = new List<Agencia>{ bancoBrasil, caixa, itau };

			// cliente
			Console.Write("Informe seu nome: ");
			string nome = Convert.ToString(Console.ReadLine());

			Console.Write("Informe seu cpf: ");
			string cpf = Convert.ToString(Console.ReadLine());

			// conta
			Console.WriteLine("Escolha uma agencia: ");
			agencias.ForEach(a => Console.WriteLine("[{0}] - {1}", a.Numero, a.Nome));
			double agenciaEscolhida = Convert.ToDouble(Console.ReadLine());

			Console.Write("Informe numero da conta: ");
			double numeroConta = Convert.ToDouble(Console.ReadLine());

			Console.Write("Informe o limite da conta: ");
			double limiteConta = Convert.ToDouble(Console.ReadLine());

			Console.Write("Informe o saldo da conta: ");
			double saldoConta = Convert.ToDouble(Console.ReadLine());

			// instanciando objs
			Conta conta = new Conta(numeroConta, limiteConta, saldoConta, agenciaEscolhida);

			agencias.ForEach(a => {
				if(a.Numero == agenciaEscolhida) {
					a.Conta.Add(conta);
				}
			});

			Cliente cliente = new Cliente(nome, cpf, conta);	

			char flag = 'y';
			do {	
				Console.Write("\n");
				Console.WriteLine("=================================================================");
				Console.Write("Numero do seu cartão: ");
				double numero = Convert.ToDouble(Console.ReadLine());

				Console.Write("Saldo do seu cartão: ");
				double saldo = Convert.ToDouble(Console.ReadLine());

				Console.Write("Limite do seu cartão: ");
				double limite = Convert.ToDouble(Console.ReadLine());

				cliente.Cartoes.Add(new Cartao(numero, saldo, limite));

				Console.Write("Deseja adicionar mais cartões? (y/n)");
				flag = Convert.ToChar(Console.ReadLine());
				Console.WriteLine("=================================================================");

			} while(flag == 'y');

			Console.Write("\n\n");
			Console.WriteLine();
			Console.WriteLine("=================================================================");
			Console.WriteLine();
			Console.WriteLine("Cliente: {0}", cliente.Nome);
			Console.WriteLine("CPF: {0}", cliente.Documento);
			Console.WriteLine("=================================================================");
			Console.WriteLine("Conta: {0}", conta.Numero);
			Console.WriteLine("Limite: {0}", conta.Limite);
			Console.WriteLine("Saldo: {0}", conta.Saldo);
			agencias.ForEach(a => {
				if(a.Numero == agenciaEscolhida) {
					Console.WriteLine("Agencia: {0}", a.Nome);
					Console.WriteLine("Numero: {0}", a.Numero);
				}
			});
			Console.WriteLine("=================================================================");
			cliente.Cartoes.ForEach(c => {
				Console.WriteLine("Cartão número {0} tem saldo de R$ {1:00.00} e um limite de R$ {2:00.00}", c.Numero, c.Saldo, c.Limit);
			});
			Console.WriteLine();
			Console.WriteLine("=================================================================");
			Console.WriteLine();
		}	
	}
}
