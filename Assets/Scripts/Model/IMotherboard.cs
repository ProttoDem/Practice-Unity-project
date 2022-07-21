using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripts.Model
{
    interface IMotherboard : IProduct
    {
        void CPUCompatibility(ICPU cpu);

    }
}
