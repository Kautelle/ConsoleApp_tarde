// See https://aka.ms/new-console-template for more information
using ConsoleApp_tarde;

Console.WriteLine("Hello, World!");
Console.WriteLine("oi");

Produto p1 = new Produto(1, "mouse xing ling", 10.00M);
Produto p2 = new Produto(2, "Teclado Razer", 103M);

Console.WriteLine(p1.getDescricao() + " " + p1.getValor());

p1.setValor(103M);
p2.setDescricao("Teclado Razer");

Console.WriteLine(p1.getDescricao() + " " + p1.getValor());

