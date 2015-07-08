using Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logImplementer
{
    public class CRMLogger:BaseLogger
    {
        public string Module { get; set; }
        public CRMLogger(string module)
        {
            Module = module;
        }
        protected override void SetBasicProperties(dtoLogger logger)
        {
            logger.Module = Module;
        }
    }
}
