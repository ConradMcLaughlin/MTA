using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleClass sample = new SampleClass();
            sample.SampleEvent += Sample_SampleEvent;
            sample.Invoke();
        }

        private static void Sample_SampleEvent()
        {
            Console.WriteLine("Event Raised :)");
        }
    }
}
