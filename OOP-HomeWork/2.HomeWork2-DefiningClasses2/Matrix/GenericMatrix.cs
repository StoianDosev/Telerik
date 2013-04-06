using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class GenericMatrix<T> where T : IComparable
    {
        // privete fields 
        private int rows;
        private int cols;
        private T[,] Matrix;

        public GenericMatrix()// empty constructor
            : this(1, 1)
        {
        }
        public GenericMatrix(int rows, int cols)// non-empty constructor where we define the length of the rows and cols of the matrix.
        {
            this.rows = rows;
            this.cols = cols;
            this.Matrix = new T[rows, cols];
        }

        public T this[int indexRow, int indexCol]// implementation of indexer
        {
            get
            {
                if ((indexRow < this.rows) && (indexCol < this.cols))
                {
                    return this.Matrix[indexRow, indexCol];
                }
                else// if the index does not exist we throw exception
                {
                    throw new ArgumentOutOfRangeException("The index is not in the range of the matrix!");
                }
            }
            set
            {
                if ((indexRow < this.rows) && (indexCol < this.cols))
                {
                    this.Matrix[indexRow, indexCol] = value;
                }
                else// if we want to set index which does not exist we throw exception.
                {
                    throw new ArgumentOutOfRangeException("The index is not in the range of the matrix!");
                }
            }
        }
        // public properties for the fields
        public int Rows 
        {
            get { return this.rows; }
            set { this.rows = value; }
        }
        public int Cols
        {
            get { return this.cols; }
            set { this.cols = value; }
        }

        //implementation of operator "+" 
        public static GenericMatrix<T> operator +(GenericMatrix<T> matrixOne, GenericMatrix<T> matrixTwo)
        {
            if (matrixOne.cols == matrixTwo.cols && matrixOne.rows == matrixTwo.rows)// confirming that matrix have the same rows and cols
            {
                GenericMatrix<T> result = new GenericMatrix<T>(matrixOne.rows, matrixOne.cols);

                for (int i = 0; i < matrixOne.rows; i++)
                {
                    for (int j = 0; j < matrixOne.cols; j++)
                    {
                        dynamic currentOne = matrixOne[i, j]; // using dynamic type to ensure "+" operation for T type element
                        dynamic currentTwo = matrixTwo[i, j];
                        result[i, j] = currentOne + currentTwo;
                    }
                }
                return result;
            }
            else
            {
                throw new ArgumentException("The matrices have to be with same sizes!");
            }
        }

        // implementation of operator "-"
        public static GenericMatrix<T> operator -(GenericMatrix<T> matrixOne, GenericMatrix<T> matrixTwo)
        {
            if (matrixOne.cols == matrixTwo.cols && matrixOne.rows == matrixTwo.rows)// confirming that matrices have the same rows and cols.
            {
                GenericMatrix<T> result = new GenericMatrix<T>(matrixOne.rows, matrixOne.cols);

                for (int i = 0; i < matrixOne.rows; i++)
                {
                    for (int j = 0; j < matrixOne.cols; j++)
                    {
                        dynamic currentOne = matrixOne[i, j];// using dynamic type to ensure "-" operation for T type element
                        dynamic currentTwo = matrixTwo[i, j];
                        result[i, j] = currentOne - currentTwo;
                    }
                }
                return result;
            }
            else
            {
                throw new ArrayTypeMismatchException("The matrices have to be with same sizes!");
            }
        }
        // implementation of operator "*"
        public static GenericMatrix<T> operator *(GenericMatrix<T> matrixOne, GenericMatrix<T> matrixTwo)
        {
            if (matrixOne.cols == matrixTwo.rows)// confirming that the first matrix has the same number cols as the number of the rows of the second.
            {
                GenericMatrix<T> result = new GenericMatrix<T>(matrixOne.rows, matrixTwo.cols);

                for (int row = 0; row < result.rows; row++)
                {
                    for (int colMultiply = 0; colMultiply < matrixTwo.cols; colMultiply++)
                    {
                        for (int innerCol = 0; innerCol < matrixOne.cols; innerCol++)
                        {
                            dynamic colResult = matrixOne[row, innerCol];
                            dynamic rowResult = matrixTwo[innerCol, colMultiply];// using dynamic type to ensure "*" operation for T type element

                            result[row, colMultiply] += colResult * rowResult;
                        }
                    }
                }
                return result;
            }
            else
            {
                throw new ArgumentException("You can multiply only if the number of the cols of the first matrix is the equal to the number of the rows of the second!");
            }
        }

        //implementation of operator "true"
        public static bool operator true(GenericMatrix<T> matrix)
        {
            StringBuilder builder = new StringBuilder();

            for (int row = 0; row < matrix.rows; row++)
            {
                for (int col = 0; col < matrix.cols; col++)
                {
                    dynamic element = matrix[row, col];
                    if( element == default(T))// confirming with default value of T type
                    {
                        return false;
                    }
                }
                builder.AppendLine();
            }
            return true;
        }
        //implementation of operator "false"
        public static bool operator false(GenericMatrix<T> matrix)
        {
            StringBuilder builder = new StringBuilder();

            for (int row = 0; row < matrix.rows; row++)
            {
                for (int col = 0; col < matrix.cols; col++)
                {
                    dynamic element = matrix[row, col];
                    if (element == default(T))
                    {
                        return false;
                    }
                }
                builder.AppendLine();
            }
            return true;
        }

        public static bool operator !(GenericMatrix<T> matrix)
        {
            StringBuilder builder = new StringBuilder();

            for (int row = 0; row < matrix.rows; row++)
            {
                for (int col = 0; col < matrix.cols; col++)
                {
                    dynamic element = matrix[row, col];
                    if (element == default(T))// confirming with default value of T type
                    {
                        return true;
                    }
                }
                builder.AppendLine();
            }
            return false;
        }
        //implementation of ToString()
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            for (int row = 0; row < Matrix.GetLength(0); row++)
            {
                for (int col = 0; col < Matrix.GetLength(1); col++)
                {
                    builder.AppendFormat("{0,2} ", Matrix[row, col]);
                }
                builder.AppendLine();
            }
            return builder.ToString();
        }

    }
}
