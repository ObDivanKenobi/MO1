using FunctionsParser;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab1
{
    class Optimizer
    {
        FunctionParser function;
        Func<double, double> f;

        public Optimizer(FunctionParser func)
        {
            function = func;
            f = function.Function;
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
            } while (Math.Abs(f(b) - f(a)) >= epsilon);

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

        bool IsConvex(double u1, double u2, double u3)
        {
            double delta_minus = f(u1) - f(u2),
                   delta_plus = f(u3) - f(u2);
            return delta_minus >= 0 && delta_plus >= 0 && delta_plus + delta_minus > 0;
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
                for (int i = 2; !found; ++i)
                {
                    double u_i = u[i - 1] + mult * h;
                    if (u_i > b || u_i < a) break;
                    u.Add(u_i);
                    I.Add(f(u[i]));
                    found = IsConvex(u[i - 2], u[i - 1], u[i]);
                }

                double w;
                if (found)
                {
                    w = 0;//искать параболу
                }
                else
                {
                    double u_n = u[u.Count - 1];
                    w = b - u_n > u_n - a ? a : b;
                }

                I.Add(f(w));
                double f_min = I.AsQueryable().Min();
                min = u[I.IndexOf(f_min)];
            } while (h > epsilon);

            return new Tuple<double, double>(min, f(min));
        }
    }
}
