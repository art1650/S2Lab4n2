using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2Lab4n2
{
    public class Currency
    {

        private double Cours;
        //private string Name;
        private double Kilkist;

        public Currency(double Cours, double Kilkist)
        {
            this.Cours = Cours;
            this.Kilkist = Kilkist;
           
        }
        public double GetCours()
        {
            return Cours;
        }
        public double GetKilkist()
        {
            return Kilkist;
        }
        public void SetKilkist(double Kilkist)
        {
            this.Kilkist = Kilkist;
        }
        //public void SetName(string Name)
        //{
        //    this.Name = Name;
        //}
        //public double GetCours()
        //{
        //    return Cours;
        //}
        //public double GetKilkist()
        //{
        //    return Kilkist;
        //}

        public void SetCours(double Cours)
        {
            this.Cours = Cours;
        }

        //public void SetKilkist(double Kilkist)
        //{
        //    this.Kilkist = Kilkist;
        //}

        //public void Write()
        //{
        //    Console.WriteLine($"один {Name} дорівнює {Cours} українська гивня");
        //}
    }
}
