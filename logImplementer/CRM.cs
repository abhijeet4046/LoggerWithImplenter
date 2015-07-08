using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logImplementer
{
    public class CRM
    {
        CRMLogger log = new CRMLogger("CRM");

        public void WriteLogForCRM()
        {
            for (int i = 0; i < 50; i++)
            {
                log.Info("Writing Logs");
                log.Error("Write errors here ");
                log.Debug("Debug process");
                

            }
        }

    }
}
