using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СhanceApproach
{
    interface ISignalGenerator
    {
        double[] GenerateSignalPoints(int N, int M);
    }
}
