using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COS_Lab4.Smooth
{
    public interface ISmoother
    {
        public double[] Smooth(double[] signal);
    }
}
