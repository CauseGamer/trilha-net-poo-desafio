using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia N1 = new Nokia("28716723896");
N1.InserirMemoria(1000000);
N1.InserirIMEI("2781217826213634654");
N1.InserirModelo("Nokia Atomico");
N1.ListarInformacao();


Console.WriteLine("-------------------------------");


Iphone I1 = new Iphone("72136432934");
I1.InserirMemoria(256);
I1.InserirIMEI("1217826242342342324");
I1.InserirModelo("Iphone 14");
I1.ListarInformacao();

