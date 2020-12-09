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

namespace Calculator{
    public partial class NegativeCalculation : Form{
        public NegativeCalculation(){
            InitializeComponent();
        }

        private void rtxtBoxa1_Changed(object sender, EventArgs e){

        }

        private void rtxtBoxb1_Changed(object sender, EventArgs e){

        }

        private void btnSolve1_Click(object sender, EventArgs e){
            double result1;
            result1 = btnSolve1_Click(double.Parse(rtxtBoxa1.Text),double.Parse(rtxtBoxb1.Text));
            rtxtBoxc1.Text = System.Convert.ToString(result1);
        }

        private double btnSolve1_Click(double v1, double v2){
            return (v1+v2);
        }

        private void rtxtBoxa2_Changed(object sender, EventArgs e){

        }

        private void rtxtBoxb2_Changed(object sender, EventArgs e){

        }

        private void btnSolve2_Click(object sender, EventArgs e){
            double result2;
            result2 = btnSolve2_Click(double.Parse(rtxtBoxa2.Text), double.Parse(rtxtBoxb2.Text));
            rtxtBoxc2.Text = System.Convert.ToString(result2);
        }

        private double btnSolve2_Click(double v1, double v2){
            return (v1 - v2);
        }

        private void rtxtBoxa3_Changed(object sender, EventArgs e){

        }

        private void rtxtBoxb3_Changed(object sender, EventArgs e){

        }

        private void rtxtBoxa4_Changed(object sender, EventArgs e){

        }

        private void rtxtBoxb4_Changed(object sender, EventArgs e){

        }

        private void btnSolve3_Click(object sender, EventArgs e){
            double result3;
            result3 = btnSolve3_Click(double.Parse(rtxtBoxa3.Text), double.Parse(rtxtBoxb3.Text));
            rtxtBoxc3.Text = System.Convert.ToString(result3);
        }

        private double btnSolve3_Click(double v1, double v2){
            return (v1*v2);
        }

        private void btnSolve4_Click(object sender, EventArgs e){
            double result4;
            result4 = btnSolve4_Click(double.Parse(rtxtBoxa4.Text), double.Parse(rtxtBoxb4.Text));
            rtxtBoxc4.Text = System.Convert.ToString(result4);
        }

        private double btnSolve4_Click(double v1, double v2){
            return (v1/v2);
        }
    }
}
