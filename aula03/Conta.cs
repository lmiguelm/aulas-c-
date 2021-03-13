using System;

namespace aula03 {
  public class Conta {
    public double Numero;
    public double Limite;
    public double Saldo;
    public double AgenciaID;

    public Conta(double numero, double limite, double saldo, double agenciaId) {
      this.Numero = numero;
      this.Limite = limite;
      this.Saldo = saldo;
      this.AgenciaID = agenciaId;
    }
  }
}