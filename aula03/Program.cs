using System;
using System.Collections.Generic;

namespace aula03 {
	class Program {
		static void Main(string[] args) {

			Console.Write("Informe seu nome: ");
			string nome = Convert.ToString(Console.ReadLine());

			Console.Write("Informe conta: ");
			string conta = Convert.ToString(Console.ReadLine());

			Console.Write("Informe seu agencia: ");
			string agencia = Convert.ToString(Console.ReadLine());

			Cliente cliente = new Cliente(nome, conta, agencia);	

			
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
			Console.WriteLine("Conta: {0}", cliente.Conta);
			Console.WriteLine("Agencia: {0}", cliente.Agencia);
			cliente.Cartoes.ForEach(c => {
				Console.WriteLine("Cartão número {0} tem saldo de R$ {1:00.00} e um limite de R$ {2:00.00}", c.Numero, c.Saldo, c.Limit);
			});
			Console.WriteLine();
			Console.WriteLine("=================================================================");
			Console.WriteLine();
		}	
	}
}
