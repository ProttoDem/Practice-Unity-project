using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripts.Model
{
    interface ICPU : IProduct
    {
        void MotherboardCompatibility(IMotherboard motherboard);

        void MemoryCompatibility(IMemory memory);

    }
}
