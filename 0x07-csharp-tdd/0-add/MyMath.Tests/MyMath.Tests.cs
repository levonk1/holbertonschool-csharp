using NUnit.Framework;
namespace MyMath.Tests
{
    /// <summary> Test cases. </summary>
    [TestFixture]
    public class Operations_Tests
    {
        [Test]
        public void Add_Pos_Int()
        {
            int a = 6, b = 3;
            int result = Operations.Add(a, b);
            Assert.Positive(result);
            Assert.AreEqual(9, result);
        }
        [Test]
        public void Add_Neg_Int()
        {
            int a = -19, b = -1;
            int result = Operations.Add(a, b);
            Assert.Negative(result);
            Assert.AreEqual(-20, result);
        }
        [Test]
        public void Add_BigNeg_Pos_Int()
        {
            int a = -10, b = 7;
            int result = Operations.Add(a, b);
            Assert.Negative(result);
            Assert.AreEqual(-3, result);
        }
        [Test]
        public void Add_BigPos_Neg_Int()
        {
            int a = 10, b = -7;
            int result = Operations.Add(a, b);
            Assert.Positive(result);
            Assert.AreEqual(3, result);
        }
        [Test]
        public void Add_Zero_Int()
        {
            int a = 0, b = 6;
            int result = Operations.Add(a, b);
            Assert.Positive(result);
            Assert.AreEqual(6, result);
        }
        [Test]
        public void Add_Zero_And_Zero()
        {
            int a = 0, b = 0;
            int result = Operations.Add(a, b);
            Assert.Zero(result);
        }
    }
}