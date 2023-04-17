


int salaireBrut = Int32.Parse(args[0]);
Console.WriteLine(salaireBrut);
decimal impotSurLeRevenu = Decimal.Parse(args[1]);

decimal salaireNet = salaireBrut - (salaireBrut * impotSurLeRevenu);

Console.WriteLine("Le salaire net est de : " + salaireNet / 12 + " euros");
