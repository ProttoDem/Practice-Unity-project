using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripts.Model
{
    interface IMemory : IProduct
    {
        void CPUCompatibility(ICPU cpu);
    }
}
