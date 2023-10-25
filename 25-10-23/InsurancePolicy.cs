using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal abstract class InsurancePolicy
    {
        public InsurancePolicy(string? PolicyName, int PolicyId, double PremiumAmount)
        {
            this.PolicyName = PolicyName;
           this.PolicyId = PolicyId;
            this.PremiumAmount = PremiumAmount;
        }

        /*private string? policyName;
       private int policyId;
         private double premiumAmount;

        /* public InsurancePolicy(string? policyName, int policyId, double premiumAmount)
         {
             this.policyName = policyName;
             this.policyId = policyId;
             this.premiumAmount = premiumAmount;
         }*/





        public  string? PolicyName { get; set; }
        public int PolicyId { get; set; }

        public double PremiumAmount { get; set; }


        public void RenewPolicy(double newPremium)
        {
            
            PremiumAmount = newPremium;
            Console.WriteLine("policay name:" + PolicyName + "policyid:" + PolicyId + "premiumAmount:" + PremiumAmount);
        }


        public void RenewPolicy()
        {
           
            PremiumAmount += PremiumAmount * 0.10;
            Console.WriteLine("policay name:" + PolicyName + "policyid:" + PolicyId + "premiumAmount:" + PremiumAmount);

        }

        public new double CalculatePremium()
        {
            return PremiumAmount;
        }

    }
}
