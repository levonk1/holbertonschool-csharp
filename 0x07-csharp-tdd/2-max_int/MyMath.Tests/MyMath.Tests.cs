using NUnit.Framework;
using System.Collections.Generic;
namespace MyMath.Tests
{
    public class Tests
    {
        [Test]
        public void First_Test()
        {
            Assert.Pass();
        }
        [Test]
        public void List_Empty()
        {
            List<int> num = new List<int>();
            int result = Operations.Max(num);
            Assert.AreEqual(0, result);
        }
        [Test]
        public void Max_In_List()
        {
            List<int> nums = new List<int> {5, 2, 7, 9, 3, 1};
            int result = Operations.Max(nums);
            Assert.AreEqual(9, result);
        }
        [Test]
        public void Neg_Int_List()
        {
            List<int> num = new List<int> {-5, -2, -7, -9, -3, -1};
            int result = Operations.Max(num);
            Assert.AreEqual(-1, result);
        }
        [Test]
        public void Mix_Int_List()
        {
            List<int> num = new List<int> {-5, 2, -7, 9, 3, -1};
            int result = Operations.Max(num);
            Assert.AreEqual(9, result);
        }
        [Test]
        public void Zero_In_List()
        {
            List<int> num = new List<int> {-5, -2, -7, 0, -3, -1};
            int result = Operations.Max(num);
            Assert.AreEqual(0, result);
        }
        [Test]
        public void Repeat_List()
        {
            List<int> num = new List<int> {6, 6, 6, 6, 6, 6};
            int result = Operations.Max(num);
            Assert.AreEqual(6, result);
        }
        [Test]
        public void Single_Number_List()
        {
            List<int> num = new List<int> {6};
            int result = Operations.Max(num);
            Assert.AreEqual(6, result);
        }
    }
}