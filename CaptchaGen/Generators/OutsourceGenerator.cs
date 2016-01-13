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
    public class OutsourceGenerator : IGenerator
    {
        public OutsourceGenerator()
        {
            if (!IsNetworkAvailable())
                throw new Exception("Network is not reachable");
        }
        public string Generate(int size)
        {
            if (!IsNetworkAvailable())
                throw new Exception("Network is not reachable");

            var client = new RandomOrgApiClient("82157e8f-726c-456d-a160-1f5ea2dd2447");
            var response = client.GenerateIntegers(size, 0, 31);

            StringBuilder sb = new StringBuilder(size);

            foreach (int n in response.Integers)
                sb.Append(CharacterSet.list[n]);

            return sb.ToString();
        }

        private bool IsNetworkAvailable()
        {
            return System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
        }


    }
}
