using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module3HW4.Services.Abstractions;

namespace Module3HW4
{
    public class Starter
    {
        private readonly IFenceService _fenceService;

        public Starter(
            IFenceService fenceService)
        {
            _fenceService = fenceService;
        }

        public void Run()
        {
            var result = _fenceService.FenceLength();
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
