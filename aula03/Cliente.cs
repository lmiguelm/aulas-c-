using System.Collections.Generic;

namespace aula03 {
  public class Cliente {
    public string Nome;
    public string Documento;
    public List<Cartao> Cartoes = new List<Cartao>();
    public Conta Conta;

    public Cliente(string nome, string documento, Conta conta) {
      this.Nome = nome;
      this.Documento = documento;
      this.Conta = conta;
    }
  }
}
