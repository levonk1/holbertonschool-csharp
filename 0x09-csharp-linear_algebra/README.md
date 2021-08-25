# 0x09. C# - Linear Algebra

![N|Solid](https://upload.wikimedia.org/wikipedia/commons/thumb/4/4f/Csharp_Logo.png/245px-Csharp_Logo.png)

### Tasks

``Mandatory`` 

| Task | Description |
| ------ | ------ |
| 0. Pythagoras | Calculate the value of the following and write your answer in a text file: Given the triangle ABC where AB = 64 and BC = 121, what is the length of AC? |
| 1. Magnitude #0 - 2D | Calculate the value of the following and write your answer in a text file: What is the length of vector v, assuming its origin is 0, 0? v = (3, 9) |
| 2. Magnitude #1 - 3D | Calculate the value of the following and write your answer in a text file: What is the length of v, assuming its origin is 0, 0, 0? v = (7, -3, -9) |
| 3. Magnitude #2 | Create a method that calculates and returns the length of a given vector. -Class: VectorMath. -Prototype: public static double Magnitude(double[] vector). -The vector can be 2D or 3D. -If the vector is not a 2D or 3D vector, return -1. -The return value should be rounded to the nearest tenth |
| 4. Vector addition #0 - 2D | Calculate the value of the following and write your answer in a text file: -What is the sum of the 2D vectors v and u? v = (8, -11) u = (-4, 9) |
| 5. Vector addition #1 - 3D | Calculate the value of the following and write your answer in a text file: -What is the sum of the 3D vectors v and u? v = (14, -2, 0) u = (-3, 23, 50) |
| 6. Vector addition #2 | Create a method that adds two vectors and returns the resulting vector. -Class: VectorMath. -Prototype: public static double[] Add(double[] vector1, double[] vector2). -The vectors can be 2D or 3D. -If any vector is not a 2D or 3D vector, or if the vectors are not of the same size, return a vector containing -1 |
| 7. Vector-scalar multiplication #0 - 2D | Calculate the value of the following and write your answer in a text file: -What is the result of multiplying the 2D vector v and scalar x? v = (98, 972) x = 0.5 |
| 8. Vector-scalar multiplication #1 - 3D | Calculate the value of the following and write your answer in a text file: -What is the result of multiplying the 3D vector v and scalar x? v = (0, -16, 31) x = 4 |
| 9. Vector-scalar multiplication #2 | Create a method that multiplies a vector and a scalar and returns the resulting vector. -Class: VectorMath. -Prototype: public static double[] Multiply(double[] vector, double scalar). -The vectors can be 2D or 3D. -If any vector is not a 2D or 3D vector, return a vector containing -1 |
| 10. Dot product #0 - 2D | Calculate the value of the following and write your answer in a text file: -What is the dot product of v and u? v = (1, 3) u = (-2, 5) |
| 11. Dot product #1 - 3D | Calculate the value of the following and write your answer in a text file: -What is the dot product of v and u? v = (-4, 0, 10) u = (3, 7, -9) |
| 12. Dot product #2 | Create a method that calculates dot product of either two 2D or two 3D vectors. -Class: VectorMath. -Prototype: public static double DotProduct(double[] vector1, double[] vector2). -The vectors can be either both 2D or both 3D. -If any vector is not a 2D or 3D vector, or both vectors are not the same size, return -1 |
| 13. Matrix addition #0 | Calculate the value of the following and write your answer in a text file: What is the result of adding the two matrices M and N? |
| 14. Matrix addition #1 | Create a method that adds two matrices and returns the resulting matrix. -Class: MatrixMath. -Prototype: public static double[,] Add(double[,] matrix1, double[,] matrix2). -The matrices can be either both 2D or both 3D: -2D ex.: double[,] matrix = { { 1, 2 }, { 3, 4 } }; -3D ex.: double[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }; -If any matrix is not a 2D or 3D matrix, or both matrices are not the same size, return a matrix containing -1 |
| 15. Matrix-scalar multiplication #0 | Calculate the value of the following and write your answer in a text file: What is the result of multiplying the matrix M and scalar x? |
| 16. Matrix-scalar multiplication #1 | Create a method that multiplies a matrix and a scalar and returns the resulting matrix. -Class: MatrixMath. -Prototype: public static double[,] MultiplyScalar(double[,] matrix, double scalar). -The matrix can be either 2D or 3D. -If the matrix is not a 2D or 3D matrix, return a matrix containing -1 |
| 17. Matrix-matrix multiplication #0 | Calculate the value of the following and write your answer in a text file: -What is the result of multiplying the two matrices M and N? |
| 18. Matrix-matrix multiplication #1 | Create a method that multiplies two matrices and returns the resulting matrix. -Class: MatrixMath. -Prototype: public static double[,] Multiply(double[,] matrix1, double[,] matrix2). -The matrices will not necessarily be square or the same dimensions. -If the matrices cannot be multiplied, return a matrix containing -1 |
| 19. Matrix rotation #0 | Calculate the value of the following and write your answer in a text file: -Rotate the matrix M by angle θ (in radians). What is the resulting matrix? |
| 20. Matrix rotation #1 | Create a method that rotates a square 2D matrix by a given angle in radians and returns the resulting matrix. NOTE: “Rotation” in this context means to apply rotation to the value of each element in the matrix, not changing the positions of the values in the matrix. -Class: MatrixMath. -Prototype: public static double[,] Rotate2D(double[,] matrix, double angle). -If the matrix is of an invalid size, return a matrix containing -1 |
| 21. Matrix shear #0 | Calculate the value of the following and write your answer in a text file: Shear the matrix M by the shear factor s in the X direction. What is the resulting matrix? |
| 22. Matrix shear #1 | Create a method that shears a square 2D matrix by a given shear factor and returns the resulting matrix. -Class: MatrixMath. -Prototype: public static double[,] Shear2D(double[,] matrix, char direction, double factor). -The shear factor can be in either the X or Y direction but not both. -If the matrix is of an invalid size, return a matrix containing -1. -If given an axis that is not x or y, return a matrix containing -1 |
| 23. Transpose matrix | Create a method to transpose a matrix and return the resulting matrix. -Class: MatrixMath. -Prototype: public static double[,] Transpose(double[,] matrix) -The matrix can be of any dimension or size. -If the matrix is empty, return an empty matrix |
| 24. Determinant #0 | Calculate the value of the following and write your answer in a text file: What is the determinant of matrix M? |
| 25. Determinant #1 | Calculate the value of the following and write your answer in a text file: What is the determinant of matrix M? |
| 26. Determinant #3 | Create a method that calculates the determinant of a matrix. -Class: MatrixMath. -Prototype: public static double Determinant(double[,] matrix). -If the matrix is not 2D or 3D, return -1 |
| 27. Cross product #0 | Calculate the value of the following and write your answer in a text file: What is the cross product of v and u? v = (2, -2, 1) u = (-8, 8, -4) |
| 28. Cross product #1 | Create a method that calculates the cross product of two 3D vectors and returns the resulting vector. -Class: VectorMath. -Prototype: public static double[] CrossProduct(double[] vector1, double[] vector2). -If either vector is not a 3D vector, return a vector containing -1 |
| 29. Inverse #0 | Calculate the value of the following and write your answer in a text file: What is the inverse of M? |
| 30. Inverse #1 | Calculate the value of the following and write your answer in a text file: What is the inverse of M? Round to the nearest tenth. |
| 31. Inverse #2 | Create a method that calculates the inverse of a 2D matrix and returns the resulting matrix. -Class: MatrixMath. -Prototype: public static double[,] Inverse2D(double[,] matrix). -If the matrix is not a 2D matrix, return -1. -If the matrix is non-invertible, return -1 |
