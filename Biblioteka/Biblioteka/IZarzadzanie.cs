﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    interface IZarzadzanie
    {
        void WypiszWszystko();
        void WyszukajPoTytule(string tytul);
        void WyszukajPoId(int id);
    }
}
