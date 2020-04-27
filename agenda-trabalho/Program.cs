using System;
using System.Collections.Generic;
using System.Linq;

namespace agenda_trabalho
{
    class Program
    {
        static void Main(string[] args)
        {
            var agenda = new List<Trabalho>();
            var menu = new Menu();
            menu.iniciar();
            while (menu.verificarEscolha()) {
                if (menu.escolha == "I") {
                    var trabalho = new Trabalho();
                    trabalho.codigo = agenda.Count + 1;
                    Console.WriteLine("digite a data de entrega.");
                    trabalho.dataEntrega = Console.ReadLine();
                    Console.WriteLine("digite a descrição do trabalho.");
                    trabalho.descricaoTrabalho =  Console.ReadLine();
                    Console.WriteLine("digite a disciplina.");
                    trabalho.disciplina = Console.ReadLine();
                    Console.WriteLine("digite o status.");
                    trabalho.status = Console.ReadLine();
                    agenda.Add(trabalho);
                    
                }
                if (menu.escolha == "R") {
                    Console.WriteLine("Digite uma data");

                    var data = Console.ReadLine();
                    var trabalhos = agenda.Where(trab => trab.dataEntrega == data)
                    .Select(item => item).ToList();

                    trabalhos.ForEach(trab => {
                        agenda.Remove(trab);
                    });
                }
                if (menu.escolha == "C") {
                    Console.WriteLine("Digite uma data");

                    var data = Console.ReadLine();
                    var trabalhos = agenda.Where(trab => trab.dataEntrega == data)
                    .Select(item => item).ToList();

                    trabalhos.ForEach(item => {
                        Console.WriteLine("-------------------");
                        Console.WriteLine($"codigo: {item.codigo}");
                        Console.WriteLine($"dataEntrega: {item.dataEntrega}");
                        Console.WriteLine($"descricaoTrabalho: {item.descricaoTrabalho}");
                        Console.WriteLine($"disciplina: {item.disciplina}");
                        Console.WriteLine($"status: {item.status}");
                    });
                }
                if (menu.escolha == "E") {
                    agenda.ForEach(item => {
                        Console.WriteLine("-------------------");
                        Console.WriteLine($"codigo: {item.codigo}");
                        Console.WriteLine($"dataEntrega: {item.dataEntrega}");
                        Console.WriteLine($"descricaoTrabalho: {item.descricaoTrabalho}");
                        Console.WriteLine($"disciplina: {item.disciplina}");
                        Console.WriteLine($"status: {item.status}");
                    });
                }
                if (menu.escolha == "F") {
                    Environment.Exit(0);
                }
                menu.iniciar();
            }
        }
    }
}
