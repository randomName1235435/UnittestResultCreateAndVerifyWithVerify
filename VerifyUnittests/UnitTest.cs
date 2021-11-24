using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;
using UnittestResultCreateAndVerifyWithVerify;
using VerifyMSTest;
using VerifyTests;

namespace VerifyUnittests
{
    [TestClass]
    public class UnitTest : VerifyBase
    {
        private readonly VerifySettings settings = new VerifySettings();
        private readonly SampleLib instance = new SampleLib();

        [TestInitialize]
        public void Init() {
            settings.ModifySerialization(x => x.IgnoreMember<Sample>(target => target.SamplePropertyToIgnore));
        }

        [TestMethod]
        public async Task GetDate()
        {
            await Verify(instance.GetDate(), settings);
        }
        [TestMethod]
        public async Task Sample()
        {
            await Verify(instance.GetSample(), settings);
        }
        [TestMethod]
        public async Task SampleList()
        {
            await Verify(instance.GetSampleList(), settings);
        }
    }
}
