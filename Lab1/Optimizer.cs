using FunctionsParser;
using System;
using System.Collections.Generic;
using System.Linq;
using MatrixNamespace;
using System.Text.RegularExpressions;
using System.Runtime.Serialization;

namespace Lab1
{
    class Optimizer
    {
        public delegate double Function(params double[] variables);
        FunctionParser function;
        Function f;

        public Optimizer(FunctionParser func)
        {
            function = func;
            f = function.Evaluate;
        }

        public Tuple<double, double> BisectionMethod(double a, double b, double delta, double epsilon)
        {
            do
            {
                double u1 = (b + a - delta) / 2,
                       u2 = (b + a + delta) / 2,
                       f1 = f(u1),
                       f2 = f(u2);

                if (double.IsInfinity(f1) || double.IsInfinity(f2) || double.IsNaN(f1) || double.IsNaN(f2))
                    throw new ArgumentException("Выход за область допустимых значений.");

                if (f1 < f2)
                    b = u2;
                else if (f1 > f2)
                    a = u1;
                else
                {
                    b = u2;
                    a = u1;
                }

            } while (Math.Abs(b - a - delta) > epsilon);

            double u = (b + a) / 2;
            return new Tuple<double, double>(u, f(u));
        }

        public Tuple<double, double> GoldenSectionMethod(double a, double b, double epsilon)
        {
            double phi = (Math.Sqrt(5) - 1) / 2,
                   phi_1 = (3 - Math.Sqrt(5)) / 2,
                   u1 = a + phi_1 * (b - a),
                   u2 = a + phi * (b - a);
            do
            {
                double f1 = f(u1),
                       f2 = f(u2);

                if (f1 < f2)
                {
                    b = u2;
                    u2 = u1;
                    u1 = a + phi_1 * (b - a);
                }
                else if (f1 > f2)
                {
                    a = u1;
                    u1 = u2;
                    u2 = a + phi * (b - a);
                }
                else
                {
                    b = u2;
                    a = u1;
                    u1 = a + phi_1 * (b - a);
                    u2 = a + phi * (b - a);
                }
            } while (b - a > epsilon);

            double u = (b + a) / 2;
            return new Tuple<double, double>(u, f(u));
        }

        bool IsConvex(double u1, double u2, double u3, out double w)
        {
            w = double.NaN;
            double delta_minus = f(u1) - f(u2),
                   delta_plus = f(u3) - f(u2);
            if (delta_minus >= 0 && delta_plus >= 0 && delta_plus + delta_minus > 0)
            {
                w = u2 +
                    (Math.Pow((u3 - u2), 2) * delta_minus - Math.Pow((u2 - u1), 2) * delta_plus)
                    /
                    (2 * ((u3 - u2) * delta_minus + (u2 - u1) * delta_plus));
                return true;
            }
            return false;
        }

        public Tuple<double, double> ParabolicMethod(double a, double b, double epsilon)
        {
            double h = b - a,
                   min;
            do
            {
                h /= 2;
                List<double> u = new List<double>(), I = new List<double>();
                int mult = 1;
                u.Add((Math.Abs(b) - Math.Abs(a)) / 2);
                I.Add(f(u[0]));
                u.Add(u[0] + h);
                I.Add(f(u[1]));
                if (I[1] > I[0])
                {
                    u[1] = u[0] - h;
                    I[1] = f(u[1]);
                    mult = -1;
                }
                bool found = false;
                double w = double.NaN;
                for (int i = 2; !found; ++i)
                {
                    double u_i = u[i - 1] + mult * h;
                    if (u_i > b || u_i < a) break;
                    u.Add(u_i);
                    I.Add(f(u[i]));
                    found = IsConvex(u[i - 2], u[i - 1], u[i], out w);
                }

                if (!found)
                {
                    double u_n = u[u.Count - 1];
                    w = b - u_n > u_n - a ? a : b;
                    u.Add(w);
                    I.Add(f(w));
                    double f_min = I.AsQueryable().Min();
                    int index = I.IndexOf(f_min);
                    min = u[index];
                }
                else
                    min = w;
            } while (h > epsilon);

            return new Tuple<double, double>(min, f(min));
        }

        public Tuple<Matrix, double> NewtonsMethod(Matrix x0, double eps, double a = 1, int steps = 100)
        {
            int n = function.Variables.Count;
            FunctionParser[] gradFunctional = new FunctionParser[n];
            for (int i = 0; i < n; ++i)
                gradFunctional[i] = function.DifferentiateBy(function.Variables[i]);//.Optimize();

            FunctionParser[,] HessianFunctional = new FunctionParser[n, n];
            for (int i = 0; i < n; ++i)
                for (int j = i; j < n; ++j)
                {
                    FunctionParser tmp = function.DifferentiateBy(function.Variables[i]);
                    tmp = tmp.DifferentiateBy(function.Variables[j]);
                    tmp = tmp.Optimize();
                    HessianFunctional[i, j] = HessianFunctional[j, i] = tmp; //function.DifferentiateBy(function.Variables[i]).DifferentiateBy(function.Variables[j]).Optimize();
                }

            Matrix x = (Matrix)x0.Clone(),
                   grad = CountGrad(x, gradFunctional),
                   HessianMatrix;

            int step = steps;
            while (Norm(grad) >= eps && step-- > 0)
            {
                HessianMatrix = CountHessian(x, HessianFunctional);

                Matrix invertedH;
                if (!HessianMatrix.TryInvert(out invertedH))
                    throw new ArgumentException("Ошибка в поиске обратной матрицы!");

                Matrix a_grad = a * grad,
                       mult = a_grad * invertedH;

                x = x - mult;

                grad = CountGrad(x, gradFunctional);
            }

            if (step < 0)
                throw new MethodDivergencyException($"Методу не удалось найти решение за {steps} шагов.");

            return new Tuple<Matrix, double>(x, f(x.ToVector()));
        }

        public Tuple<Matrix, double> MillingStepMethod(Matrix x0, double epsilon, double a = 1, int steps = 100)
        {
            int n = function.Variables.Count;
            //заполняем градиент
            FunctionParser[] gradFunctional = new FunctionParser[n];
            for (int i = 0; i < n; ++i)
                gradFunctional[i] = function.DifferentiateBy(function.Variables[i]).Optimize();

            //вычисляем градиент в точке x_0
            Matrix x = (Matrix)x0.Clone(),
                   grad = CountGrad(x, gradFunctional);
            double f_x = f(x0.ToVector());

            int step = steps;
            //пока ||grad f(x_0)|| >= e
            while (Norm(grad) >= epsilon && step-- > 0)
            {
                Matrix tmp = x - (a * grad);
                double f_tmp = f(tmp.ToVector());
                while (f_tmp >= f_x)
                {
                    if (a == 0)
                        throw new MethodDivergencyException("Метод расходится!");

                    a = a / 2;
                    tmp = x - (a * grad);
                    f_tmp = f(tmp.ToVector());
                }

                x = tmp;
                f_x = f_tmp;
                grad = CountGrad(x, gradFunctional);
            }

            if (step < 0)
                throw new MethodDivergencyException($"Методу не удалось найти решение за {steps} шагов.");

            return new Tuple<Matrix, double>(x, f(x.ToVector()));
        }

        public Tuple<Matrix, double> SpeedestDescentMethod(Matrix x0, double epsilon, double a = 1, int steps = 100)
        {
            int n = function.Variables.Count,
                accuracy = 10;// Regex.Match(epsilon.ToString(), @"(?<=[,])\d+").Value.Count();
            //заполняем градиент
            FunctionParser[] gradFunctional = new FunctionParser[n];
            for (int i = 0; i < n; ++i)
                gradFunctional[i] = function.DifferentiateBy(function.Variables[i]).Optimize();

            //вычисляем градиент в точке x_0
            Matrix x = (Matrix)x0.Clone(),
                   grad = CountGrad(x, gradFunctional);

            int step = steps;
            //пока ||grad f(x_0)|| >= e
            while (Norm(grad) >= epsilon && step-- > 0)
            {
                string func = function.ToString();
                //заменяем цифры в скобках просто цифрами
                func = Regex.Replace(func, @"[(](\d+)[)]", "$1");
                //заменяем переменные x_i на x_i - x * grad_i, чтобы получить функцию одной переменной x
                for (int i = 0; i < function.Variables.Count; ++i)
                {
                    string replacedVariable = function.Variables[i],
                           //replacement = grad[i] > 0 ? $"{Math.Round(x[i], accuracy)}-{Math.Round(grad[i], accuracy)}a" : $"{Math.Round(x[i], accuracy)}+{Math.Abs(Math.Round(grad[i], accuracy))}a";
                           replacement = grad[i] > 0 ? $"{x[i]:f10}-{grad[i]:f10}a" : $"{x[i]:f10}+{Math.Abs(grad[i]):f10}a";

                    func = Regex.Replace(func, $@"(?<=[(]){replacedVariable}(?=[)])", replacement);
                    func = Regex.Replace(func, replacedVariable, $"({replacement})");
                }

                FunctionParser Ф = new FunctionParser(func);
                Matrix A = new Matrix(1);
                A[0] = a;
                Optimizer support = new Optimizer(Ф);
                var min = support.NewtonsMethod(A, epsilon);

                x = x - min.Item1[0] * grad;
                grad = CountGrad(x, gradFunctional);
            }

            if (step < 0)
                throw new MethodDivergencyException($"Методу не удалось найти решение за {steps} шагов.");

            return new Tuple<Matrix, double>(x, f(x.ToVector()));
        }

        public Tuple<Matrix, double> PenaltyMethod(Matrix x0, FunctionParser PenaltyFunc, double epsilon, double c)
        {
            double r = 1;
            Matrix min = (Matrix)x0.Clone();

            do
            {
                FunctionParser P = function + (r * PenaltyFunc);
                Optimizer tmp = new Optimizer(P);
                try
                {
                    min = tmp.SpeedestDescentMethod(min, epsilon).Item1;
                }
                catch (MethodDivergencyException)
                {
                    throw new MethodDivergencyException("Метод расходится!");
                }

                r = r / c;
            } while (r > epsilon );

            return new Tuple<Matrix, double>(min, f(min.ToVector()));
        }

        //unsafe
        Matrix CountGrad(Matrix x, FunctionParser[] gradFunctional)
        {
            Matrix grad = new Matrix(1, x.N, 5);
            for (int i = 0; i < x.N; ++i)
            {
                double x_i = gradFunctional[i].Evaluate(x.ToVector());
                grad[i] = x_i;
            }

            return grad;
        }

        //unsafe
        Matrix CountHessian(Matrix x, FunctionParser[,] HessianFunctional)
        {
            Matrix Hessian = new Matrix(x.N);
            for (int i = 0; i < x.N; ++i)
                for (int j = i; j < x.N; ++j)
                {
                    double value = HessianFunctional[i, j].Evaluate(x.ToVector());
                    Hessian[i, j] = Hessian[j, i] = value;
                }

            return Hessian;
        }

        //unsafe
        double Norm(Matrix x)
        {
            double norm = 0;
            for (int i = 0; i < x.N; ++i)
                norm += Math.Pow(x[i], 2);

            return Math.Sqrt(norm);
        }
    }

    [Serializable]
    public class MethodDivergencyException : Exception
    {
        public MethodDivergencyException() { }

        public MethodDivergencyException(string message) : base(message) { }

        public MethodDivergencyException(string message, Exception inner) : base(message, inner) { }

        protected MethodDivergencyException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}