namespace MTNSimPackages
{
    public class Program
    {
        static void Main(string[] args)
        {
            var customerPkgs = new List<SimTarrifPlans>();
            //customerPkgs TotalCalcTarrifUsed(List<MTNPulse> Tarrif);

            customerPkgs.Add(new MTNPulse() { amountRecharged = 200, Callrate = 0.25 });
            customerPkgs.Add(new MTNPulse() { amountRecharged = 500, Callrate = 0.25 });
            customerPkgs.Add(new MTNPulse() { amountRecharged = 1000, Callrate = 0.25 });
            customerPkgs.Add(new MTNPulse() { amountRecharged = 2000, Callrate = 0.25 });
            customerPkgs.Add(new MTNPulse() { amountRecharged = 5000, Callrate = 0.25 });

            var customerPkgsMpulse = new List<SimTarrifPlans>();

            customerPkgsMpulse.Add(new Mpulse() { amountRecharged = 200, Callrate = 0.3 });
            customerPkgsMpulse.Add(new Mpulse() { amountRecharged = 500, Callrate = 0.4 });
            customerPkgsMpulse.Add(new Mpulse() { amountRecharged = 1000, Callrate = 0.6 });
            customerPkgsMpulse.Add(new Mpulse() { amountRecharged = 2000, Callrate = 0.7 });
            customerPkgsMpulse.Add(new Mpulse() { amountRecharged = 5000, Callrate = 0.8 });

            var customerPkgsBT=new List<SimTarrifPlans>();
                        
            customerPkgsBT.Add(new MTNBetaTalk() { amountRecharged = 200, Callrate = 0.1d});
            customerPkgsBT.Add(new MTNBetaTalk() { amountRecharged = 500, Callrate = 0.1d});
            customerPkgsBT.Add(new MTNBetaTalk() { amountRecharged = 1000, Callrate = 0.1d });
            customerPkgsBT.Add(new MTNBetaTalk() { amountRecharged = 2000, Callrate = 0.1d });
            customerPkgsBT.Add(new MTNBetaTalk() { amountRecharged = 5000, Callrate = 0.1d });

            CustomerPackages customerPackages=new CustomerPackages();
            Console.WriteLine(customerPackages.TotalCalcTarrifUsed(customerPkgsMpulse));
            Console.WriteLine(customerPackages.TotalCalcTarrifUsed(customerPkgsBT));
            Console.WriteLine(customerPackages.TotalCalcTarrifUsed(customerPkgs));



        } } } 
           