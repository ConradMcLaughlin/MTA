using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Scenario_2_2.Interfaces;

namespace Scenario_2_2
{
    class SampleClass : ISampleEvents
    {
        public event SampleDelegate SampleEvent;

        public void Invoke()
        {
            OnSampleEvent();
        }

        protected void OnSampleEvent()
        {
            if (SampleEvent != null)
                SampleEvent();
        }
    }
}
