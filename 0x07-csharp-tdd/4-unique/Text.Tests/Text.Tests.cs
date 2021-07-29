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
        public void Empty_Str()
        {
            string str = "";
            int res = Str.UniqueChar(str);
            Assert.AreEqual(-1, res);
        }
        [Test]
        public void One_Char_Str()
        {
            string str = "s";
            int res = Str.UniqueChar(str);
            Assert.AreEqual(0, res);
        }
        [Test]
        public void Last_Unique_Char_Str()
        {
            string str = "papas";
            int res = Str.UniqueChar(str);
            Assert.AreEqual(4, res);
        }
        [Test]
        public void Mid_Unique_Char_Str()
        {
            string str = "ana";
            int res = Str.UniqueChar(str);
            Assert.AreEqual(1, res);
        }
        [Test]
        public void First_Unique_Char_Str()
        {
            string str = "palla";
            int res = Str.UniqueChar(str);
            Assert.AreEqual(0, res);
        } 
        [Test]
        public void No_Unique_Char_Str()
        {
            string str = "anna";
            int res = Str.UniqueChar(str);
            Assert.AreEqual(-1, res);
        }      
    }
}