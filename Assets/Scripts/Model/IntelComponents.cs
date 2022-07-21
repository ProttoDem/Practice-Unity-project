using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripts.Model
{
    class IntelComponents : IPCComponentsFactory
    {
        public IMotherboard createMotherboard()
        {
            return new IntelMotherboard();
        }

        
        public ICPU createCPU()
        {
            return new IntelCPU();
        }

        public IMemory createMemory()
        {
            return new IntelMemory();
        }
    }
}
