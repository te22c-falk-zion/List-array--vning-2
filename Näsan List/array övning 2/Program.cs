string typedInThing = "";
List<string> cities = new List<string>();



Console.WriteLine("Type whatever and it'll get put into the list, type exit to leave.");
while (typedInThing != "exit") 
{
    typedInThing = Console.ReadLine().ToLower();
    if (typedInThing != "exit")
    {
    cities.Add(typedInThing);
    Console.WriteLine($"Added {typedInThing}");
    }
}

Console.WriteLine("You've added:");
for (int i = 0; i < cities.Count; i++)
{
    Console.WriteLine($"{cities[i]}");
    Console.ReadLine();
}