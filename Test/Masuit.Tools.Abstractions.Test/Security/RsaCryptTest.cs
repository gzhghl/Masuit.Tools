using System;
using Masuit.Tools.Security;
using Masuit.Tools.Systems;
using Xunit;

namespace Masuit.Tools.Abstractions.Test.Security
{
    public class RsaCryptTest
    {
        public class RsaCryptTestEntity
        {
            public string Name { get; set; }
            public DateTime SdTime { get; set; }
        }

        [Fact]
        public void RsaCryptWordTestWithNoException()
        {
            var rsaKey = RsaCrypt.GenerateRsaKeys();

            string result = new RsaCryptTestEntity()
            {
                SdTime = DateTime.Parse("2020-08-14"),
                Name = "asdf"
            }
            .ToJsonExt()
            .RSAEncrypt()
            .RSADecrypt();

            Assert.Equal(result, "123");
        }
    }
}