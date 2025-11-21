using system.componentmodel.design;

namespace minu_konspekt
{
    internal class program
    {
        static void main(string[] args)
        {

            //console.writeline("hello, world!");

            //muutujad, matemaatilised tehted, if, else if ja else:

            //1. tuvasta sisu võrdluses tühja stringiga, string andmetüüp
            console.writeline("tere kasutaja, mis on sinu nimi");
            string nimi = console.readline();

            if (nimi == "")
            {
                console.writeline("kasutaja ei sisestanud oma nime");
            }
            else if (nimi != "")
            {
                console.writeline("tere " + nimi + "!");
            }
            else
            {
                console.writeline("kasutaja ei sisestanud oma nime");
            }

            //2. tuvasta arvutivahemik, võrdluses piirväärtustega, int/double/float andmetüüp
            console.writeline(nimi + ",mis on sinu vanus?: ");
            int kasutajavanus = int.parse(console.readline());

            // 2.1 mitu tingimust pesastatud if-ide abil
            //if (kasutajavanus > 0)
            //{   
            //         if (kasutajavanus < 18)
            //   {  
            //        console.writeline("kahjuks energiajooki sulle ii müüda, oled monsterist ilma");
            //   }
            //       else
            //   {
            //    console.writeline("saad osta monsterit, yippie");
            //   }

            //2.3 mitu vahemiku, if- elseif abil, double/float

            //2.2 mitu tingimust ühe ifi sees kasutades loogilist tehel "and", vältides pesastamist
            if (kasutajavanus > 0 && kasutajavanus < 18)
            {
              console.writeline("kahjuks energiajooki sulle ei müüda, oled monsterist ilma");
            }
            else
            {      console.writeline("saad osta monsterit, yippie");

            
            //2.3 mitu vahemiku, if- elseif abil, double/float
                console.writeline("sisesta oma pikkus ka, palun, " + nimi + ":");
            }
            double pikkus = double.parse(console.readline());
            if (pikkus < 1.00d)
            {
                console.writeline("oled juntsu");
            }
            else if (pikkus < 1.25d && pikkus > 1.00d)
            {
                console.writeline("oled peeagu allameerimees");
            }
            else if (pikkus < 1.50d && pikkus > 1.25d)
            {
                console.writeline("oioi, päkapikk enam ei olegi " + nimi + " !");
            }
            else if (pikkus < 1.75d && pikkus > 1.5d)
            {
                console.writeline("oled enamasti standardpikkuses, kui mitte just natuke lühike");
            }
            else if (pikkus < 2.00d && pikkus > 1.75d)
            {
                console.writeline("pikk kolge, vaata et sa pead vastu uksepilta ära ei löö");
            }
            else if(pikkus > 2.00d)
            {
                console.writeline("täetlik tulnukas, kuidas pilved välja näevad?");
            }
            else
            {
                console.writeline("pikkust ei tunta");

            }


            console.writeline("tere, sisesta liidetav arv");
            //adresserime moodulit "console", punkti abil ütleme, et kasutame funktsiooni writeline
            //selle jaoks et öelda kasutajale sõnum mis asub funktsiooni nime järel sulgude vahel
            //ümbritsetuna jutumärkidega, kasutajale esitatav sõnum on "tere. sisesta esimene arv.
            //jutumärkidega. lause lõppeb lauselõpumärgiga ";",

            int arv1 = int.parse(console.readline());
            //instantsieerime muutuja nimega "arv1", ning selle anname andmetüübiks "int", see
            //ütleb ära, et siin muutujas on täisarvud sees, omistame muutujale võrdusmärgi abil
            //väärtuse, mille saame kasutajalt. selle jaoks, adresserime uuesti "console" moodulit
            //aga seekord on funktsiooni nimi "readline". selleks, et käsureapealt tulev arv ptogrammile
            //tekstina ei näe välja, küsime in mooduli seest omakorda funktsiooni "parse" , ning paneme 
            //readline funktsiooni parse() sulgude vahele.
            //jutumärkidega. lause lõppeb lauselõpumärgiga ";",

            console.writeline("tere, sisesta liidetav arv");
            //adresserime moodulit "console", punkti abil ütleme, et kasutame funktsiooni writeline
            //selle jaoks et öelda kasutajale sõnum mis asub funktsiooni nime järel sulgude vahel
            //ümbritsetuna jutumärkidega, kasutajale esitatav sõnum on "tere. sisesta esimene arv".
            //jutumärkidega. lause lõppeb lauselõpumärgiga ";",

            int arv2 = int.parse(console.readline());
            //instantsieerime muutuja nimega "arv2", ning selle anname andmetüübiks "int", see
            //ütleb ära, et siin muutujas on täisarvud sees, omistame muutujale võrdusmärgi abil
            //väärtuse, mille saame kasutajalt. selle jaoks, adresserime uuesti "console" moodulit
            //aga seekord on funktsiooni nimi "readline". selleks, et käsureapealt tulev arv ptogrammile
            //tekstina ei näe välja, küsime in mooduli seest omakorda funktsiooni "parse" , ning paneme 
            //readline funktsiooni parse() sulgude vahele.
            //jutumärkidega. lause lõppeb lauselõpumärgiga ";",

            console.writeline("palun sisesta tehemärk: / * + - ^ ");
            //adresseerimine modulit "cinsole" koos "writeline" funktsiooniga, et esitada kasutajale
            //küsimuse "sisesta tehtemärk: / * + -". punkti abil saame moodulist console, funktsiooni
            //writeline, ning sulgude vahel ongi kasutajale esitatav tekst. tekst ise on ka ümbritsetud
            //jutumärkidega. lause lõppeb lauselõpumärgiga ";",
            
            string tehtetyyp = console.readline();
            // instantsieerime muutuja nimega "tehtetyyp", mille ette kirjutame andmetüübiks "string" .
            //omistame võrdusmärgi abil, sellesse muutujasse kasutajalt sisendi mille saame kasutade
            //"console" moodulis oleva readline () funktiooni abil. lause lõppeb


            int tulemus = 0;
            // instantsieerimi muutuja nimega "tulemus", andmetüübiga int, ning omistame talle algse
            //väärtuse võrdusmärgi abil, milleks on 0.lause lõppeb lauselõpumärgiga ";",


            if (tehtetyyp == "+")
                //teeme tingimuslause if. ning selle tingimuse määrame ära sulgudega, mille vahel on
                // võõrduskontroll. kontrollimekas muutuja "tehtetyyp" omab andmeid samal kujul
                //nagu võrdusmärkidest teisel pool olev tekst . siin lause ei lõppe, kuna tegu ei
                //ole koodiga mis midagi kindlast veel ära teeb.
            {
                tulemus = arv1 + arv2;
            }
            //peale tingimust on koodiplokk { sulgude vahel, mis sisaldab endas ühte koodirida.
            //selles lauses omistame muutujale "tulemus" võrdusmärgi abil liitmistehte tulemuse,
            //kus liidame kokku muutuja "arv1" ja muutuja "arv2" sisu. lause lõppeb lauselõpumärgiga ";".

            else if (tehtetyyp == "-")
                //temme sekundaarse tingimuslause "else if" , ning määrame tema tingimuse ära sulgudega.
                //sulgude vahel on võrdsuskontroll. kontrollime kas muutuja "tehtetyyp" omab andmeid
                //samal kujul nagu võrdusmärkidest teisel pool olev tekst "-" kui eelnev tingimus ei 
                //täitunud. lause siin ei lõppe, vaid tingimusele järgneb koodiplokk.

            {
                tulemus = arv1 - arv2;
            }
            // peale tingimust on koodiplokk { loogeliste sulgude vahel, mis sisaldab endas ühte
            //koodrida, selles lauses omistame muutujale "tulemus2 võrdusmärgi abil lahutustehte
            //tulemuse, kus lahutame muutuja "arv" sees olevast väärtusest maha "arv22 muutujas
            //oleva väärtuse. 

            
            else if (tehtetyyp == "*")
                // teeme sekundaarse tingimuslause "else if" , ning määrame tema tingimuse ära sulgudega.
                //sulgude vahel on võrduskontroll. kontrollime kas muutuja "tehtetyyp" omab andmeid
                //samal kujul nagu võrdusmärkiest teisel pool olev tekst "*" kei eelnev tingimus ei
                //täitunud. lause lõppu ";"
            {
                tulemus = arv1 * arv2;
            }
            //peale tingimust on koodiplokk { loogeliste sulgude vahel, mis sisaldab endas ühte
            //koodrida. selles lauses omistame muutujale "tulemus" võrdusmärgi abil korrutustehte
            //tulemuse, kus korritame muutujas "arv2" oleva mutujas "arv1" oleva väärtuse 
            //kordi. lause lõppeb lauselõpumärgiga ";".
            else if (tehtetyyp == "/")
                //teeme sekundaarse tingimuslause "else if"; ning määraseme tema tingimus ära sulgudega.
                //sulgude vahel on võrdsuskontroll. kontrollime kas muutuja "tehtetyyp" omab andmeid
                // samal kujul nage võrdusmärkidest teisel pool olev tekst "/" kui ellnev tingimus ei
                //täitunud. lause siin ei lõppe, vaid tingimusele järgneb koodiplokk.
            {
                tulemus = arv1 / arv2;
            }
            //peale tingimust on koodiplokk { loogeliste sulgude vahel, mis sisaldab endas ühte
            // koodirida. selles lauses omistame muutujale "tulemus" võrdusmärgi abil korrutustehte 
            //tulemus, kus jagame muutujas "arv1" oleva väärtuse, muutujas "arv2" oleva jagajaga
            //lause lõppeb ";"

            else if (tehtetyyp == "^")
                //teeme sekundaarse tingimuslause "ele if" , ning määrame tema tingimuse ära sulgudega.
                //sulgude vahel on võrdsuskontroll, kontrollime kas muutuja "tehtetyyp" omab andmeid
                //samal kujul nagu võrdusmärkidest teisel pool olev tekst "'" kui eelnev tingimus ei
                //täitunud. lause siin ei lõppe
            {
                tulemus = (int)math.pow(arv1, arv2);
            }
            //peale tingimust on koodiplokk { loogeliste silgide vahel, mis sisaldab endas ühte
            //koodirida. selles lauses omistatakse võrdusmärgi abil muutujasse "tulemus" mille saame 
            //"math" moodulist pärineva funktsiooni "pow()" abil. math.pow() võtab parameetritena
            //sisse muutjad "arv1" ja "arv2". esimene parameeter on astendatav, teine parameeter
            //on astendaja.
            else
            //peale kõiki järel tingimusi on meil tingimuslause osa "else" mida täidatakse kõikide
            //muude tingimuslause osade mittetäitumisel. siin eraldi tingimust välja ie kirjutada 
            //ning sellest tulenevalt ei ole ka sulge . järgnrb ainult koodiplokk
            {
                console.writeline("palun sisestada tehe, mida kalkulaator tuvastada oskab");
            }
            //pelse "else" on koodiplokk { loogeliste sulgude vahel , mis sisaldab endas ühte
            //koodirida. selles koodireas kasutame moodulist "console" punkti abil funktsiooni 
            //"writeline" et öelda kasutajale "palun sisesta tehe;mida kalkulaator tuvastada 
            //oskab" . koodirida lõppeb lauselõpumärgiga ";".

            console.writeline(tulemus);
            //kasutame moodulist "console" punkti abil funktsiooni "writeline" et kuvada kasutajale
            //tehte tulemus. selle jaoks on writeline funktsioonis parameetrina pandud muutuja
            //"tulemus" ilma tekstiks teisendamata. lause lõppeb ";"
















            if (tulemus != 0)
            {
                console.writeline(tulemus);
            }
            else
            {
                console.writeline("tulemus on 0, või üritasid teha tehet, mida kalkulaator ei tunne");
            }
            console.writeline("kas sa tahad õuna või banaani?");
            string vastus = console.readline();

            if (vastus == "õuna") ;
            {
                console.writeline("🍎🍎🍎");
            }
            //
            //iseseisev töö
            
            //#    - küsib kasutajalt kas ta tahab ära mõõta pappkasti või õlitünni.
            console.writeline("kas ta tahab ära mõõta pappkasti või õlitünni?"); 

            string sisend = console.readline();

            if (sisend == "õlutunni")
            
                console.writeline("kas sa teab põhja raadiust (r) või põhja läbimõõtu (d)?");   //string raadius ja diametr
                string rvõid = console.readline();
                console.writeline("mis on selle raadius/läbimõõt?meetrites");
                double kasutajamõõt = double.parse(console.readline());

                console.writeline("kas sa teab tunni kõrgust?");
                double kõrgus = double.parse(console.readline());

                console.writeline("kas sa teab kaane paksust?");
                double kaanepaksus = double.parse(console.readline());

                double sp = 0;
             if (rvõid == "r")
             {
                    sp = math.pi * (kasutajamõõt * kasutajamõõt);
             }
             else if (rvõid == "d") ;
             {
              kasutajamõõt = kasutajamõõt / 2;
              sp = math.pi * (kasutajamõõt * kasutajamõõt);
             }
             double v = 0;
             kõrgus = kõrgus - kaanepaksus;
             v = sp * kõrgus;
             kõrgus += kaanepaksus;
             double sk = 2 * math.pi * kasutajamõõt * kõrgus;
             double s = sp + sk;
             console.writeline("sinu tünn mahutab {v}/ tünni küljepindala on {sk}/ tünni kogupindala on {s}");




            //# kolija kalkulaator - kirjuta programm mis:
            //#    - küsib kasutajalt kas ta tahab ära mõõta pappkasti või õlitünni.
            //#    - olenevalt kasutaja sisestusest küsib ta:
            //#    - - tünni jaoks:
            //#    - - - kas kasutaja teab põhja raadiust (r) või põhja läbimõõtu (d):
            //#    - - - tünni kõrgust
            //#    - - - kaane paksust (kaane paksus võtab tünni kõrgusest maha, kuna kaan võtab tünni sisust natuke ruumi)
            //#    - - - arvutab tünni ruumala mahu, tünni küljepindala, tünni kogupindala
            //#    - - kasti jaoks:
            //#    - - - kas kast on kuubiku kujuline või risttahuka kujuline
            //#    - - - - kui on kuubik, siis küsib kasutajalt ainult küljepikkust
            //#    - - - - kui on risttahukas siis küsib kasutajalt:
            //#    - - - - - pikima külje pikkust, 
            //#    - - - - - lühima külje pikkust ja
            //#    - - - - - kasti kõrgust
            //#    - - arvutab vastavalt kasti kogupindala, mahu, ja pikima läbiva joone (d)



            console.writeline("hapukapsas");
            // "console" on moodel c# mida me adressime, console aitab teha tegevust käsureal
            //   .                  näitab, et meil on vaja adresserida mingisugust funktsiooni või metodit
            //                      mooduli "console" seest.
            // "writeline"          funktioon mida me parasjagu kasutame.
            // ()                -> sulupaar mis omab funktsiooni tööks vajalikku onfot.
            // []                -> tähistab massive
            // {                 -> koodiplokk, tavaliselt kas pärast (if, else if) tingimust, namespacei või funktsiooni kirjeldust,
            // "hapukapsas"      -> paremeeter mis antakse funktsioonile writeline töötlemiseks kaasa.
            //              -> taane aitab arendajal aru saada, kuskohas millise koodiploki sees 
            //                 asub, see on vajalik ka kompilaatorile samal eesmärgil
            //;             -> kõik koodilaused lõppevad komakooloniga, mis tähistavad lause kõppu
            // //            tähistab üherealist kommentaari
            // /**/          tähistab mitmerealist kommentaari või kommentaariregiooni 
            int muutuja = 3;
            // it             -> on muutuja nime ees olev andmetüübi kirjeldus mis näitab ära, millist
            //                   tüüpi andmed selle muutuja sees on.
            // "muutuja"      -> on nimetus, ehk muutuja, mis hoiab endas mingeid andmed, inimloetava 
            //                   sõnaga, ja mille abil saab neid adressida koodi sees.
            // =              -> üksik võrdusmärk omistab muutuja sisse vastava väärtuse mis asub 
            //                   teisel pool võrdusmärki.
            // 3              -> muutujale omistatav väärtus.

            //* võimalikud andmetüübid mida vaja võib minna: */
            int a = 1, // int on´täisarv
            decimal b = 2.1m; // decimal on kümnendsüsteemis olev komakohaga arv
            float c = 3.9f; //float on 32-bitine komakohaga arv
            float d = 5.6d; // double on 64-bitine komakohaga arv 
            char c1 = "a"; // üksainus täht või tähemark mis tähistatakse ülakimade vahel ''
            string s = "tekst"; // tätedest koosnev sõna või tekst, tähistatakse jutumärkidega ""
            var x = "abc"; // var on ebamäärase andmetüübiga kohalik muutuja
            var y = 123;   // ta võib omada endas teisi andmetüüpe
            const int z = 9; // konstant-tüüpi muutujaid ei saa muuta, nende sisu on read-only

            //põhilised matemaatilised tehted
            int liitmine = 1 + 1; // liitmine, kaks arvu liidetakse kokku
            int lahutamine = 1 - 1; // lahutamine, kus esimesest arvust lahutakse maha teine 
            double korrutamine = 1 * 2; // korrutamine, kus teine arv korrutakse esimese arvu kordi.
            double jagamine = 1 / 2; // jagamine. esimene arv jagatakse teise arvuga
            double astendamine = math.pow (2,2)  //astendamine, esimene arv astendatakse teisega
            double juurimene = math.sqrt(2); //ruutjuur, parameetrina juuritav arv

            //muutuja nimed
            int arv = 0; //sobib
            string sõne = 'abc'; //sobib
            string string = "abc"; //kaitstud sõna kasutada ei saa

            // muutuja nimeks ei sobi järgnevad sõnad:
            // abstract, as, base, bool, break, byte,
            //case, catch, char,checked, class, count,continue
            //decimal, default, delegate, do, double, else,
            //enum, event, explicit, extern, false, finally,
            //fixed, float, for
            //foreach, goto, if, implict, in, int, interface,
            //internal, is, lock, long, namespace, new, null, object,
            //operator, out, override, params, private, protected,
            //public, readonly, ref, return, sbyte, sealed,
            //short, sizeof, stackalloc, static,
            //static, string,struct, switch, this, this, throw,
            //try, type of, uint, ulong, unchecked, unsafe,
            //ushort, using, virtual, void, volatile, while.

            //string kasutajanimi = "";
            //do
            //{
            //    console.writeline("palun sisesta oma kasutajanimi: ");
            //    kasutajanimi = console.readline();
            //} while (kasutajanimi != "user1");
            //console.writeline("pass");
            //if (kasutajanimi == "user1")
            //{
            //    int ruudusuurus = 0;

            //    do
            //    {
            //        console.writeline("kui suurt ruutu saada tahad?");
            //        ruudusuurus = int.parse(console.readline());
            //    } while (ruudusuurus < 0 || ruudusuurus > 20);

            //    char reakujund = 'ϛ';
            //    string üksrida = "";
            //    int tsüklimuutuja = ruudusuurus;

            //    do
            //    {
            //        üksrida = üksrida + "_" + reakujund;
            //        tsüklimuutuja = tsüklimuutuja - 1;
            //    } while (tsüklimuutuja != 0);

            //    tsüklimuutuja = ruudusuurus;

            //    do
            //    {
            //        console.writeline(üksrida);
            //        tsüklimuutuja -= 1;
            //    } while (tsüklimuutuja != 0);

            //    console.writeline($"palun, siin on sinu ruut, suurusega {ruudusuurus}x{ruudusuurus}");

            //}

            Console.WriteLine("Sisesta ostusumma");
            double ostusma = double.Parse(Console).ReadLine());
            if (ostusumma > 100)
            {
                Console.WriteLine("Saad 20% allahindlust");
            }
            else if (ostusumma < 101 && ostusumma > 50) ;
            {
                Console.WriteLine("Saad 10% allahindlust. c: yay");
            }
            else if (ostusumma < 51 && ostusumma > 20)
            {
                Console.WriteLine("5% allahindlust.");
            }
            else if (ostusumma < 21 && ostusumma > 0) ;
            {
                Console.WriteLine("allahindlust ei saa");
            }
            else
            {
                Console.WriteLine("sisestatud on vigane arv");
            }



            /* tingimuslause osad */
            if (true) { } //kaitstud sõna if kutsub esile tingimuslaus, mille tingimus on sulgude vahel, ning millele järgneb
                          //koodiplokk tingimuse täitumisel teostetava koodiga
            else if (true) { } //kaitsted sõnad "else" ja "if" (else if) kutsuvad esile sekundaarse tingimuslause, mille tingimus
                               // ja eelneva tingimuse mittetäitmisel, tostatakse koodiplokki sees oev kood
            else { } // kaitstud sõna else kutsub esile järeltingimuse, millele peab eelnema kas "if" või "else if" , ning mille koodiplokki sisu 
                    // täidetakse kõikide teiste "if" ja "else if" tingimuste läbikukkumisel.

            /*   loogilised tehted */

            // && -> "and" loogiline tehe, mida kasutatakse  tingimuste kirjeldamisel, ning mis annab positiivse vastuse (true) juhul kui
            //       mõlemal poll "&&" märki olevad tingimused ontäidetud, Kui üks neist ei ole, siis annab negatiivse vastuse (false).
            // || "or"! loogiline tege, mida kasutatakse tingimuste kirjeldamisel, ning mis annab positiivse vastuse (true) siis kui
            //    vähemalt üks tingimus on täietud. Negatiivne vastus (false) tagastatakse siis, kui kõik tingimused on täitmata.
            //  !    -> "not" loogiline tehe, mida kasutatakse tingimuse tulemuse inverteerimiseks, Tulemus, mis muidu tagastaks (true),
            //          hüümärgi abil tagastab (false), ja vastupidi . tulemus mis muidu tagastaks (false9, hüümärgi abil tagastab (true)

            /* võrlusoperaatorid */

            // =  -> "on võrdne". Võrdusmärkide ührl pool olev objekt peab vastama täpselt oma olemuselt võrdusmärkide teise pool oleva
            //        objektiga, ei ole sama nagu üks võrdusmärk omistab, kaks võrdleb.
            // != -> "ei ole võrdne". Võrdusmärgi ühel pool olev objekt *EI TOHI* olla samal kujul nagu võrdusmärgi teisel pool olev objekt.
            //       Ta võib olla ükskõik mis muul kujul, aga mitte võrreldava objektiga samal kujul. Võrdusoperaator on komninatsioon
            //       "on võrdne operaatorist, ja loogiliselt tehtest "not"
            // > ->  "on suurem kui". Märgist vasakul pool olev objekt peaks olema suurem, kui paremal pool olev objekt.
            // < ->  "on väiksem kui". Märgist vasakul pool olev objekt 
            // >= ->  "suuremvördne".Märgist vasakul pool olev objekt peaks olema vähemalt vördne vöi suurem kui parempoolne objekt.
            // Vordlusoperaator on kombinatsioon "on võrdne" ja "on suurem kui" operatoritest.
            //<= -> "väiksemvõrdne".Märgist vasakul pool olev objekt peaks olena vähemalt vördne vöi väiksem kui parempoolne objekt.
            // Vordlusoperaator on kombinatsioon "on vördne" ja "on väiksem kui" operaatoritest.

            /* omistusoperaatorid ja kiirtehed */
            
            int thing = 1;// =  -> üksik võrdusmärk muutuja sisse väärtuse, mida kasutada läbi muutuja nime.
            thing += 1;   // += -> võrdusmärk mille ees on pluss, automaatselt liidab muutujale otsa võrdusmärgi teisel pool oleva arvu.
                          //       asendeb tehet "thing = thing ? 1". on kombinatsioon matemaatilisest tehtest "+" ja omistamisest "=".

            thing -= 1;   // -= -> võrdusmärk mille ees in miinus, automaatselt lahutab muutujast maha võrdusmärgi teisel pool oleva arvu.
                          //       asendab tehet "thing = thing - 1", on kombinatsioon matemaatilisest tehtest "-" ja omistamisest 2-".
                          //thing *= 2;   //  *= → vördusnårk mille ees on korrutusmårk ***, autonaatselt korrutab muutuja-sisu, vördusnärgi teisel pool
                          //oleva arvu kordi.asendab tehet "thing = thing * 2".on kombinatsioon natemaatilisest tehtest "" ja
                          //onistanisest "="，
                          //thing / = 2;
                          // 7 = ->vordusmark mille ees on Jagamismark/, autonaa selt jagab muutuja sisu võrdusmärgi teisel pool oleva
                          //       arvu osadeks. asendab tehet "thing = thing / 2". on kombinatsioon matematilisest tehtest "/" ja
                          //       omistamisest "="
            thing++;      // ++ -> on spetsifiliselt ühe juurde liitmiseks kiirtehe
            thing--;      // -- -> on spetsiifiliselt ühe maha lahutamiseks kiiirtehe.

            /* Tsüklid */
            // 1. do-while
            do // "do" on kaitstud sõna, mis alustab do-while tsüklit. Pärast seda on koodiplokk { ning ütleb et tee seda koodi
            {

            } while (true); //niikaua kuni while järel olevate sulgude vahel tingimus et täitu, käivitatakse ellnev kood uuesti.






























        }
    }
}








