using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_study
{
    internal interface IEnrollable
    {
       
            public void CourseRegistration(int cId, int sId);
            public void Withdrawal(int couId);
        }
    }
