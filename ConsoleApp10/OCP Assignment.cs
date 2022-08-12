using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTNSimPackages
{   //Abstract Class
    public abstract class SimTarrifPlans
    {
        
        public abstract double CalcTarrifUsed();
 
    }
    public class CustomerPackages
{
    public double TotalCalcTarrifUsed(List<SimTarrifPlans> Tarrif)
    {
        double total = 0;
        try
        {
            foreach (var tarrifPlan in Tarrif)
            {
                total += tarrifPlan.CalcTarrifUsed();

            }
        }
        catch (Exception peculiar)
        {
            var error = peculiar.Message;
            return 0;
        }
        return total;
    }

}
public class MTNPulse : SimTarrifPlans
{
        public double amountRecharged { get; set; }
        public double Callrate { get; set; }
        public int Dataplan { get; set; }
        public override double CalcTarrifUsed ()
        {
            return amountRecharged - Callrate ;
        }

    }

    public class Mpulse : SimTarrifPlans
    {
        public double amountRecharged { get; set; }
        public int Dataplan { get; set; }
        public double Callrate { get; set; }
        public override double CalcTarrifUsed()
        {
         
            return amountRecharged * 0.2 ;
        }

    }
    public class MTNBetaTalk : SimTarrifPlans
    {
        public double amountRecharged { get; set; }
        public double Callrate { get; set; }
        public double Dataplan { get; set; }
        public override double CalcTarrifUsed()
        {
            return amountRecharged * Callrate;
        }

    }
}


