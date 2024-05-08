namespace Ukol_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Vypiš aktuální datum a čas, nemusíš řešit, v kterém je to časovém pásmu.
            DateTime aktualni = DateTime.Now;
            Console.WriteLine(aktualni);

            // 2. Vytvoř proměnnou typu DateTime a ulož do ní svoje datum narození. Potom vypiš, kolik dnů od té doby uteklo
            DateTime narozeni = new DateTime(1990, 4, 26);
            Console.WriteLine($"Od mého narození uplynulo {(aktualni - narozeni).Days} dnů");

            // 3. Vytvoř list stringů a vlož do něj 5 různých hodnot.

            List<string> list = new List<string>() { "jablko", "hruška", "kiwi", "hrozno", "třešeň" };

            // 4. Smaž z tohoto listu libovolnou hodnotu.
            list.Remove("jablko");

            // 5. Zjisti, jestli tento list obsahuje nějakou hodnotu pomocí list metody Contains
            string hledanaHodnota = "hrozno";
            bool obsahujeHledanouHodnotu = list.Contains(hledanaHodnota);
            if (obsahujeHledanouHodnotu)
            {
                Console.WriteLine($"Seznam obsahuje hodnotu {hledanaHodnota}");
            }
            else
            {
                Console.WriteLine($"Seznam neobsahuje hodnotu {hledanaHodnota}");
            }

            // 6. Vypiš do konzole, kolik je v tom listu prvků a připoj k tomu všechny ty hodnoty (např: "2: modra, zelena").
            Console.Write($"{list.Count}: ");
            for (int i = 0; i < list.Count; i++)
            {
                if (i < list.Count - 1)
                {
                    Console.Write($"{list[i]}, ");
                }
                else
                {
                    Console.Write($"{list[i]}.");
                    Console.WriteLine();
                }
            }          
            Console.WriteLine();

            // 7. Vytvoř slovník, kde klíčem bude položka nákupu (string) a hodnotou cenaKus té položky, a vlož nějaké hodnoty (např: <"chleba", 20>).
            Dictionary<string, int> nakup = new Dictionary<string, int>
            {
                { "chleba", 49},
                {"mléko", 29 },
                {"jogurt", 19 },
                {"máslo", 42 },
            };

            //// 8. Zjisti, jestli slovník obsahuje nějakou konkrétní potravinu a pokud ano, vypiš její cenu, pokud ne, vypiš, že není.
            //string potravina = "jogurt";
            //bool obsahujeHledanouPotravinu = nakup.TryGetValue(potravina, out int cenaKus);
            //int puvodniCena = cenaKus;


            //if (obsahujeHledanouPotravinu)
            //{
            //    Console.WriteLine($"Nákup obsahuje {potravina} a cenaKus je {cenaKus} Kč");
            //}
            //else
            //{
            //    Console.WriteLine($"Nákup neobsahuje {potravina}.");
            //}


            //// 9. Řekněme, že už jsi do slovníku přidala např. chleba a zjistila, že máš v nákupní tašce ještě jeden -> uprav hodnotu k tomu klíči tak, aby obsahovala hromadnou cenu za všechny stejné položky.
            //string potravina = "laskonka";
            //int pocetPridani = 1;

            //if (nakup.ContainsKey(potravina))
            //{
            //    for (int i = 1; i <= pocetPridani; i++)
            //    {
            //        nakup[potravina] = nakup[potravina] + puvodniCena;
            //        Console.WriteLine($"Nákup již obsahuje {i} položku s názvem {potravina}. Přidávám další. Celková cenaKus po přidání je {nakup[potravina]} Kč");
            //    }
            //}

            //Console.WriteLine(nakup[potravina]);


            // Pokus o spojení zadání 8 a 9
            string potravina = "chleba";
            bool obsahujePotravinu = nakup.TryGetValue(potravina, out int cenaKus);

            if (obsahujePotravinu)
            {
                Console.WriteLine($"Nákup obsahuje {potravina} a cena je {cenaKus} Kč");
                Console.WriteLine("Přejete si přidat další stejnou položku?");
                string pridatPolozku = Console.ReadLine();
                if (pridatPolozku == "ano")
                {
                    Console.WriteLine("V jakém počtu?");
                    int pocetPridanychKusu = int.Parse(Console.ReadLine());
                    int celkemKusu = pocetPridanychKusu + 1;
                    nakup[potravina] = celkemKusu * cenaKus;
                    Console.WriteLine($"Přidávám {pocetPridanychKusu} kusů potraviny {potravina}. V košíku je {celkemKusu} kusů.");
                    Console.WriteLine($"Celková cena po přidání je {nakup[potravina]} Kč");                    
                }
                else
                {
                    Console.WriteLine($"Zboží nepřidáno");
                }
            }
            else
            {
                Console.WriteLine($"Nákup neobsahuje {potravina}.");
            }
        }
    }
}

