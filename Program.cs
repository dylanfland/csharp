Console.WriteLine("Entrez le salaire brut : ");
decimal salaireBrut = Decimal.Parse(Console.ReadLine());

Console.WriteLine("Entrez l'impôt sur le revenu : ");
decimal impotSurLeRevenu = Decimal.Parse(Console.ReadLine());

decimal salaireNet = salaireBrut - (salaireBrut * impotSurLeRevenu);

Console.WriteLine("Le salaire net est de : " + salaireNet / 12 + " euros");