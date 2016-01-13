using UniqueProvider.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniqueProvider.Common;
namespace UniqueProvider.Generators
{
    public class MockGenerator : IGenerator
    {
        private RandomProvider _rnd;
        public MockGenerator(int seed)
        {
            _rnd = new RandomProvider();
            _rnd.Reset(seed);
        }
        public string Generate(int size)
        {
            StringBuilder sb = new StringBuilder(size);

            for (int i = 0; i < size; i++)
                sb.Append(CharacterSet.list[_rnd.Next(0, 32)]);

            return sb.ToString();
        }
    }
}
