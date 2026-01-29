//  do while
string kasutajaNimi = "";
do
{
    Console.WriteLine("Palun sisesta oma kasutajanimi: ");
    kasutajaNimi = Console.ReadLine();
} while (kasutajaNimi != "user1");

// while
Console.WriteLine("Nüüd palun sisesta parooli, mis on vahemikus 1000 ja 9999");
int sisestatudParool = int.Parse(Console.ReadLine());
while (sisestatudParool < 1000 || sisestatudParool > 9999)
{
    Console.WriteLine("Vale parool, palun proovi uuesti");
    Console.WriteLine("Palun sisesta parooli:");
    sisestatudParool = int.Parse(Console.ReadLine());
}
Console.WriteLine("success!!!!!!!!!!");
// for
string[] puuviljad = {"õun", "banaan", "apelsiin", "ploom", "pirn"};

for (int i = 0; i < puuviljad.Length; i++)
{
    Console.WriteLine($"{i + 1}. Puuvilja on: {puuviljad[i]}");
}
// foreach
int[] olulineMassiiv = {2,2,2,2,2};
int summa = 0;
foreach (int arv in olulineMassiiv)
{
    if (summa == 0)
    {
        summa = arv;
        continue;
    }
    summa *= arv;
}
Console.WriteLine($"foreach summa={summa}");