<html>
<h1>Project: CSharp Linear Algebra</h1>
<p><strong>In this project we'll review some linear algebra concepts and do some exercises with c-sharp.</strong></p>
<body>
<li><strong>Task 0:</strong> Calculate the value of the following and write your answer in a text file:

Given the triangle ABC where AB = 64 and BC = 121, what is the length of AC?</li>
<li><strong>Task 1:</strong> Calculate the value of the following and write your answer in a text file:

What is the length of vector v, assuming its origin is 0, 0?</li>
<li><strong>Task 2:</strong> Calculate the value of the following and write your answer in a text file:

What is the length of v, assuming its origin is 0, 0, 0?
v = (7, -3, -9)</li>
<li><strong>Task 3:</strong> Create a method that calculates and returns the length of a given vector.
<ul>
<li>Class: VectorMath</li>
<li>Prototype: public static double Magnitude(double[] vector)</li>
<li>The vector can be 2D or 3D</li>
<li>If the vector is not a 2D or 3D vector, return -1</li>
<li>The return value should be rounded to the nearest tenth</li>
</ul>
</li>
<li><strong>Task 4:</strong> Calculate the value of the following and write your answer in a text file:

What is the sum of the 2D vectors v and u?

v = (8, -11)

u = (-4, 9)</li>
<li><strong>Task 5:</strong> Calculate the value of the following and write your answer in a text file:

What is the sum of the 3D vectors v and u?

v = (14, -2, 0)

u = (-3, 23, 50)</li>
<li><strong>Task 6:</strong> Create a method that adds two vectors and returns the resulting vector.
<ul>
<li>Class: VectorMath</li>
<li>Prototype: public static double[] Add(double[] vector1, double[] vector2)</li>
<li>The vectors can be 2D or 3D</li>
<li>If any vector is not a 2D or 3D vector, or if the vectors are not of the same size, return a vector containing -1</li>
</ul>
</li>
<li><strong>Task 7:</strong> Calculate the value of the following and write your answer in a text file:

What is the result of multiplying the 2D vector v and scalar x?

v = (98, 972)

x = 0.5</li>
<li><strong>Task 8:</strong> Calculate the value of the following and write your answer in a text file:

What is the result of multiplying the 3D vector v and scalar x?

v = (0, -16, 31)

x = 4</li>
<li><strong>Task 9:</strong> Create a method that multiplies a vector and a scalar and returns the resulting vector.
<ul>
<li>Class: VectorMath</li>
<li>Prototype: public static double[] Multiply(double[] vector, double scalar)</li>
<li>The vectors can be 2D or 3D</li>
<li>If any vector is not a 2D or 3D vector, return a vector containing -1</li>
</ul>
</li>
<li><strong>Task 10:</strong> Calculate the value of the following and write your answer in a text file:

What is the dot product of v and u?

v = (1, 3)

u = (-2, 5)</li>
<li><strong>Task 11:</strong> Calculate the value of the following and write your answer in a text file:

What is the dot product of v and u?

v = (-4, 0, 10)

u = (3, 7, -9)</li>
<li><strong>Task 12:</strong> Create a method that calculates dot product of either two 2D or two 3D vectors.
<ul>
<li>Class: VectorMath</li>
<li>Prototype: public static double DotProduct(double[] vector1, double[] vector2)</li>
<li>The vectors can be either both 2D or both 3D</li>
<li>If any vector is not a 2D or 3D vector, or both vectors are not the same size, return -1</li>
</ul>
</li>
<li><strong>Task 13:</strong>Calculate the value of the following and write your answer in a text file:

What is the result of adding the two matrices M and N? </li>
<li><strong>Task 14:</strong> Create a method that adds two matrices and returns the resulting matrix.
<ul>
<li>Class: MatrixMath</li>
<li>Prototype: public static double[,] Add(double[,] matrix1, double[,] matrix2)</li>
<li>The matrices can be either both 2D or both 3D</li>
<li>If any matrix is not a 2D or 3D matrix, or both matrices are not the same size, return a matrix containing -1</li>
</ul>
</li>
<li><strong>Task 15:</strong> Calculate the value of the following and write your answer in a text file:

What is the result of multiplying the matrix M and scalar x?</li>
<li><strong>Task 16:</strong> Create a method that multiplies a matrix and a scalar and returns the resulting matrix.
<ul>
<li>Class: MatrixMath</li>
<li>Prototype: public static double[,] MultiplyScalar(double[,] matrix, double scalar)</li>
<li>The matrix can be either 2D or 3D</li>
<li>If the matrix is not a 2D or 3D matrix, return a matrix containing -1</li>
</ul>
</li>
<li><strong>Task 17:</strong> Calculate the value of the following and write your answer in a text file:

What is the result of multiplying the two matrices M and N?</li>
<li><strong>Task 18:</strong> Create a method that multiplies two matrices and returns the resulting matrix.
<ul>
<li>Class: MatrixMath</li>
<li>Prototype: public static double[,] Multiply(double[,] matrix1, double[,] matrix2)</li>
<li>The matrices will not necessarily be square or the same dimensions</li>
<li>If the matrices cannot be multiplied, return a matrix containing -1</li>
</ul>
</li>
<li><strong>Task 19:</strong> Calculate the value of the following and write your answer in a text file:

Rotate the matrix M by angle θ (in radians). What is the resulting matrix?</li>
<li><strong>Task 20:</strong> Create a method that rotates a square 2D matrix by a given angle in radians and returns the resulting matrix.
<br>
NOTE: “Rotation” in this context means to apply rotation to the value of each element in the matrix, not changing the positions of the values in the matrix.
<ul>
<li>Class: MatrixMath</li>
<li>Prototype: public static double[,] Rotate2D(double[,] matrix, double angle)</li>
<li>If the matrix is of an invalid size, return a matrix containing -1</li>
</ul>
</li>
<li><strong>Task 21:</strong> Calculate the value of the following and write your answer in a text file:

Shear the matrix M by the shear factor s in the X direction. What is the resulting matrix?</li>
<li><strong>Task 22:</strong> Create a method that shears a square 2D matrix by a given shear factor and returns the resulting matrix.
<ul>
<li>Class: MatrixMath</li>
<li>Prototype: public static double[,] Shear2D(double[,] matrix, char direction, double factor)</li>
<li>The shear factor can be in either the X or Y direction but not both</li>
<li>If the matrix is of an invalid size, return a matrix containing -1</li>
<li>If given an axis that is not x or y, return a matrix containing -1</li>
</ul>
</li>
<li><strong>Task 23:</strong> Create a method to transpose a matrix and return the resulting matrix.
<ul>
<li>Class: MatrixMath</li>
<li>Prototype: public static double[,] Transpose(double[,] matrix)</li>
<li>The matrix can be of any dimension or size</li>
<li>If the matrix is empty, return an empty matrix</li>
</ul>
</li>
<li><strong>Task 24:</strong> Calculate the value of the following and write your answer in a text file:

What is the determinant of matrix M?</li>
<li><strong>Task 25:</strong> Calculate the value of the following and write your answer in a text file:

What is the determinant of matrix M?</li>
<li><strong>Task 26:</strong> Create a method that calculates the determinant of a matrix.
<ul>
<li>Class: MatrixMath</li>
<li>Prototype: public static double Determinant(double[,] matrix)</li>
<li>If the matrix is not 2D or 3D, return -1</li>
</ul>
</li>
<li><strong>Task 27:</strong> Calculate the value of the following and write your answer in a text file:

What is the cross product of v and u?

v = (2, -2, 1)

u = (-8, 8, -4)</li>
<li><strong>Task 28:</strong> Create a method that calculates the cross product of two 3D vectors and returns the resulting vector.
<ul>
<li>Class: VectorMath</li>
<li>Prototype: public static double[] CrossProduct(double[] vector1, double[] vector2)</li>
<li>If either vector is not a 3D vector, return a vector containing -1</li>
</ul>
</li>
<li><strong>Task 29:</strong> Calculate the value of the following and write your answer in a text file:

What is the inverse of M?</li>
<li><strong>Task 30:</strong> Calculate the value of the following and write your answer in a text file:

What is the inverse of M? Round to the nearest tenth.</li>
<li><strong>Task 31:</strong> Create a method that calculates the inverse of a 2D matrix and returns the resulting matrix.
<ul>
<li>Class: MatrixMath</li>
<li>Prototype: public static double[,] Inverse2D(double[,] matrix)</li>
<li>If the matrix is not a 2D matrix, return -1</li>
<li>If the matrix is non-invertible, return -1</li>
</ul>
</li>
</body>
<br>
<br>
<footer>Made by: <strong><a href="https://github.com/DanielBaquero28">Daniel Baquero</a></strong></footer>
</html>
