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
            bool res = Str.IsPalindrome(str);
            Assert.AreEqual(true, res);
        }
        [Test]
        public void Basic_Case_Str()
        {
            string str = "level";
            bool result = Str.IsPalindrome(str);
            Assert.AreEqual(true, result);
        }
        [Test]
        public void Not_CaseSensitive_Str()
        {
            string str = "Racecar";
            bool result = Str.IsPalindrome(str);
            Assert.AreEqual(true, result);
        }
        [Test]
        public void Not_Palindrome_Str()
        {
            string str = "ducks";
            bool result = Str.IsPalindrome(str);
            Assert.AreEqual(false, result);
        }
        [Test]
        public void Long_Palindrome_Str()
        {
            string str = "A man, a plan, a canal: Panama";
            bool result = Str.IsPalindrome(str);
            Assert.AreEqual(true, result);
        }
        [Test]
        public void Not_Palindrome_LongStr()
        {
            string str = "man, a plan, a canal: Panama";
            bool result = Str.IsPalindrome(str);
            Assert.AreEqual(false, result);
        }
        [Test]
        public void One_Char_Palindrome()
        {
            string str = "a";
            bool result = Str.IsPalindrome(str);
            Assert.AreEqual(true, result);
        }
    }
}