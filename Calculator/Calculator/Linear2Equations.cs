using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator{
    public partial class Linear2Equations : Form{
        public Linear2Equations(){
            InitializeComponent();
        }

        public void _2LinearEquations_Load(object sender, EventArgs e){

        }

        public void btnSolve_Click(object sender, EventArgs e){
            double[] result;
            try{
                result = btnSolve_Click(double.Parse(txtA1.Text),double.Parse(txtA2.Text),double.Parse(txtB1.Text),double.Parse(txtB2.Text),double.Parse(txtC1.Text),double.Parse(txtC2.Text));
            }
            catch (ArgumentException exception){
                lblNoSol.Text = exception.Message;
                return;
            }
            catch (Exception){
                lblNoSol.Text = "Math ERROR";
                return;
            }
            lblNoSol.Text = "Solutions";
            txtX.Text = result[0].ToString();
            txtY.Text = result[1].ToString();
        }

        public static double[] btnSolve_Click(double a1,double a2,double b1,double b2,double c1,double c2){
            double delta = a1*b2-a2*b1;
            if(delta==0){
                if(c1==a1/a2*c2)
                    throw new ArgumentException("Infinite Solutions...");
                else
                    throw new ArgumentException("No Solutions...");
            }
            return new double[]{(c1*b2-c2*b1)/delta, (a1*c2-a2*c1)/delta};
        }

        public void label1_Click(object sender, EventArgs e){

        }

        public void txtA1_Changed(object sender, EventArgs e){

        }

        public void txtB1_Changed(object sender, EventArgs e){

        }

        public void txtC1_Changed(object sender, EventArgs e){

        }

        public void txtA2_Changed(object sender, EventArgs e){

        }

        public void txtB2_Changed(object sender, EventArgs e){

        }

        public void txtC2_Changed(object sender, EventArgs e){

        }

        public void txtX_Changed(object sender, EventArgs e){

        }

        public void txtY_Changed(object sender, EventArgs e){

        }

        public void lblNoSol_Click(object sender, EventArgs e){

        }
    }
}
