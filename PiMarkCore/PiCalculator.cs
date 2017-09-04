using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiMarkCore
{
    public class PiCalculator
    {

        public delegate void FinishOnce();

        public delegate void FinishedAll();

        private FinishOnce once;
        private FinishedAll all;

        UInt64 times;

        public PiCalculator(uint times, FinishOnce onceCall, FinishedAll allCall)
        {
            this.times = times;
            once = onceCall;
            all = allCall;
        }

        public void run()
        {
            bool flag = true;
            for (uint i = 0; i < times; i++)
            {
                double res = 0.0;
                for (int j = 1; j < 10000000; j += 2)
                {
                    if (flag)
                    {
                        res += 1f / j;
                        flag = false;
                    }
                    else
                    {
                        res -= 1f / j;
                        flag = true;
                    }
                }
                res = 4 * res;
                once();
            }
            all();
        }
    }
}
