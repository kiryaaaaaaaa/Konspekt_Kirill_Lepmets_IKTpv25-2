using System.ComponentModel.Design;

namespace Minu_konspekt
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Hello, World!");

            //muutujad, Matemaatilised tehted, IF, ELSE IF ja ELSE:

            //1. tuvasta sisu võrdluses tühja stringiga, string andmetüüp
            Console.WriteLine("Tere kasutaja, mis on sinu nimi");
            string nimi = Console.ReadLine();

            if (nimi == "")
            {
                Console.WriteLine("Kasutaja ei sisestanud oma nime");
            }
            else if (nimi != "")
            {
                Console.WriteLine("Tere " + nimi + "!");
            }
            else
            {
                Console.WriteLine("Kasutaja ei sisestanud oma nime");
            }

            //2. tuvasta arvutivahemik, võrdluses piirväärtustega, int/double/float andmetüüp
            Console.WriteLine(nimi + ",mis on sinu vanus?: ");
            int kasutajavanus = int.Parse(Console.ReadLine());

            // 2.1 mitu tingimust pesastatud if-ide abil
            //if (kasutajavanus > 0)
            //{   
            //         if (kasutajavanus < 18)
            //   {  
            //        Console.WriteLine("Kahjuks energiajooki sulle ii müüda, oled monsterist ilma");
            //   }
            //       else
            //   {
            //    Console.WriteLine("Saad osta Monsterit, YIPPIE");
            //   }

            //2.3 mitu vahemiku, if- elseif abil, double/float

            //2.2 mitu tingimust ühe ifi sees kasutades loogilist tehel "and", vältides pesastamist
            if (kasutajavanus > 0 && kasutajavanus < 18)
            {
              Console.WriteLine("Kahjuks energiajooki sulle ei müüda, oled monsterist ilma");
            }
            else
            {      Console.WriteLine("Saad osta Monsterit, YIPPIE");

            
            //2.3 mitu vahemiku, if- elseif abil, double/float
                Console.WriteLine("sisesta oma pikkus ka, palun, " + nimi + ":");
            }
            double pikkus = double.Parse(Console.ReadLine());
            if (pikkus < 1.00d)
            {
                Console.WriteLine("Oled juntsu");
            }
            else if (pikkus < 1.25d && pikkus > 1.00d)
            {
                Console.WriteLine("oled peeagu allameerimees");
            }
            else if (pikkus < 1.50d && pikkus > 1.25d)
            {
                Console.WriteLine("oioi, päkapikk enam ei olegi " + nimi + " !");
            }
            else if (pikkus < 1.75d && pikkus > 1.5d)
            {
                Console.WriteLine("Oled enamasti standardpikkuses, kui mitte just natuke lühike");
            }
            else if (pikkus < 2.00d && pikkus > 1.75d)
            {
                Console.WriteLine("Pikk kolge, vaata et sa pead vastu uksepilta ära ei löö");
            }
            else if(pikkus > 2.00d)
            {
                Console.WriteLine("täetlik tulnukas, kuidas pilved välja näevad?");
            }
            else
            {
                Console.WriteLine("pikkust ei tunta");
            }


            Console.WriteLine("tere, sisesta liidetav arv");
            int arv1 = int.Parse(Console.ReadLine());
            Console.WriteLine("tere, sisesta liidetav arv");
            int arv2 = int.Parse(Console.ReadLine());
            Console.WriteLine("palun sisesta tehemärk: / * + - ^ ");
            string tehtetyyp = Console.ReadLine();

            int tulemus = 0;

            if (tehtetyyp == "+")
            {
                tulemus = arv1 + arv2;
            }

            else if (tehtetyyp == "-")

            {
                tulemus = arv1 - arv2;
            }

            else if (tehtetyyp == "*")
            {
                tulemus = arv1 * arv2;
            }

            else if (tehtetyyp == "/")
            {
                tulemus = arv1 / arv2;
            }

            else if (tehtetyyp == "^")
            {
                tulemus = (int)Math.Pow(arv1, arv2);
            }
            else
            {
                Console.WriteLine("Palun sisestada tehe, mida kalkulaator tuvastada oskab");
            }
            if (tulemus != 0)
            {
                Console.WriteLine(tulemus);
            }
            else
            {
                Console.WriteLine("Tulemus on 0, või üritasid teha tehet, mida kalkulaator ei tunne");
            }
            Console.WriteLine("Kas sa tahad õuna või banaani?");
            string vastus = Console.ReadLine();

            if (vastus == "õuna") ;
            {
                Console.WriteLine("🍎🍎🍎");
            }

            //4 parool, if ja string andmetüüp
            Console.WriteLine("Programmi edasiseks tööks sisesta palun parool:");
            string password = Console.ReadLine();
            
            if (password == "simsalabin")
            {
                Console.WriteLine("Parool on õige, aarete laegas avaneb");
            }
            else if (password == "saatana" || password == "1234" )
            {
                Console.WriteLine("parool on soobimatu, palun mingi muu");
            }
            else
            {
                Console.WriteLine("Parool on vale, proovi uuesti");
            }

            //5 värvituvastus
            Console.WriteLine("Milline värv sulle kõige rohkem meeldib?:");
            string favouriteColour = Console.ReadLine();
            if(favouriteColour == "punane")
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            if(favouriteColour == "oranz")
            {
                Console.WriteLine("Kahjuks oranzi ei ole");
            }
            if (favouriteColour == "kollane") ;
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
            }
            if (favouriteColour == "roheline");
            {
                Console.BackgroundColor = ConsoleColor.Green;
            }


        }
    }
}

