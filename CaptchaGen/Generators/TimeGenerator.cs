using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniqueProvider.Common;
using UniqueProvider.Interfaces;
using NodaTime;
namespace UniqueProvider.Generators
{
   public class TimeGenerator : IGenerator
    {
        private Instant time;
        private RandomProvider _rnd;
        public TimeGenerator()
        {
            time = SystemClock.Instance.Now;

            _rnd = new RandomProvider();
            _rnd.Reset((int)time.Ticks);
        }
        public string Generate()
        {
            return _rnd.Next().ToString();
        }
    }
}
