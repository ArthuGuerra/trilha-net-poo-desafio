using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone


Console.WriteLine("Smartphone Nokia");

Smartphone nokia = new Nokia(numero: "12345",modelo:"Blackberry",imei: "1111111",memoria: 64);
nokia.Ligar();
// nokia.ReceberLigacao();   
nokia.InstalarAplicativo("Wnatsapp");


Console.WriteLine("\n");


Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "98764",modelo: "15 S+ PRO", imei: "22222222",memoria:128);
// iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Spotify");

Console.WriteLine("\n");


Console.WriteLine("Smartphone Samsumg Galaxy S24-PRO ");
Smartphone samsung = new Samsung(numero: "999999",modelo: "Galaxy S24-PRO",imei:"333333",memoria:256);
samsung.Ligar();
//iphone.ReceberLigacao();
samsung.InstalarAplicativo("Instagram");

Console.WriteLine("\n");


// Se quiser printar as informaçoes de cada.

// nokia.ExibirDados();
// iphone.ExibirDados();
// samsung.ExibirDados();





