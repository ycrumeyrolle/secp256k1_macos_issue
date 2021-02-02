using System;
using System.Security.Cryptography;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Case1()
        {
            var crv = ECCurve.CreateFromValue("1.3.132.0.10");
            using ECDsa ecdsa = ECDsa.Create();
            ecdsa.GenerateKey(crv);
        }

        [Fact]
        public void Case2()
        {
            var crv = ECCurve.CreateFromValue("1.3.132.0.10");
            using ECDsa ecdsa = ECDsa.Create(crv);
        }
    }
}
