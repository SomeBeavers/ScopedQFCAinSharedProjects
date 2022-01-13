using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedFiles;

namespace UseLinked3
{
    internal class Program
    {
        public Program(string name)
        {
            Name = name;
        }

        public Program()
        {
        }

        static void Main(string[] args)
        {
            new LinkedFile1("").Name = "";
        }

        public string Name { get; set; }
    }
}
