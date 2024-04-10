using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2Lab4n2
{
    public class USD : Currency
    {
        private string Name;
       // private double Kilkist;
        public USD(double Cours, string Name, double Kilkist) : base(Cours, Kilkist)
        {
            
            this.Name = Name;
        }

        public string GetName()
        {
            return Name;
        }
        //public double GetKilkist()
        //{
        //    return Kilkist;
        //}
        public void SetName(string Name)
        {
            this.Name = Name;
        }
        //public void SetKilkist(double Kilkist)
        //{
        //    this.Kilkist = Kilkist;
        //}
    }
}
