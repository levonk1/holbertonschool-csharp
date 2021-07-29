using NUnit.Framework;

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
        public void Basic_Test()
        {
            int[,] matrix = new int[,] {
                {1, 2},
                {3, 4},
                {5, 6}
            };
            int num = 2;
            int[,] result = Matrix.Divide(matrix, num);
            int[,] answer = new int[,] {
                {0, 1},
                {1, 2},
                {2, 3}
            };
            Assert.AreEqual(answer, result);
        }
        [Test]
        public void Div_By_Zero()
        {
            int[,] matrix = new int[,] {
                {1, 2},
                {3, 4},
                {5, 6}
            };
            int num = 0;
            int[,] result = Matrix.Divide(matrix, num);
            Assert.AreEqual(null, result);
        }
        [Test]
        public void Matrix_Null()
        {
            int[,] matrix = null;
            int num = 0;
            int[,] result = Matrix.Divide(matrix, num);
            Assert.AreEqual(null, result);
        }
        [Test]
        public void Zero_In_Matrix()
        {
            int[,] matrix = new int[,] {
                {1, 2},
                {3, 0},
                {5, 6}
            };
            int num = 2;
            int[,] result = Matrix.Divide(matrix, num);
            int[,] answer = new int[,] {
                {0, 1},
                {1, 0},
                {2, 3}
            };
            Assert.AreEqual(answer, result);
        }
    }
}