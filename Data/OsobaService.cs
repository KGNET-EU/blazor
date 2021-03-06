using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Startowa.Data
{
    public class OsobaService
    {
        private static List<Osoba> OsobyNaLiscie = new List<Osoba>();

        public OsobaService()
        {
            OsobyNaLiscie.Add(new Osoba() { Imie = "Adam", Nazwisko = "Duapa", Wiek = 5, CzyPoprawnie = true });
            OsobyNaLiscie.Add(new Osoba() { Imie = "Stefan", Nazwisko = "Duapa", Wiek = 5, CzyPoprawnie = true });
            OsobyNaLiscie.Add(new Osoba() { Imie = "Czesiek", Nazwisko = "Duapa", Wiek = 5, CzyPoprawnie = true });
        }
        public static Task<List<Osoba>> GetListaLudzi() => Task.FromResult(OsobyNaLiscie);
    }
}
