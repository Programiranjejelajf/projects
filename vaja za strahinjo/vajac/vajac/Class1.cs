using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vajac
{
    class Harmonika
    {
        public string vrstaMeha;
        public string oglasitev;
        public int velikost;
        public int letnica;
        public double cena;

        public Harmonika()
        {

        }

        public Harmonika(string vrstica)
        {
            string[] podatki = vrstica.Split(";");

            this.vrstaMeha = podatki[0];
            this.oglasitev = podatki[1];
            this.velikost = Convert.ToInt32(podatki[2]);
            this.letnica = Convert.ToInt32(podatki[3]);
            this.cena = Convert.ToDouble(podatki[4]);
        }

        public override string ToString()
        {
            return this.vrstaMeha + ";" + this.oglasitev + ";" + this.velikost + ";" + this.letnica + ";" + this.cena;
        }
        public void Izpis()
        {
            Console.WriteLine("vrstaMeha: ".PadLeft(15, ' ') + this.vrstaMeha);
            Console.WriteLine("oglasitev: ".PadLeft(15, ' ') + this.oglasitev);
            Console.WriteLine("velikost: ".PadLeft(15, ' ') + this.velikost);
            Console.WriteLine("letnica: ".PadLeft(15, ' ') + this.letnica);
            Console.WriteLine("cena: ".PadLeft(15, ' ') + this.cena);
        }
        public void VnosPodatkov()
        {
            // vnos Meha
            do
            {
                Console.WriteLine("Vnesi novo vrsta meha Harmonike");
                Console.WriteLine("Mozne izbire mehov: 13palcni, 12palcni, 14palcni, 11palcni");
                this.vrstaMeha = Console.ReadLine();
                if (this.vrstaMeha != "13palcni" && this.vrstaMeha != "12palcni" && this.vrstaMeha != "14palcni" && this.vrstaMeha != "11palcni")
                {
                    Console.WriteLine("NAPACEN VNOS VNESI PRAVILEN MEH!");
                }
                else
                {
                    break;
                }

            } while (true);

            // Vnos oglasitve
            do
            {
                Console.WriteLine("Vnesi novo oglasitev: ");
                Console.WriteLine("Mozne izbire: CFB, BEA, HEA, CFH, ADG, DGC");
                this.oglasitev = Console.ReadLine();
                if (this.oglasitev != "CFB" && this.oglasitev != "BEA" && this.oglasitev != "HEA" && this.oglasitev != "CFH" && this.oglasitev != "ADG" && this.oglasitev != "DGC")
                {
                    Console.WriteLine("NAPACEN VNOS VNESI PRAVILNO OGLASITEV!");
                }
                else
                {
                    break;
                }
            } while (true);

            // Vnos velikosti 
            do
            {
                try
                {
                    Console.WriteLine("Vnesi velikost od 35 do 45: ");
                    this.velikost = Convert.ToInt32(Console.ReadLine());
                    if (this.velikost < 35 || this.velikost > 45)
                        Console.WriteLine("Vnesi med 35 in 45");
                    else
                        break;
                }
                catch
                {
                    Console.WriteLine("NAROBEN VNOS!");
                }
            } while (true);

            // vnos letnice
            do
            {
                try
                {
                    Console.WriteLine("Vnesi letnico med 1950 in 2021: ");
                    this.letnica = Convert.ToInt32(Console.ReadLine());
                    if (this.letnica < 1950 || this.letnica > 2021)
                    {
                        Console.WriteLine("Vnesti morate letnico od 1950 do 2021!");
                    }
                    else
                    {
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("NAROBEN VNOS!");
                }
            } while (true);

            // vnos cene
            do
            {
                try
                {
                    Console.WriteLine("Vnesi ceno: ");
                    this.cena = Convert.ToInt32(Console.ReadLine());
                    if (this.cena < 0.0 || this.cena > 30000.0)
                    {
                        Console.WriteLine("Cena je previsoka oz. ne obstaja");
                    }
                    else
                    {
                        break;
                    }

                }
                catch
                {
                    Console.WriteLine("NAROBEN VNOS!");
                }
            } while (true);

        }

        public void UrediVrstaMeha()
        {
            do
            {
                Console.WriteLine("Vnesi novo vrsta meha Harmonike");
                Console.WriteLine("Mozne izbire mehov: 13palcni, 12palcni, 14palcni, 11palcni");
                this.vrstaMeha = Console.ReadLine();
                if (this.vrstaMeha != "13palcni" && this.vrstaMeha != "12palcni" && this.vrstaMeha != "14palcni" && this.vrstaMeha != "11palcni") // ena izmed teh mora biti 
                {
                    Console.WriteLine("NAPACEN VNOS VNESI PRAVILEN MEH!");
                }
                else
                {
                    break;
                }

            } while (true);
        }
        public void UrediOglasitev()
        {
            do
            {
                Console.WriteLine("Vnesi novo oglasitev: ");
                Console.WriteLine("Mozne izbire: CFB, BEA, HEA, CFH, ADG, DGC");
                this.oglasitev = Console.ReadLine();
                if (this.oglasitev != "CFB" && this.oglasitev != "BEA" && this.oglasitev != "HEA" && this.oglasitev != "CFH" && this.oglasitev != "ADG" && this.oglasitev != "DGC")
                {
                    Console.WriteLine("NAPACEN VNOS VNESI PRAVILNO OGLASITEV!");
                }
                else
                {
                    break;
                }
            } while (true);
        }
        public void UrediVelikost()
        {
            do
            {
                try
                {
                    Console.WriteLine("Vnesi velikost od 35 do 45: ");
                    this.velikost = Convert.ToInt32(Console.ReadLine());
                    if (this.velikost < 35 || this.velikost > 45)
                        Console.WriteLine("Vnesi med 35 in 45");
                    else
                        break;
                }
                catch
                {
                    Console.WriteLine("NAROBEN VNOS!");
                }
            } while (true);
        }
        public void UrediLetnico()
        {
            do
            {
                try
                {
                    Console.WriteLine("Vnesi letnico med 1950 in 2021: ");
                    this.letnica = Convert.ToInt32(Console.ReadLine());
                    if (this.letnica < 1950 || this.letnica > 2021)
                    {
                        Console.WriteLine("Vnesti morate letnico od 1950 do 2021!");
                    }
                    else
                    {
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("NAROBEN VNOS!");
                }
            } while (true);
        }
        public void Urediceno()
        {
            do
            {
                try
                {
                    Console.WriteLine("Vnesi ceno: ");
                    this.cena = Convert.ToInt32(Console.ReadLine());
                    if (this.cena < 0.0 || this.cena > 30000.0)
                    {
                        Console.WriteLine("Cena je previsoka oz. ne obstaja");
                    }
                    else
                    {
                        break;
                    }

                }
                catch
                {
                    Console.WriteLine("NAROBEN VNOS!");
                }
            } while (true);
        }





    }
}
