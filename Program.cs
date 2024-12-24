using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("=====================================");

Nokia n = new Nokia("123456789", "Nokia 3310", "123456789", 16);
n.Ligar();
n.ReceberLigacao();
n.InstalarAplicativo("Whatsapp");
n.Dados();
Console.WriteLine("=====================================");

Iphone i = new Iphone("987654321", "Iphone 12", "987654321", 128);
i.Ligar();
i.ReceberLigacao();
i.InstalarAplicativo("Instagram");
i.Dados();