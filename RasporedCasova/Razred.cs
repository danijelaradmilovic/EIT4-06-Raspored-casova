using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace RasporedCasova
{
    public class Razred
    {
        public List<string> SviRazredi = new List<string>();
        public List<string> SveSmene = new List<string>();
        public List<Predmet> PredmetiA = new List<Predmet>();
        public List<Predmet> PredmetiB = new List<Predmet>();

        public Razred()
        {
            this.PreuzmiSveRazrede();
        }

        public Razred(string razred)
        {
            this.PreuzmiSvePodatke(razred);
        }

        public void PreuzmiSveRazrede() 
        {
            DirectoryInfo info = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
            FileInfo[] files = info.GetFiles("*.txt");
            foreach (FileInfo f in files)
            {
                SviRazredi.Add(f.Name.Split('.')[0]);
            }
        }

        public void PreuzmiSvePodatke(string razred)
        {
            using (StreamReader sr = new StreamReader(HttpContext.Current.Server.MapPath("~/" + razred + ".txt")))
            {
                try
                {
                    int br = 0;
                    string line = sr.ReadLine();
                    while (!string.IsNullOrEmpty(line))
                    {
                        if (line.Split(':')[0] == "Smena")
                        {
                            br++;
                            SveSmene.Add(line.Split(':')[1]);
                           // line = sr.ReadLine();
                        }
                        else
                        {
                            if (br == 1)
                            {
                                PredmetiA.Add(new Predmet(line));
                            }
                            else 
                            {
                                PredmetiB.Add(new Predmet(line));
                            }
                        }

                        line = sr.ReadLine();
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
    }
}