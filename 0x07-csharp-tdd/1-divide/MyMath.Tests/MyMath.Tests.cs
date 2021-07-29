using System;
using System.IO;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            StreamWriter standardOut =
                new StreamWriter(Console.OpenStandardOutput());
            standardOut.AutoFlush = true;
            Console.SetOut(standardOut);
        }
        [Test]
        public void Divide_By_Zero()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                int[,] neo = {
                    {1, 2, 3},
                    {4, 5, 6},
                    {7, 8, 9}
                };
                int num = 0;
                string output =
                    string.Format("Num cannot be 0{0}", Environment.NewLine);
                int[,] result = MyMath.Matrix.Divide(neo, num);
                Assert.That(output, Is.EqualTo(sw.ToString()));
                Assert.That(result, Is.Null);

            }
        }
        [Test]
        public void Divide_Null_Matrix()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                int[,] neo = null;
                int num = 7;
                string output =
                    string.Format("", Environment.NewLine);
                int[,] result = MyMath.Matrix.Divide(neo, num);
                Assert.That(output, Is.EqualTo(sw.ToString()));
                Assert.That(result, Is.Null);

            }
        }
        [Test]
        public void Divide_Even_Matrix()
        {
            int[,] neo = {
                {2, 1, -2},
                {8, 16, 8},
                {-4, 4, 4}
            };
            int num = 2;
            int [,] output = {
                {1, 0, -1},
                {4, 8, 4},
                {-2, 2, 2}
            };
            int[,] result = MyMath.Matrix.Divide(neo, num);
            Assert.That(result, Is.EqualTo(output));
        }
        [Test]
        public void Divide_Empty_Matrix()
        {
            int[,] neo = {};
            int num = 2;
            int [,] output = {};
            int[,] result = MyMath.Matrix.Divide(neo, num);
            Assert.That(result, Is.EqualTo(output));
        }
    }
}