Console.WriteLine("Entrez le salaire brut : ");
int salaireBrut = checkInt(Console.ReadLine());

Console.WriteLine("Entrez l'impôt sur le revenu (en %) : ");
int impotSurLeRevenu = checkInt(Console.ReadLine()) / 100;


// This is calc of the net salary
int salaireNet = salaireBrut - (salaireBrut * impotSurLeRevenu);
Console.WriteLine("Le salaire net est de : " + salaireNet / 12 + " euros");

switch (salaireBrut)
{
case var x when x > 50000:
    Console.WriteLine("Vous pouvez faire des donations pour réduire votre impôt");
    break;
case var x when x > 30000 && x < 4000:
    Console.WriteLine("Vous pouvez aller faire un BAC + 5 à l'école CESI");
    break;
case var x when x / 12 < 1500:
    Console.WriteLine("C'est un salaire normal pour un alternant");
    break;
}

// function to check if the input is an int
static int checkInt(string salary)
{
    if (int.TryParse(salary, out int value))
    {
        return int.Parse(salary);
    }
    else
    {
        Console.WriteLine("Entrez le salaire brut : ");
        string pendingBrutSalary = Console.ReadLine();
        return checkInt(pendingBrutSalary);
    }
}