using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SpeedTests
{
    internal abstract class AbsSpeedTest
    {
        protected int totalRuns;
        protected Stopwatch watch = new Stopwatch();

        public AbsSpeedTest(int totalRuns)
        {
            this.totalRuns = totalRuns;
        }
    }
}
