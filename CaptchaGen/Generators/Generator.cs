using UniqueProvider.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniqueProvider.Common;
namespace UniqueProvider.Generators
{
    public class Generator : IGenerator
    {
        private RandomProvider _rnd;
        public Generator()
        {
            _rnd = new RandomProvider();
        }
        public string Generate()
        {
            return _rnd.Next().ToString();
        }
    }
}
