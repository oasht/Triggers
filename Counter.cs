using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triggers_hw
{
    public class Counter
    {

        public string Brand { get; set; }
        public string Model { get; set; }
        public int SerialID { get; set; }
        public DateTime lastCheck { get; set; }
        public bool hotWater { get; set; }
    }
}
