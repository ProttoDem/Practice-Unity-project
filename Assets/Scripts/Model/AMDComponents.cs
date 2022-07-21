using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripts.Model
{
    class AMDComponents : IPCComponentsFactory
    {
        public IMotherboard createMotherboard()
        {
            return new AMDMotherboard();
        }

        public IMemory createMemory()
        {
            return new AMDMemory();
        }

        public ICPU createCPU()
        {
            return new AMDCPU();
        }
    }
}
