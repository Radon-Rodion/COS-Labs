using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COS3.Configs
{
    public class GlobalConfigs
    {
        private static GlobalConfigs? _configs = null;
        public static GlobalConfigs Configs
        {
            get
            {
                if(_configs is null)
                {
                    _configs = new GlobalConfigs();
                }
                return _configs;
            }
        }

        private GlobalConfigs()
        {
            N = 1024;
            A = 1d;
        }

        public int N { get; set; }
        public double A { get; set; }
    }
}
