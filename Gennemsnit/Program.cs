int[] tal_val = new int[100];
int antal_tal = 0;
App(tal_val);
Console.WriteLine($"Gennemsnit af indtastede tal: {Avg(tal_val, antal_tal)}");

Console.ReadLine();

void App(int [] arr)
{
    Console.WriteLine("Indtast tal:");
    while (true)
    {
        string temp = Console.ReadLine();
        if (temp == "#") { return; }
        arr[antal_tal] = Convert.ToInt32(temp);
        antal_tal++;
    }
}
static double Avg(int[] arr, int antal)
{
    double sum = 0;
    for (int i = 0; i < antal; i++)
    {
        sum += arr[i];
    }
    return sum / antal;
}