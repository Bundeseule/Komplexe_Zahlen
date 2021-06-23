using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Komplexe_Zahlen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bSchliessen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bPlus_Click(object sender, EventArgs e)
        {
            ComplexNumbers cVar1, cVar2, cErg;
            cVar1 = new ComplexNumbers();
            cVar2 = new ComplexNumbers();
            cErg = new ComplexNumbers();

            cVar1.re = double.Parse(tbRe1.Text);
            cVar1.im = double.Parse(tbIm1.Text);

            cVar2.re = double.Parse(tbRe2.Text);
            cVar2.im = double.Parse(tbIm2.Text);

            cVar1.Addition(cVar2.re, cVar2.im, out cErg.re, out cErg.im);

            lErg.Text = String.Format("re= {0}    im={1}", cErg.re, cErg.im);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
    public class ComplexNumbers
    {
        public double re, im;

        public ComplexNumbers()
        {
            re = 0.0;
            im = 0.0;
        }

        public void Addition(double re1, double im1, out double reErg, out double imErg)
        {
            reErg = re + re1;
            imErg = im + im1;
        }
    }
}
