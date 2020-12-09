using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using MathNet.Numerics;


namespace Calculator
{
    public partial class CubicEquation : Form{
        public CubicEquation(){
            InitializeComponent();
        }

        private void CubicEquation_Load(object sender, EventArgs e){

        }

        private void btnSolve_Click(object sender, EventArgs e){
            Complex[] result;
            try{
                result = btnSolve_Click(double.Parse(rtxtBoxA.Text),double.Parse(rtxtBoxB.Text),double.Parse(rtxtBoxC.Text),double.Parse(rtxtBoxD.Text));
            }
            catch (Exception){
                lblNoSol.Text = "Math ERROR";
                return;
            }
            lblNoSol.Text = "Solutions";

            rtxtBoxX1.Text = Format.ComplexNumber(result[0]);
            rtxtBoxX2.Text = Format.ComplexNumber(result[1]);
            rtxtBoxX3.Text = Format.ComplexNumber(result[2]);
        }

        private Complex[] btnSolve_Click(double a3, double a2, double a1, double a0){
            if(a3 == 0) throw new InvalidOperationException("Not Cubic Equation...");

            var a = (Complex)a3; var b = (Complex)a2; var c = (Complex)a1; var d = (Complex)a0;

            var roots = FindRoots.Cubic(a0,a1,a2,a3);
            Complex root1 = roots.Item1;
            Complex root2 = roots.Item2;
            Complex root3 = roots.Item3;

            return new Complex[]{root1,root2,root3};
            
        }

        private void rtxtBoxA_Changed(object sender, EventArgs e){

        }

        private void rtxtBoxB_Changed(object sender, EventArgs e){

        }

        private void rtxtBoxC_Changed(object sender, EventArgs e){

        }

        private void rtxtBoxD_Changed(object sender, EventArgs e){

        }
    }
}
