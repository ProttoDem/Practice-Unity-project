using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripts.Model

{
    interface IPCComponentsFactory
    {
        public ICPU createCPU();

        public IMotherboard createMotherboard();

        public IMemory createMemory();

    }
}
