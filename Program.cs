using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia s1 = new Nokia("9999", "tijolo", "seila", 4);
Iphone i1 = new Iphone("1111", "Iphone 15", "seinao", 32);
Nokia s2 = new Nokia("8888", "pedra", "naosei", 8);
s1.Ligar();
i1.ReceberLigacao();
i1.InstalarAplicativo("youtube");
s2.InstalarAplicativo("auxilio Emergencial");