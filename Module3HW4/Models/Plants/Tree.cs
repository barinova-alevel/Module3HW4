using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW4.Models.Plants
{
    public class Tree : Plant
    {
        private readonly double _rainTreeWatering;
        public double RainTreeWatering
        {
            get => _rainTreeWatering;
            init
            {
                if (value > 10)
                {
                    _rainTreeWatering = value;
                }
            }
        }
    }
}
