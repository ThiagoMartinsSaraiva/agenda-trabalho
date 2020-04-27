using System;

namespace agenda_trabalho
{
  class Menu
  {
    public string escolha { get; set; }
    public void iniciar() 
    {
      Console.WriteLine("I - Insere um novo trabalho na agenda");
      Console.WriteLine("R - Remove um trabalho da agenda");
      Console.WriteLine("C - Consulta os trabalho da agenda por data");
      Console.WriteLine("E - Exibe todos os trabalhos da agenda");
      Console.WriteLine("F - Termina a execução do programa");
      this.escolha = Console.ReadLine();
    }

    public bool verificarEscolha() {
      return (string.IsNullOrEmpty(escolha) || escolha == "I" || escolha == "R" || escolha == "C" || escolha == "E" || escolha == "F");
    }
  }
}