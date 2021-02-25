using System;
using System.Collections.Generic;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<string> lista = new List<string>();
            List<int> l = new List<int>();
            l.Add(1);
            l.Add(3);
            l.Add(5);
            l.Add(123);
            List<float> l2 = new List<float>();
            l2.Add(55.324F);
            l2.Add(3.6224F);
            l2.Add(5.12345F);
            l2.Add(123.116F);
            

            Osoba o1 = new Osoba("Adam", "Nowak");
            Osoba o2 = new Osoba("Krystyna", "Nowak");
            Osoba o3 = new Osoba("Ewa", "Piątek");

            List<Osoba> listaOsob = new List<Osoba>();
            listaOsob.Add(o1);
            listaOsob.Add(o2);
            listaOsob.Add(o3);

            lista = ZamianaList(l, lista);
            wyswietl(lista, "inty");
            lista.Clear();

            lista = ZamianaList(l2, lista);
            wyswietl(lista, "floaty");
            lista.Clear();
            lista = ZamianaList(listaOsob, lista);
            wyswietl(lista, "Osoby");
            lista.Clear();
        }

        static List<string> ZamianaList<T>(IEnumerable<T> unknownLista, List<string> lista)
        {

            IEnumerator<T> iterator = unknownLista.GetEnumerator();
            while (iterator.MoveNext())
            {
                T element = iterator.Current;
                lista.Add(element.ToString());
            }

            return lista;
        }

        static void wyswietl(List<string> wyswietlanaLista, string message)
        {
            Console.WriteLine($"Wyswietlam liste z: {message}");
            foreach (string s in wyswietlanaLista)
            {
                Console.WriteLine(s);
            }
        }
    }

    class Osoba{
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public Osoba(string imie, string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
        }
        public override string ToString()
        {
            return Imie + " "  + Nazwisko;
        }
    }

}
