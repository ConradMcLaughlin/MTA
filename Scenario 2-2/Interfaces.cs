using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_2_2
{
    public class Interfaces
    {
        public delegate void SampleDelegate();

        public interface ISampleEvents
        {
            event SampleDelegate SampleEvent;
            void Invoke();
        }
    }
}
