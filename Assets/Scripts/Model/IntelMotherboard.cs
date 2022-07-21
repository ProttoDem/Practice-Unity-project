using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scripts.Model
{
    class IntelMotherboard : IProduct, IMotherboard
    {
        private string name;
        private int code;

        public void CPUCompatibility(ICPU cpu)
        {
            throw new NotImplementedException();
        }

        public int getCode()
        {
            return code;
        }

        public string getName()
        {
            return name;
        }
       
    }
}
