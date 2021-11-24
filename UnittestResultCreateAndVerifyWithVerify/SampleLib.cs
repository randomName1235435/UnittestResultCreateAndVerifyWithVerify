using System;
using System.Collections.Generic;

namespace UnittestResultCreateAndVerifyWithVerify
{
    public class SampleLib
    {
        public DateTime GetDate()
        {
            return DateTime.MinValue;
        }

        public Sample GetSample()
        {
            return new Sample() { SampleIntProperty = 1, SampleStringProperty = "1" };
        }

        public IEnumerable<Sample> GetSampleList()
        {
            return new List<Sample>() {
        new Sample() { SampleIntProperty = 1,SampleStringProperty= "1"},
        new Sample() { SampleIntProperty = 2,SampleStringProperty= "2"},
        new Sample() { SampleIntProperty = 3,SampleStringProperty= "3"},
        };
        }
    }
}
