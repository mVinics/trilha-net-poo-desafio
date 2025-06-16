using DesafioPOO.Models;

// Implementado

Iphone i = new Iphone("(00)1234-5678", "000", 18);
Nokia n = new Nokia("(00)5678-1234", "111", 25);

i.Ligar();
n.Ligar();

i.ReceberLigacao();
n.ReceberLigacao();

i.InstalarAplicativo("Aplicativo iphone");
n.InstalarAplicativo("Aplicativo nokia");
