
Console.Write("Veuillez saisir votre premier nombre : ");
double premierNombre = double.Parse(Console.ReadLine());
Console.Write("Veuillez saisir votre premier nombre : ");
double deuxiemeNombre = double.Parse(Console.ReadLine());

double resultat = premierNombre + deuxiemeNombre;
Console.WriteLine($"Le résultat de votre addition est de : {resultat} ");
Console.WriteLine("Appuyez sur entrée pour quitter.");
Console.ReadKey();
