using System;
using System.Collections.Generic;

namespace aula03 {
  public class Agencia {
    public string Nome;
    public double Numero;
    public List<Conta> Conta = new List<Conta>();

    public Agencia(string nome, double numero) {
      this.Nome = nome;
      this.Numero = numero;
    }
  }
}