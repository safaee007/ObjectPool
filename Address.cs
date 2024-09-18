using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ObjectPool_SampleProject
{
    public class Address
    {
        public void GetAddress(int personId)
        {
            Console.WriteLine("Address: " + personId);
        }
    }
}
