using NUnit.Framework;

using System.Security.Cryptography;
using Encryption;

namespace Encrytion.SeleniumTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var txtPlain = "Bu bir test yazisidir";
            var txtKey = "facakici";
            var txtExpectedResult = "11000100010111101000100011101010110000101110100011001000110110101100001011100110101000011111001010100010111111000010000001111100001000100111111000000000111101101010000101111010";

            if (txtPlain.Length % 2 == 1) { txtPlain += " "; }

            SPN_encryption spn = new SPN_encryption(txtPlain, txtKey);
            var result = spn.encrypt();
            Assert.Pass(result, txtExpectedResult);
            
        }
        [Test]
        public void Test_SHA_Encryption()
        {
            var txtPlain = "Bu bir test yazisidir";
            var txtExpectedResult = "1fdd618ef893aa641d981fbdabb4cc2ea5a0eed9a93c44ac053b62a1958a4370";

            SHA_encryption sha = new SHA_encryption(txtPlain);
            Assert.Pass(sha.encrypt(), txtExpectedResult);
        }

        [Test]
        public void Test_SHA_Encryption_2()
        {
            var txtPlain = "Deneme";
            var txtExpectedResult = "a7ae1a431366f6d25f302684d2a7b67cec7ef1d1787b1d11c7ff1192bb4bdf46";

            SHA_encryption sha = new SHA_encryption(txtPlain);
            Assert.Pass(sha.encrypt(), txtExpectedResult);
        }
        [Test]
        public void Test_SPN_16_Encryption_3()
        {
            var txtPlain = "Deneme";
            var txtKey = "facakici";
            var txtExpectedResult = "100001001101011010000000010101001000001011010100";

            if (txtPlain.Length % 2 == 1) { txtPlain += " "; }

            SPN_encryption spn = new SPN_encryption(txtPlain, txtKey);
            var result = spn.encrypt();
            Assert.Pass(result, txtExpectedResult);
        }
    }
}