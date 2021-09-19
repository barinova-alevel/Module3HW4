using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW4.Models
{
    public class Space
    {
        public Space(double value)
        {
            Value = value;
        }

        public double Value { get; set; }
        public string Unit { get; init; }
    }
}
