using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Pozycja
    {
        protected string tytul;
        protected int id;
        protected string wydawnictwo;
        protected int rokWydania;
        public Pozycja()
        { }
        public Pozycja(string tytul, int id, string wydawnictwo, int rokWydania)
        {
            this.tytul = tytul;
            this.id = id;
            this.wydawnictwo = wydawnictwo;
            this.rokWydania = rokWydania;
        }
        public virtual void WypiszInfo()
        {
            Console.WriteLine("tytul: " + this.tytul);
            Console.WriteLine("id: " + this.id);
            Console.WriteLine("wydawnictwo: " + this.wydawnictwo);
            Console.WriteLine("rok wydania: " + this.rokWydania);
        }
        public string PobierzTytul()
        {
            return this.tytul;
        }
        public int PobierzId()
        {
            return this.id;
        }
    }
}
