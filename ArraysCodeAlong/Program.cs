int[] siffror = new int[6];
siffror[0] = 11;
siffror[1] = 12;
siffror[2] = 130;
siffror[3] = 130470;
siffror[4] = 29;
siffror[5] = -100;

for (int i = 0; i < siffror.Length; i++)
{
    Console.WriteLine(siffror[i]);
}

string[] countDown = new string[6];
countDown[0] = "Three ";
countDown[1] = "Two ";
countDown[2] = "One ";
countDown[3] = "Go...";

for (int j = 0; j < countDown.Length; j++)
{
    if (countDown[j] == "")
    {
        countDown[j] = "Ny rad";
    }
    Console.WriteLine(countDown[j]);
}

string[] saga = new string[6];
saga[0] = "Det";
saga[1] = "var";
saga[2] = "en";
saga[3] = "gång";
saga[4] = "en";
saga[5] = "gubbe";

foreach (var item in saga)
{    
    Console.WriteLine(item);
}

Console.WriteLine();
                                //  0       1           2       3
int[,] siffror2 = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
Console.WriteLine($"\n\nElement [2,1] = {siffror2[2, 1]}");

string[,] tabell = { { "Anna", "Johan", "Esmeralda" }, { "Stockholm", "Göteborg", "Malmö" } };

for (int i = 0; i < 1; i++)
{
    for (int k = 0; k < 3; k++)
    {
        Console.WriteLine($"{tabell[i, k]} bor i {tabell[i+1, k]}");
    }

}
Console.ReadKey();