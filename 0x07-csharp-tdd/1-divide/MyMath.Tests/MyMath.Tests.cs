using NUnit.Framework;

namespace MyMath.Tests
{
    public class MatrixTests
    {
        [Test]
        public void IsCorrect()
        {
            int[,] myMatrix = new int[,]
        {
            {0, 1, 2},
            {3, 4, 5},
            {6, 7, 8}
        };

        int div = 1;

        int [,] result = MyMath.Matrix.Divide(myMatrix, div);

        Assert.AreEqual(myMatrix, result); 
        }

        [Test]
        public void BigNums()
        {
            int[,] myMatrix = new int[,]
        {
            {1000000, 1000000, 2000000},
            {3000000, 4000000, 5000000},
            {6000000, 7000000, 8000000}
        };

        int div = 1000000;

        int [,] expectedMatrix = new int[,]
        {
            {1, 1, 2},
            {3, 4, 5},
            {6, 7, 8}
        };

        int [,] result = MyMath.Matrix.Divide(myMatrix, div);

        Assert.AreEqual(expectedMatrix, result);
        }

        [Test]
        public void NegativeNums()
        {
            int[,] myMatrix = new int[,]
        {
            {-1, -2, -3},
            {-4, -5, -6},
            {-7, -8, -9}
        };

        int div = 2;

         int[,] expectedMatrix = new int[,]
        {
            {-0, -1, -1},
            {-2, -2, -3},
            {-3, -4, -4}
        };

        int[,] result = MyMath.Matrix.Divide(myMatrix, div);

        Assert.AreEqual(expectedMatrix, result);
        }

        [Test]
        public void DivideByNegativeNum()
        {
            int[,] myMatrix = new int[,]
        {
            {-1, -2, -3},
            {-4, -5, -6},
            {-7, -8, -9}
        };

        int div = -2;

         int[,] expectedMatrix = new int[,]
        {
            {0, 1, 1},
            {2, 2, 3},
            {3, 4, 4}
        };

        int[,] result = MyMath.Matrix.Divide(myMatrix, div);

        Assert.AreEqual(expectedMatrix, result);
        }

        [Test]
        public void CombineNegativePositiveNums()
        {
            int[,] myMatrix = new int[,]
        {
            {-1, 2, -3},
            {4, -5, 6},
            {-7, 8, -9}
        };

        int div = 2;

         int[,] expectedMatrix = new int[,]
        {
            {-0, 1, -1},
            {2, -2, 3},
            {-3, 4, -4}
        };

        int[,] result = MyMath.Matrix.Divide(myMatrix, div);

        Assert.AreEqual(expectedMatrix, result);
        }

        [Test]
        public void SomeElementsAreZero()
        {
            int[,] myMatrix = new int[,]
        {
            {0, -2, 0},
            {-4, 0, -6},
            {0, -8, 0}
        };

        int div = 2;

         int[,] expectedMatrix = new int[,]
        {
            {0, -1, 0},
            {-2, 0, -3},
            {0, -4, 0}
        };

        int[,] result = MyMath.Matrix.Divide(myMatrix, div);

        Assert.AreEqual(expectedMatrix, result);
        }

        [Test]
        public void AllElementsAreZero()
        {
            int[,] myMatrix = new int[,]
        {
            {0, 0, 0},
            {0, 0, 0},
            {0, 0, 0}
        };

        int div = 2;

         int[,] expectedMatrix = new int[,]
        {
            {0, 0, 0},
            {0, 0, 0},
            {0, 0, 0}
        };

        int[,] result = MyMath.Matrix.Divide(myMatrix, div);

        Assert.AreEqual(expectedMatrix, result);
        }

        [Test]
        public void MatrixIsNull()
        {
            int[,] myMatrix = null;

        int div = 2;

         int[,] expectedMatrix = new int[,]
        {
            {-0, -1, -1},
            {-2, -2, -3},
            {-3, -4, -4}
        };

        int[,] result = MyMath.Matrix.Divide(myMatrix, div);

        Assert.AreEqual(null, result);
        }

        [Test]
        public void DivideByZero()
        {
            int[,] myMatrix = new int[,]
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int div = 0;

         int[,] expectedMatrix = new int[,]
        {
            {0, 0, 0},
            {0, 0, 0},
            {0, 0, 0}
        };

        int[,] result = MyMath.Matrix.Divide(myMatrix, div);

        Assert.AreEqual(null, result);
        }
    }
}