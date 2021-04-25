using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RasporedCasova
{
    public class Predmet
    {
        public string Dan { get; set; }
        public string RedniBroj { get; set; }
        public string NazivPredmeta { get; set; }
        
        public Predmet(string line)
        {
            string[] podaci = line.Split('|');
            Dan = podaci[0];
            RedniBroj = podaci[1];
            NazivPredmeta = podaci[2];
        }
    }
}