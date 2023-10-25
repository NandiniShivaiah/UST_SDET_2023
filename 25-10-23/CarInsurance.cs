using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class CarInsurance : InsurancePolicy
    {
        private string v1;
        private int v2;
        private string v3;

        private string? vehicleType { get; set; }
        

        public CarInsurance(string? PolicyName, int PolicyId, double PremiumAmount,string? vehicleType) : base(PolicyName, PolicyId, PremiumAmount)
        {
            this.vehicleType = vehicleType;
        }


        public double calculatePremium()
        {
            if (vehicleType.Equals("TATA"))
            {
                return 1000.00;
            }
            else if (vehicleType.Equals("SCG"))
            {
                return 800.00;
            }
            else
            {
                return 900.00;
            }

        }

        public void display()
        {
            Console.WriteLine("policay name:" + PolicyName + "policyid:" + PolicyId + "premiumAmount:" + PremiumAmount+"vehicleType:"+vehicleType);
        }
    }
}
       
       /* public CarInsurance(string? PolicyName, int PolicyId, double PremiumAmount) : base(PolicyName, PolicyId, PremiumAmount)
        {
            PlolicyName = PolicyName;
            PolicyId = PolicyId;
            PremiumAmount = PremiumAmount;


        }

        public string? TypeVehicle { get; set; }
      

        public new void CalculatePremium()
        {
            if()
            Console.WriteLine("PolicyName:" + PolicyName + "PolicyId:" + PolicyId + "PremiumAmount:" + PremiumAmount + "TypeVehicle:"+TypeVehicle);
        }

    }
    }*/

