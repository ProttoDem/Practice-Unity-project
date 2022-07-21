using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripts.Model
{
    class AMDMemory : IProduct, IMemory
    {
        private string name;
        private int code;
        public int getCode()
        {
            return code;
        }

        public string getName()
        {
            return name;
        }
        public void CPUCompatibility(ICPU cpu)
        {
            throw new NotImplementedException();
        }
    }
}
