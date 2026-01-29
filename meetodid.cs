namespace Meetoditöö
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1
            Tervitus();

            // 2
            double[] olulineMassiiv = { 6.7d, 6.9d, 4.20d };
            double arvudKokku = arvutaKokku(olulineMassiiv);
            Console.WriteLine($"arvudKokku={arvudKokku}");

            //3 
            Console.WriteLine("Mis on teie nimi?");
            int kasutajaNimiPikkus = tähtedeArv(Console.ReadLine());
            Console.WriteLine($"Teie nimi pikkus on {kasutajaNimiPikkus}");

            // 4
            Console.WriteLine("Kui kiiresti sa läks?");  // ma ei tea kuidas paremini õelda = (
            int kiirus = int.Parse(Console.ReadLine());
            string sõnum = sõnumiVäljaMõtleja(kiirus);
            Console.WriteLine(sõnum);
        }

        public static void Tervitus()
        {
            Console.WriteLine("Tere. Welkom.");
        }

        public static double arvutaKokku(double[] olulineMassiiv)
        {
            double summa = 0;
            foreach (double arv in olulineMassiiv)
            {
                if (summa == 0)
                {
                    summa = arv;
                    continue;
                }
                summa += arv;
            }
            return summa;
        }

        public static int tähtedeArv(string mingiString)
        {
            return mingiString.Length;
        }

        public static string sõnumiVäljaMõtleja(int kiirus)
        {
            switch (kiirus)
            {
                default:
                    return "Ei tunne seda vastust";
                case >= 20 and <= 40:
                    return "aeglane";
                case >= 40 and <= 60:
                    return "normaalne";
                case >= 60 and <= 1000:
                    return "ületasid kiirust";
            }
        }
    }
}
