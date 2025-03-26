using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filmekCLI
{
    internal class Filmek
    {
        string cim;
        int bemutatasEve;
        string mufaj;
        string forgalmazo;
        int hossz;

        public string Cim { get => cim; set => cim = value; }
        public int BemutatasEve { get => bemutatasEve; set => bemutatasEve = value; }
        public string Mufaj { get => mufaj; set => mufaj = value; }
        public string Forgalmazo { get => forgalmazo; set => forgalmazo = value; }
        public int Hossz { get => hossz; set => hossz = value; }

        public Filmek(string sor)
        {
            string[] strings = sor.Split(';');
            cim = strings[0];
            bemutatasEve = int.Parse(strings[1]);
            mufaj = strings[2];
            forgalmazo = strings[3];
            hossz = int.Parse(strings[4]);
        }
    }
}
