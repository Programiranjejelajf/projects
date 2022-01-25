using System;
using System.IO;

namespace vajac
{
    class Program
    {
        static void Main(string[] args)
        {


            int spr1, spr2, ind;
            string izbira;

            // string file = "TextFile1.txt";

            string trenutniD = Directory.GetCurrentDirectory();

           string[] vrstice = File.ReadAllLines(trenutniD + "\\TextFile1.txt");

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Konzolna aplikacija z menijem in delo z objekti");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Dodajanje, brisanje, izpis, shranjevanje, vnos");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Web developer");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();

            Harmonika[] HarmonikaTabela = new Harmonika[vrstice.Length];

            for (int i = 0; i < vrstice.Length; i++)
            {
                HarmonikaTabela[i] = new Harmonika(vrstice[i]);
            }

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1 - izpis");
                Console.WriteLine("2 - urejanje");
                Console.WriteLine("3 - dodajanje");
                Console.WriteLine("4 - brisanje");
                Console.WriteLine("5 - vizitka");
                Console.WriteLine("6 - poizvedba");
                Console.WriteLine("X - shrani in zapri");

                izbira = Console.ReadLine();

                if (izbira == "1")
                {
                    foreach (Harmonika i in HarmonikaTabela)
                    {
                        i.Izpis();
                        Console.WriteLine("\n--------------------------------------------------\n");
                    }
                }
                else if (izbira == "2")
                {
                    Console.WriteLine("Vnesite polje Harmonike, katerega bi radi spremenili, ce nocete spremeniti nic pritisnite " + HarmonikaTabela.Length);
                    for (int i = 0; i < HarmonikaTabela.Length; i++)
                    {
                        Console.WriteLine("Polje {0}:", i);
                        HarmonikaTabela[i].Izpis();
                        Console.WriteLine("\n--------------------------------------------------\n");
                    }
                    Console.Write("Polje: ");
                    // Preverjanje vnosa
                    do
                    {
                        try
                        {
                            spr1 = Convert.ToInt32(Console.ReadLine());
                            if (spr1 > HarmonikaTabela.Length || spr1 < 0)
                                Console.WriteLine("Polje ne obstaja!");
                            else if (spr1 == HarmonikaTabela.Length)
                                break;
                            else
                            {

                                HarmonikaTabela[spr1].Izpis();
                                Console.WriteLine("Kaj hocete spemeniti: ");
                                Console.WriteLine("Vnesite stevilo 1 za spremenitev vrsto meha");
                                Console.WriteLine("Vnesite stevilo 2 za spremenitev oglasitve");
                                Console.WriteLine("Vnesite stevilo 3 za spremenitev velikosti");
                                Console.WriteLine("Vnesite stevilo 4 za spremenitev letnice");
                                Console.WriteLine("Vnesite stevilo 5 za spremenitev cene");
                                do
                                {
                                    try
                                    {
                                        spr2 = Convert.ToInt32(Console.ReadLine());
                                        if (spr2 < 1 || spr2 > 5)
                                            Console.WriteLine("VNESI MED 1 IN 5!!!");
                                        else
                                            break;
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Napacen vnos!");
                                    }
                                } while (true);
                                switch (spr2)
                                {
                                    case 1:
                                        HarmonikaTabela[spr1].UrediVrstaMeha();
                                        break;
                                    case 2:
                                        HarmonikaTabela[spr1].UrediOglasitev();
                                        break;
                                    case 3:
                                        HarmonikaTabela[spr1].UrediVelikost();
                                        break;
                                    case 4:
                                        HarmonikaTabela[spr1].UrediLetnico();
                                        break;
                                    case 5:
                                        HarmonikaTabela[spr1].Urediceno();
                                        break;
                                }
                                break;
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Napacen vnos!");
                        }
                    } while (true);

                }
                else if (izbira == "3")
                {
                    Console.Clear();
                    Harmonika nov = new Harmonika();
                    nov.VnosPodatkov();
                    Array.Resize(ref HarmonikaTabela, HarmonikaTabela.Length + 1);
                    HarmonikaTabela[HarmonikaTabela.Length - 1] = nov;
                }
                else if (izbira == "4")
                {
                    Console.Clear();
                    Console.WriteLine("Vnesite polje Harmonike, ki ga zelite izbrisati, ce nocete spremeniti nic pritisnite " + HarmonikaTabela.Length);
                    for (int i = 0; i < HarmonikaTabela.Length; i++)
                    {
                        Console.WriteLine("Polje {0}:", i);
                        HarmonikaTabela[i].Izpis();
                        Console.WriteLine("\n--------------------------------------------------\n");
                    }
                    Console.Write("Polje: ");

                    do
                    {
                        try
                        {
                            ind = Convert.ToInt32(Console.ReadLine());
                            if (ind > HarmonikaTabela.Length || ind < 0)
                                Console.WriteLine("Polje ne obstaja!");
                            else if (ind == HarmonikaTabela.Length)
                                break;
                            else
                            {
                                for (int i = ind + 1; i < HarmonikaTabela.Length; i++)
                                    HarmonikaTabela[i - 1] = HarmonikaTabela[i];

                                Array.Resize(ref HarmonikaTabela, HarmonikaTabela.Length - 1);
                                break;
                            }

                        }
                        catch { Console.WriteLine("Napacen vnos!"); }
                    } while (true);

                }
                else if (izbira == "5")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Konzolna aplikacija z menijem in delo z objekti");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Dodajanje, brisanje, izpis, shranjevanje, vnos");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Web Developer");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                }
                else if (izbira == "6")
                {
                    double povprecje = 0.0;
                    int stevec = 0;
                    for (int i = 0; i < HarmonikaTabela.Length; i++)
                    {
                        povprecje += HarmonikaTabela[i].cena;
                        stevec++;
                    }
                    povprecje /= stevec;
                    Console.WriteLine("Povprecje vseh cen je: " + povprecje);
                }
                else if (izbira == "X" || izbira == "x")
                {
                    string[] vrsticeZaShranjevanje = new string[HarmonikaTabela.Length];
                    for (int i = 0; i < HarmonikaTabela.Length; i++)
                        vrsticeZaShranjevanje[i] = HarmonikaTabela[i].ToString();

                    File.WriteAllLines(trenutniD + "TextFile1.txt", vrsticeZaShranjevanje);
                    break;
                }
                else
                {
                    Console.WriteLine("Neveljavna izbira.");
                }
                Console.WriteLine("Pritisni karkoli za nadaljevanje.");
                Console.ReadKey();


            }
        }
    }
}
