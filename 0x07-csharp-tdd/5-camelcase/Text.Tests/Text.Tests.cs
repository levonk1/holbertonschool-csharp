using NUnit.Framework;
namespace Text.Tests
{
    public class Tests
    {
        [Test]
        public void First_Test()
        {
            Assert.Pass();
        }
        [Test]
        public void Empty_Case()
        {
            string str = "";
            int res = Str.CamelCase(str);
            Assert.AreEqual(0, res);
        }
        [Test]
        public void Base_Case()
        {
            string str = "ad Astra Per Aspera";
            int res = Str.CamelCase(str);
            Assert.AreEqual(4, res);
        }
        [Test]
        public void Single_Word_Case()
        {
            string str = "ad";
            int res = Str.CamelCase(str);
            Assert.AreEqual(1, res);
        }
        [Test]
        public void Single_Char_Case()
        {
            string str = "a";
            int res = Str.CamelCase(str);
            Assert.AreEqual(1, res);
        }
        [Test]
        public void Words_Union_Case()
        {
            string str = "ad Astra PerAspera";
            int res = Str.CamelCase(str);
            Assert.AreEqual(4, res);
        }
        [Test]
        public void Null_Case()
        {
            string str = null;
            int res = Str.CamelCase(str);
            Assert.AreEqual(0, res);
        }
    }
}