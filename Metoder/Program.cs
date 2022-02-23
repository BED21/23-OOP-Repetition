InfoText();
int summa = Addera(2, 3);
Console.WriteLine("Summa: {0}", summa);



static void InfoText()
{
    Console.WriteLine("En text...");
}

static int Addera(int v1, int v2)
{
    int summa = v1 + v2;
    return summa;
}