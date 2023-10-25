using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class LifeInsurance : InsurancePolicy
    {
        public int Age { get; set; }


        public LifeInsurance(string? policyName, int policyId,
            double premiumAmount, int age) :
            base(policyName, policyId, premiumAmount)
        {
            PolicyName = policyName;
            PolicyId = policyId;
            PremiumAmount = premiumAmount;
            Age = age;


        }
        public double CalculatePremium()
        {
            return Age;
        }

        public void display()
        {
            Console.WriteLine("policay name:" + PolicyName + "policyid:" + PolicyId + "premiumAmount:" + PremiumAmount+"Age:"+Age);
        }
    }
}
