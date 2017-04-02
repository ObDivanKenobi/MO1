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

namespace Lab1
{
    public partial class OptimisationMethods : Form
    {
        double a, b;

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

            FunctionParser parser = new FunctionParser(textBoxFunc.Text);
            BuildGraph(parser.Function, true, a, b, epsilon, 5);
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

            FunctionParser parser = new FunctionParser(textBoxFunc.Text);
            BuildGraph(parser.Function, true, a, b, epsilon, 5);
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

            FunctionParser parser = new FunctionParser(textBoxFunc.Text);
            BuildGraph(parser.Function, true, a, b, epsilon, 5);
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

        void BuildGraph(Func<double, double> f, bool ScaleAxes, double a, double b, double epsilon, int signs)
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
