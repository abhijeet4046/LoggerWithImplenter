using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logImplementer
{
   public class Emailr
    {
        CRMLogger log = new CRMLogger("Emailr");

        public void WriteLogForEmailr()
        {
            for (int i = 0; i < 10; i++)
            {
                log.Error("Email Redding failed Becoz null object.....");
            }
        }
    }
}
