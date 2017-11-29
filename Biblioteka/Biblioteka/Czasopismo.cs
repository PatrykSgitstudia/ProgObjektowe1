using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Czasopismo: Pozycja
    {
        private int numer;
        public Czasopismo()
        { }
        public Czasopismo(string tytul, int id, string wydawnictwo, int rokWydania, int numer)
        {
            this.tytul = tytul;
            this.id = id;
            this.wydawnictwo = wydawnictwo;
            this.rokWydania = rokWydania;
            this.numer = numer;
        }
        public override void WypiszInfo()
        {
            Console.WriteLine("tytul: " + this.tytul);
            Console.WriteLine("id: " + this.id);
            Console.WriteLine("wydawnictwo: " + this.wydawnictwo);
            Console.WriteLine("rok wydania: " + this.rokWydania);
            Console.WriteLine("numer: " + this.numer);
        }
    }
}
