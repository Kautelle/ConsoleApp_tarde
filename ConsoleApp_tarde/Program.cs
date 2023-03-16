﻿// See https://aka.ms/new-console-template for more information
using ConsoleApp_Tarde;
using ConsoleApp_Tarde.Heranca;

Produto p1 = new Produto(1,"Mouse xing ling", 10.90M);
Produto p2 = new Produto(2,"Teclado xuxa", 20.90M);

Console.WriteLine(p1.getDescricao() + " " + p1.getValor());

p1.setValor(29.90M);
p1.setDescricao("Mouse Razer");

Console.WriteLine(p1.getDescricao() + " " + p1.getValor());

Endereco e1 = new Endereco(1, "265542", "Rua Francisco Ponzio", 63, "Vila rosa", "Taquaritinga" );


Cliente c1 = new Cliente(1, "Fernando", "991340447",e1);
Cliente c2 = new Cliente(2, "Victoria", "991340447",e1);
Cliente c3 = new Cliente(3, "Rafael", "991340447", e1);
Cliente c4 = new Cliente(4, "Lucas", "9913409876" ,e1  );
Cliente c5 = new Cliente(5, "Eduardo", "991340447", e1);


Console.WriteLine(c1.getEndereco().EnderecoCompleto()  );
c1.getEndereco().setRua("Francisco Ponzio");
Console.WriteLine(c1.getEndereco().EnderecoCompleto() );
c1.getEndereco().AtualizarEndereco("Peixoto", 222, "Gabriel peixoto");
Console.WriteLine(c1.getEndereco().EnderecoCompleto());

Carro car = new Carro();
car.cor = "Amarelo";
car.q_Rodas = 4;
car.q_Assentos = 5;
car.TemMotor = true;

Bike bicicleta = new Bike();
bicicleta.cor = "Roxo";
bicicleta.q_Rodas = 2;
bicicleta.q_Assentos = 1;
bicicleta.TemMotor = false;

Aviao aviao = new Aviao();
aviao.q_Assentos = 184;
aviao.q_Rodas = 18;
aviao.cor = "Rosa";
aviao.TemMotor = true;


List<Veiculo> veiculoLista = new List<Veiculo>();
veiculoLista.Add(car);
veiculoLista.Add(aviao);
veiculoLista.Add(bicicleta);

foreach (var item in veiculoLista)
{
    Console.WriteLine(item.ExibirDados());
}

Console.WriteLine("Quantidade de itens da lista " + veiculoLista.Count);

//Crie duas lista 
//Uma lista de Produtos com 400 produtos
//Outra lista de Clientes com 250 clientes

Random rand = new Random();

List<Produto> lsProdutos = new List<Produto>();
for (int i = 0; i < rand.Next(200,500); i++)
{
    Produto p = new Produto(i, "Produto tal" + i, i / 2 * 15);
    lsProdutos.Add(p);
}

foreach (var item in lsProdutos)
{
    Console.WriteLine(item.ExibirDados());
}

List<Cliente> listaClientes = new List<Cliente>();
for (int i = 0; i < rand.Next(200, 500); i++)
{
    Endereco e = new Endereco(1, "Rua", "256325", 1, "", "");
    Cliente c = new Cliente(i,"Nome Tal " + i, "Telefone tal" + 1, e);
    listaClientes.Add(c);
}

foreach (var item in listaClientes)
{
    Console.WriteLine(item.ExibirDados());
}


