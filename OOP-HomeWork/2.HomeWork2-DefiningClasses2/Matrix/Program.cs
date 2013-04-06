using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main()
        {
            GenericMatrix<int> matrixFirst = new GenericMatrix<int>(2,3);
            GenericMatrix<int> matrixSecond = new GenericMatrix<int>(3, 2);
            GenericMatrix<int> matrixThird = new GenericMatrix<int>(3, 2);

            matrixFirst[0, 0] = 3;
            matrixFirst[0, 1] = 1;
            matrixFirst[0, 2] = 2;
            matrixFirst[1, 0] = -2;
            matrixFirst[1, 1] = 0;
            matrixFirst[1, 2] = 5;

            matrixSecond[0, 0] = -1;
            matrixSecond[0, 1] = 3;
            matrixSecond[1, 0] = 0;
            matrixSecond[1, 1] = 5;
            matrixSecond[2, 0] = 2;
            matrixSecond[2, 1] = 5;

            matrixThird[0, 0] = 2;
            matrixThird[0, 1] = 3;
            matrixThird[1, 0] = 0;
            matrixThird[1, 1] = 5;
            matrixThird[2, 0] = 2;
            matrixThird[2, 1] = 5;

            Console.WriteLine(matrixFirst * matrixSecond);
            Console.WriteLine(matrixSecond + matrixThird);
            Console.WriteLine(matrixSecond - matrixThird);

            if (matrixFirst * matrixSecond)
            {
                Console.WriteLine("There is no zero elements in the matrix.");
            }
            if (!matrixFirst)
            {
                Console.WriteLine("There is zero element in the matrix!");
            }
            Console.WriteLine(matrixFirst);
        }
    }
}
