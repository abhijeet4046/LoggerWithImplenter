using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logImplementer
{
   public class OSR
    {
        CRMLogger log = new CRMLogger("OSR");

        public void WriteLogForOSR()
        {
            for (int i = 0; i < 10; i++)
            {
                log.Debug("debug OSRConfigTAT .....");
            }
        }
    }
}
