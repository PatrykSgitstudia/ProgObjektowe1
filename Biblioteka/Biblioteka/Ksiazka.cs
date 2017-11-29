using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Ksiazka: Pozycja
    {
        private int liczbaStron;
        private Autor Autor;
        public Ksiazka()
        { }
        public Ksiazka(string tytul, int id, string wydawnictwo, int rokWydania, int liczbaStron, string imie, string nazwisko, string narodowosc)
        {
            this.tytul = tytul;
            this.id = id;
            this.wydawnictwo = wydawnictwo;
            this.rokWydania = rokWydania;
            this.liczbaStron = liczbaStron;
            this.Autor = new Autor(imie, nazwisko, narodowosc);
        }
        public override void WypiszInfo()
        {

            Console.WriteLine("tytul: " + this.tytul);
            Console.WriteLine("id: " + this.id);
            Console.WriteLine("wydawnictwo: " + this.wydawnictwo);
            Console.WriteLine("rok wydania: " + this.rokWydania);
            Console.WriteLine("liczba stron: " + this.liczbaStron);
            string[] tmp = this.Autor.PobierzAutora().Split(' ');
            Console.WriteLine("imie autora: " + tmp[0]);
            Console.WriteLine("nazwisko autora: " + tmp[1]);
            Console.WriteLine("narodowosc autora: " + tmp[2]);
        }
    }
}
