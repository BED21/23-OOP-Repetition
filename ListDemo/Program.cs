List<string> djur = new List<string>();
djur.Add("Katt");
djur.Add("Hund");
djur.Add("Orm");
PrintItems(djur);



djur.Sort();
PrintItems(djur);

djur[1] = "Häst";
PrintItems(djur);

djur.RemoveAt(1);
PrintItems(djur);

Console.ReadKey();

void PrintItems(List<string> djur)
{
    Console.WriteLine("\n\n");
    foreach (var d in djur)
    {
        Console.WriteLine(d);
    }
}

