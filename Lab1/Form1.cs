using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FunctionsParser;
using ZedGraph;
using static Lab1.Optimizer;
using System.Text.RegularExpressions;

namespace Lab1
{
    public partial class OptimisationMethods : Form
    {
        //x1^3+3x1*x2^2-15x1-12x2 - хорошая функция
        //x^3+3x*y^2-15x-12y - хорошая функция для многомерных методов кроме штрафных
        //x^2+6x+y^2+9y, штраф - 1/x+1/y, x_0 = (1;0,5)
        static Regex doubleTemplate = new Regex(@"^(\d+).(\d+)$");

        double a, b;
        FunctionParser parser;

        public OptimisationMethods()
        {
            InitializeComponent();
        }

        private void buttonBfind_Click(object sender, EventArgs e)
        {
            if (!CheckRange())
                return;

            double delta, epsilon;

            if (!double.TryParse(textBoxDelta.Text, out delta))
            {
                MessageBox.Show("Неверное значение δ!");
                return;
            }
            if (!double.TryParse(textBoxBepsilon.Text, out epsilon))
            {
                MessageBox.Show("Неверное значение ε!");
                return;
            }

            BuildGraph(parser.Evaluate, true, a, b, epsilon, 5);
            Optimizer opt = new Optimizer(parser);
            var result = opt.BisectionMethod(a, b, delta, epsilon);
            DrawPoint(result.Item1, result.Item2);
            textBoxMin.Text = $"{ result.Item1:F5}";
            textBoxFmin.Text = $"{ result.Item2:F5}";
        }

        private void buttonGSfind_Click(object sender, EventArgs e)
        {
            if (!CheckRange())
                return;

            double epsilon;

            if (!double.TryParse(textBoxGSepsilon.Text, out epsilon))
            {
                MessageBox.Show("Неверное значение ε!");
                return;
            }

            BuildGraph(parser.Evaluate, true, a, b, epsilon, 5);
            Optimizer opt = new Optimizer(parser);
            var result = opt.GoldenSectionMethod(a, b, epsilon);
            DrawPoint(result.Item1, result.Item2);
            textBoxMin.Text = $"{ result.Item1:F5}";
            textBoxFmin.Text = $"{ result.Item2:F5}";
        }

        private void buttonParabolas_Click(object sender, EventArgs e)
        {
            if (!CheckRange())
                return;

            double epsilon;

            if (!double.TryParse(textBoxPEpsilon.Text, out epsilon))
            {
                MessageBox.Show("Неверное значение ε!");
                return;
            }

            BuildGraph(parser.Evaluate, true, a, b, epsilon, 5);
            Optimizer opt = new Optimizer(parser);
            var result = opt.ParabolicMethod(a, b, epsilon);
            DrawPoint(result.Item1, result.Item2);
            textBoxMin.Text = $"{ result.Item1:F5}";
            textBoxFmin.Text = $"{ result.Item2:F5}";
        }

        bool CheckRange()
        {
            if (!double.TryParse(textBoxA.Text, out a))
            {
                MessageBox.Show("Неверное значение A!");
                return false;
            }

            if (!double.TryParse(textBoxB.Text, out b))
            {
                MessageBox.Show("Неверное значение B!");
                return false;
            }

            if (b <= a)
            {
                MessageBox.Show("B < A!");
                return false;
            }

            return true;
        }

        private void ParseExpression(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text != string.Empty)
                parser = new FunctionParser((sender as TextBox).Text);
        }

        void BuildGraph(Function f, bool ScaleAxes, double a, double b, double epsilon, int signs)
        {
            PointPairList list = new PointPairList();
            for (double i = a; Math.Round(b - i, 1) >= 0; i = Math.Round(i + epsilon, signs))
                list.Add(i, f(i));
            chart.GraphPane.CurveList.Clear();

            LineItem graphic = chart.GraphPane.AddCurve("График функции", list, Color.Blue, SymbolType.None);
            if (ScaleAxes)
                chart.AxisChange();
            chart.Invalidate();
        }

        private void tabPageMultidimantionalMethods_Enter(object sender, EventArgs e)
        {
            if (parser == null)
            {
                buttonNewtonsMethod.Enabled = buttonMillingStepsMethod.Enabled =
                    buttonSpeedestDescent.Enabled = false;
                return;
            }

            dataGridViewVariables.Rows.Clear();
            foreach (string key in parser.Variables)
                dataGridViewVariables.Rows.Add(key, "");
        }

        private void ReplacingDots(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            if (doubleTemplate.IsMatch(t.Text))
                t.Text = doubleTemplate.Replace(t.Text, "$1,$2");
        }

        private void NotImplementedButton(object sender, EventArgs e)
        {
            MessageBox.Show("Метод еще не реализован.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void buttonSingledimantionalNewtonsMethod_Click(object sender, EventArgs e)
        {
            double x, epsilon;
            if (!double.TryParse(textBoxNewtonEpsilon.Text, out epsilon))
            {
                MessageBox.Show("Неверное значение ε!");
                return;
            }

            if (!double.TryParse(textBoxNewtonsX.Text, out x))
            {
                MessageBox.Show("Неверное значение x_0!");
                return;
            }

            if (!CheckRange())
                return;

            BuildGraph(parser.Evaluate, true, a, b, epsilon, 5);

            MatrixNamespace.Matrix x_0 = new MatrixNamespace.Matrix(1, 5);
            x_0[0] = x;
            Optimizer opt = new Optimizer(parser);
            var result = opt.NewtonsMethod(x_0, epsilon);
            DrawPoint(result.Item1[0], result.Item2);
            textBoxMin.Text = $"{ result.Item1[0]:F5}";
            textBoxFmin.Text = $"{ result.Item2:F5}";
        }

        private void buttonNewtonsMethod_Click(object sender, EventArgs e)
        {
            double epsilon;
            if (!double.TryParse(textBoxEpsilonMultidimentional.Text, out epsilon))
            {
                MessageBox.Show("Неверное значение ε!");
                return;
            }

            int error;
            double[] variables;
            if (!TryGetMultidimentionalPoint(out variables, out error))
            {
                MessageBox.Show($"Неверное значение переменной в строке {error}!");
                return;
            }

            MatrixNamespace.Matrix x_0 = new MatrixNamespace.Matrix(variables.Count(), variables);
            Optimizer opt = new Optimizer(parser);
            Tuple<MatrixNamespace.Matrix, double> result;
            try
            {
                result = opt.NewtonsMethod(x_0, epsilon);
            }
            catch (MethodDivergencyException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            textBoxMultidimentionalX.Text = $"{ result.Item1:F5}";
            textBoxMultidimentionalFx.Text = $"{ result.Item2:F5}";
        }

        private void buttonSpeedestDescentMethod_Click(object sender, EventArgs e)
        {
            double epsilon;
            if (!double.TryParse(textBoxEpsilonMultidimentional.Text, out epsilon))
            {
                MessageBox.Show("Неверное значение ε!");
                return;
            }

            int error;
            double[] variables;
            if (!TryGetMultidimentionalPoint(out variables, out error))
            {
                MessageBox.Show($"Неверное значение переменной в строке {error}!");
                return;
            }

            string digits = Regex.Match(epsilon.ToString(), @"(?<=[,])\d+").Value;

            MatrixNamespace.Matrix x_0 = new MatrixNamespace.Matrix(variables.Count(), variables);
            Optimizer opt = new Optimizer(parser);
            Tuple<MatrixNamespace.Matrix, double> result;
            try
            {
                result = opt.SpeedestDescentMethod(x_0, epsilon);
            }
            catch (MethodDivergencyException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            textBoxMultidimentionalX.Text = $"{ result.Item1:F5}";
            textBoxMultidimentionalFx.Text = $"{ result.Item2:F5}";
        }

        bool TryGetMultidimentionalPoint(out double[] variables, out int errorLine)
        {
            variables = new double[dataGridViewVariables.Rows.Count];
            errorLine = -1;
            for (int i = 0; i < dataGridViewVariables.Rows.Count; ++i)
            {
                DataGridViewRow r = dataGridViewVariables.Rows[i];
                string text = (string)r.Cells["Value"].Value;
                if (doubleTemplate.IsMatch(text))
                    text = doubleTemplate.Replace(text, "$1,$2");

                if (!double.TryParse(text, out variables[i]))
                {
                    errorLine = i;
                    return false;
                }
            }

            return true;
        }

        private void buttonMillingStepsMethod_Click(object sender, EventArgs e)
        {
            double epsilon;
            if (!double.TryParse(textBoxEpsilonMultidimentional.Text, out epsilon))
            {
                MessageBox.Show("Неверное значение ε!");
                return;
            }

            int error;
            double[] variables;
            if (!TryGetMultidimentionalPoint(out variables, out error))
            {
                MessageBox.Show($"Неверное значение переменной в строке {error}!");
                return;
            }

            string digits = Regex.Match(epsilon.ToString(), @"(?<=[,])\d+").Value;

            MatrixNamespace.Matrix x_0 = new MatrixNamespace.Matrix(variables.Count(), variables);
            Optimizer opt = new Optimizer(parser);
            Tuple<MatrixNamespace.Matrix, double> result;
            try
            {
                result = opt.MillingStepMethod(x_0, epsilon);
            }
            catch (MethodDivergencyException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            textBoxMultidimentionalX.Text = $"{ result.Item1:F5}";
            textBoxMultidimentionalFx.Text = $"{ result.Item2:F5}";
        }

        private void buttonPenaltyMethod_Click(object sender, EventArgs e)
        {
            int error;
            double[] variables;
            if (!TryGetMultidimentionalPoint(out variables, out error))
            {
                MessageBox.Show($"Неверное значение переменной в строке {error}!");
                return;
            }
            MatrixNamespace.Matrix x_0 = new MatrixNamespace.Matrix(variables.Count(), variables);

            double epsilon;
            if (!double.TryParse(textBoxEpsilonMultidimentional.Text, out epsilon))
            {
                MessageBox.Show("Неверное значение ε!");
                return;
            }

            double c;
            if (!double.TryParse(textBoxC.Text, out c))
            {
                MessageBox.Show("Неверное значение c!");
                return;
            }

            FunctionParser penaltyFunc;
            try { penaltyFunc = new FunctionParser(textBoxPenaltyFunc.Text); }
            catch (Exception)
            {
                MessageBox.Show("Не удалось преобразовать строку в функцию, проверьте ввод.");
                return;
            }

            Optimizer opt = new Optimizer(parser);
            Tuple<MatrixNamespace.Matrix, double> result;
            try
            {
                result = opt.PenaltyMethod(x_0, penaltyFunc, epsilon, c);
            }
            catch (MethodDivergencyException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            textBoxMultidimentionalX.Text = $"{ result.Item1:F5}";
            textBoxMultidimentionalFx.Text = $"{ result.Item2:F5}";
        }

        void DrawPoint(double x, double y)
        {
            PointPairList list = new PointPairList { {x, y } };
            LineItem chord = chart.GraphPane.AddCurve("min", list, Color.Red, SymbolType.Circle);
            chord.IsLegendLabelVisible = false;
            //chart.AxisChange();
            chart.Invalidate();
        }
    }
}
