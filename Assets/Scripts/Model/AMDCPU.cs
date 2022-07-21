using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripts.Model
{
    class AMDCPU : IProduct, ICPU
    {
        private string name = "AMDCPU";
        private int code;
        public int getCode()
        {
            return code;
        }

        public string getName()
        {
            return name;
        }

        public void MemoryCompatibility(IMemory memory)
        {
            throw new NotImplementedException();
        }

        public void MotherboardCompatibility(IMotherboard motherboard)
        {
            throw new NotImplementedException();
        }
                
    }
}
