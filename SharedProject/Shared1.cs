using System;
using System.Collections.Generic;
using System.Text;

namespace net6_sharp10_lib
{
    public class Shared1
    {
        public Shared1(string name)
        {
            Name = name;
        }

        public Shared1()
        {
        }

        private void Test1()
        {
            // use target typed new CA
            Shared1 shared1 = new Shared1();
        }

        // make auto property get only
        public string Name { get; set; }
    }
}