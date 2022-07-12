using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJ
{
    public  class ALU
    {

        public int add2value(int x,int y)
        {
            return x + y;
        }
        public int sub2value(int x, int y)
        {
            return x - y;
        }
        public int mul2value(int x, int y)
        {
            return x * y;
        }
        public int div2value(int x, int y)
        {
            return x / y;

        }
        public int add3value(int x, int y)
        {
            return x + y + 10;
        }
        public int sub3value(int x, int y, int z)
        {
            return x - y - z;
        }
        public int mul3value(int x, int y, int z)
        {
            return x * y * z;
        }
        public int div3value(int x, int y, int z)
        {
            return x / y / z;
        }
    }
}
