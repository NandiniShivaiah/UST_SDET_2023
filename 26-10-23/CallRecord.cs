using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment1
{
    internal class CallRecord
    {
        public CallRecord(int callID, string? phoneNumber, string? callTime)
        {
            CallID = callID;
            PhoneNumber = phoneNumber;
            CallTime = callTime;
        }



        public int CallID { get; set; }
        public string? PhoneNumber { get; set; }
        public string? CallTime { get; set; }

        public void CallHistory(CallRecord call)
        {
            if (call.PhoneNumber != null)
            {
                Console.WriteLine("call ID: " + CallID + " Call time: " +
                    CallTime);
            }

        }


    }
}