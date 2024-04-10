using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2Lab4n2
{
    public class CurrencyExchanger
    {
        //public double Cours;
        //public string Currency;
        //public double Evrything;
        //public double Kilkist;

        public void Exchange(Currency valuta1, Currency valuta2, double x)
        {

            double grn = x * valuta1.GetCours();
            double itog = grn / valuta2.GetCours();
            if(itog > valuta2.GetKilkist())
            {
                throw new Exception("в нас нема стіки грошей");
            }
            Console.WriteLine(itog);
            valuta1.SetKilkist(valuta1.GetKilkist() + x);
            valuta2.SetKilkist(valuta2.GetKilkist() - itog);
        }



        //public void Exchange(double Cours1, double Cours2, double x )
        //{
        //    double ser = x * Cours1;
        //    double itog = ser / Cours2;
        //    Console.WriteLine(itog);
        //}

        public void Write (Dictionary<string, Currency> Dictionary)
        {
            var SortedDictionary = Dictionary.OrderBy(x => x.Value.GetCours())
                                           .ToDictionary(x => x.Key, x => x.Value.GetCours());

            foreach (var kvp in SortedDictionary)
            {
                Console.WriteLine($"Валюта:{kvp.Key}, Курс:{kvp.Value}" );
            }
        }

        
    }
    
}
