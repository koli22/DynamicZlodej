using DynamicZlodej;


Console.WriteLine("Maximalni hodnota sperku");
int maxValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Maximalni velikost sperku");
int maxSize = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Kolik sperku v obchode");
int maxNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Velikost batohu");
int size = Convert.ToInt32(Console.ReadLine());


AllAlgs[] algoritmy = { new DynamicAlg() };



Obchod obchod = new Obchod(maxValue, maxSize, size, maxNum);

foreach (var alg in algoritmy)
    alg.findSolution(obchod.batohSize, obchod.sperkyVObchode);

