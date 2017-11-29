using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Katalog: IZarzadzanie
    {
        private string dzialTematyczny;
        private List<Pozycja> list;
        public Katalog(string dzialTematyczny)
        {
            this.dzialTematyczny = dzialTematyczny;
        }
        public DodajPozycje(string tytul, int id, string wydawnictwo, int rokWydania, string imie, string nazwisko, string pochodzenie)
        {

        }
        public DodajPozycje(string tytul, int id, string wydawnictwo, int rokWydania, int numer)
        {

        }
    }
}
