using System.Collections.Generic;

namespace aula03 {
  public class Cliente {
    public string Nome;
    public string Agencia;
    public string Conta;
    public List<Cartao> Cartoes = new List<Cartao>();

    public Cliente(string nome, string agencia, string conta) {
      this.Nome = nome;
      this.Agencia = agencia;
      this.Conta = conta;
    }
  }
}
