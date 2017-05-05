using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    /// <summary>
    /// Матрица из объектов типа <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">Должен поддерживать операторы +, -, ?, *.</typeparam>
    class Matrix<T>
    {
        T[,] matrix;
        int m, n;

        /// <summary>
        /// Число строк матрицы.
        /// </summary>
        public int M { get { return m; } }
        /// <summary>
        /// Число столбцов матрицы.
        /// </summary>
        public int N { get { return n; } }

        public T this[int i, int j]
        {
            get { return matrix[i, j]; }
            set { matrix[i, j] = value; }
        }

        public Matrix(int m, int n)
        {
            this.m = m;
            this.n = n;
            matrix = new T[m, n];
        }

        public Matrix(int n)
        {
            this.m = n;
            this.n = n;
            matrix = new T[n, n];
        }

        /// <summary>
        /// Сложение матриц <paramref name="A"/> и <paramref name="B"/>.
        /// </summary>
        /// <exception cref="Microsoft.CSharp.RuntimeBinder.RuntimeBinderException">Если <typeparamref name="T"/> не поддерживает оператор +.</exception>
        /// <exception cref="ArgumentException">Если размерности матриц не совпадают.</exception>
        public static Matrix<T> operator + (Matrix<T> A, Matrix<T> B)
        {
            if (A.M != B.M || A.N != B.N)
                throw new ArgumentException("Размерности матриц не совпадают!");
            Matrix<T> result = new Matrix<T>(A.M, A.N);
            for (int i = 0; i < result.M; ++i)
                for (int j = 0; j < result.N; ++j)
                    result[i, j] = Sum(A[i, j], B[i, j]);

            return result;
        }

        /// <summary>
        /// Вычитание матриц <paramref name="A"/> и <paramref name="B"/>.
        /// </summary>
        /// <exception cref="Microsoft.CSharp.RuntimeBinder.RuntimeBinderException">Если <typeparamref name="T"/> не поддерживает оператор +.</exception>
        /// <exception cref="ArgumentException">Если размерности матриц не совпадают.</exception>
        public static Matrix<T> operator - (Matrix<T> A, Matrix<T> B)
        {
            if (A.M != B.M || A.N != B.N)
                throw new ArgumentException("Размерности матриц не совпадают!");
            Matrix<T> result = new Matrix<T>(A.M, A.N);
            for (int i = 0; i < result.M; ++i)
                for (int j = 0; j < result.N; ++j)
                    result[i, j] = Sub(A[i, j], B[i, j]);

            return result;
        }

        /// <summary>
        /// Умножение матриц <paramref name="A"/> и <paramref name="B"/>.
        /// </summary>
        /// <exception cref="Microsoft.CSharp.RuntimeBinder.RuntimeBinderException">Если <typeparamref name="T"/> не поддерживает оператор +.</exception>
        /// <exception cref="ArgumentException">Если <paramref name="A.N"/> и <paramref name="B.M"/> не совпадают.</exception>
        public static Matrix<T> operator * (Matrix<T> A, Matrix<T> B)
        {
            if (A.M != B.N)
                throw new ArgumentException("Число столбцов первой матрицы не равно числу строк второй матрицы.");
            Matrix<T> result = new Matrix<T>(A.M, B.N);
            for (int i = 0; i < result.M; ++i)
                for (int j = 0; j < result.N; ++j)
                {
                    result[i, j] = Sum(A[i, j], B[i, j]);
                    for (int k = 1; k < A.N; ++k)
                    { }
                }
            return result;
        }

        /// <summary>
        /// Умножение матрицы <paramref name="A"/> на число <paramref name="k"/>.
        /// </summary>
        /// <exception cref="Microsoft.CSharp.RuntimeBinder.RuntimeBinderException">Если <typeparamref name="T"/> невозможно умножить на число.</exception>
        public static Matrix<T> operator * (Matrix<T> A, double k)
        {
            Matrix<T> result = new Matrix<T>(A.M, A.N);
            for (int i = 0; i < result.M; ++i)
                for (int j = 0; j < result.N; ++j)
                    result[i, j] = (dynamic)A[i, j]*k;

            return result;
        }

        /// <summary>
        /// Умножение матрицы <paramref name="A"/> на число <paramref name="k"/>.
        /// </summary>
        /// <exception cref="Microsoft.CSharp.RuntimeBinder.RuntimeBinderException">Если <typeparamref name="T"/> невозможно умножить на число.</exception>
        public static Matrix<T> operator * (double k, Matrix<T> A)
        {
            return A * k;
        }

        /// <summary>
        /// Транспонирование матрицы.
        /// </summary>
        /// <returns>Транспонированная матрица.</returns>
        public Matrix<T> Transpose()
        {
            Matrix<T> result = new Matrix<T>(N, M);
            for (int i = 0; i < result.M; ++i)
                for (int j = 0; j < result.N; ++j)
                    result[i, j] = matrix[j, i];

            return result;
        }


        /// <summary>
        /// Сложение.
        /// </summary>
        /// <exception cref="Microsoft.CSharp.RuntimeBinder.RuntimeBinderException">Если <typeparamref name="T"/> не поддерживает оператор +.</exception>
        static T Sum(T a, T b)
        {
            dynamic op1 = a;
            dynamic op2 = b;

            return (T)(op1 + op2);
        }

        /// <summary>
        /// Вычитание.
        /// </summary>
        /// <exception cref="Microsoft.CSharp.RuntimeBinder.RuntimeBinderException">Если <typeparamref name="T"/> не поддерживает оператор -.</exception>
        static T Sub(T a, T b)
        {
            dynamic op1 = a;
            dynamic op2 = b;

            return (T)(op1 - op2);
        }

        /// <summary>
        /// Деление.
        /// </summary>
        /// <exception cref="Microsoft.CSharp.RuntimeBinder.RuntimeBinderException">Если <typeparamref name="T"/> не поддерживает оператор /.</exception>
        static T Div(T a, T b)
        {
            dynamic op1 = a;
            dynamic op2 = b;

            return (T)(op1 / op2);
        }

        /// <summary>
        /// Умножение.
        /// </summary>
        /// <exception cref="Microsoft.CSharp.RuntimeBinder.RuntimeBinderException">Если <typeparamref name="T"/> не поддерживает оператор *.</exception>
        static T Mult(T a, T b)
        {
            dynamic op1 = a;
            dynamic op2 = b;

            return (T)(op1 * op2);
        }
    }
}
