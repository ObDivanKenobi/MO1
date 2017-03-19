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

            Optimizer opt = new Optimizer(new FunctionParser(textBoxFunc.Text));
            var result = opt.BisectionMethod(a, b, delta, epsilon);
            textBoxMin.Text = result.Item1.ToString();
            textBoxFmin.Text = result.Item1.ToString();
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

            Optimizer opt = new Optimizer(new FunctionParser(textBoxFunc.Text));
            var result = opt.GoldenSectionMethod(a, b, epsilon);
            textBoxMin.Text = result.Item1.ToString();
            textBoxFmin.Text = result.Item1.ToString();
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

            Optimizer opt = new Optimizer(new FunctionParser(textBoxFunc.Text));
            var result = opt.ParabolicMethod(a, b, epsilon);
            textBoxMin.Text = result.Item1.ToString();
            textBoxFmin.Text = result.Item1.ToString();
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
    }
}
