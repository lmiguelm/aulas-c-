using System;

namespace aula02 {
	class Program {
		static void Main(string[] args) {
			// exercicio4(1, 12, -13);
			// exercicio5();
			// exercicio6(1000);
		}

		static void exercicio4(double a, double b, double c) {

			double delta = (Math.Round(b, 2)) - (4 * a * c);
			
			if(delta < 0) {
				Console.WriteLine("Delta não pode ser negativo!");
				return;
			}

			double a1 = (-b + Math.Sqrt(delta)) / (2 * a);
			double a2 = (-b - Math.Sqrt(delta)) / (2 * a);

			Console.WriteLine(a1);
			Console.WriteLine(a2);
		} 

		static void exercicio5() {
			double saldo = 100.0;
			double valorSaque = 10.0;
			if (saldo >= valorSaque) {
				saldo -= valorSaque;
				Console.WriteLine("Saque realizado com sucesso");
			}
			else {
				Console.WriteLine("Saldo Insuficiente");
			}
		}
	
		static void exercicio6(double saldo) {
			if(saldo < 0) {
				Console.WriteLine("Você está no vermelho");
			} else if (saldo < 1000000) {
				Console.WriteLine("Você está no azul");
			} else {
				Console.WriteLine("Você está bem demais");
			}
		}
	}
}
