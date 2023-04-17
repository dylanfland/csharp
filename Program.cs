decimal salaireBrut = 30000;
decimal impotSurLeRevenu = 0.30m;

decimal salaireNet = salaireBrut - (salaireBrut * impotSurLeRevenu);

Console.WriteLine("Le salaire net est de : " + salaireNet / 12 + " euros");