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
    public partial class Form1 : Form{
        double result = 0, num1, num2;
        string operation = "";
        bool enter_value = false;
        private double memory;
        private bool memFlag;
        Dictionary<string, double> variables = new Dictionary<string, double>(){
            { "x", 0 }
        };

        public Form1(){
            InitializeComponent();
            btnMC.Enabled = false;
            btnMR.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e){ //Change number's signal to + or -
            num2 = double.Parse(textBox1.Text);
            num2 *= -1;
            textBox1.Text = System.Convert.ToString(num2);
        }

        private void textBox1_TextChanged(object sender, EventArgs e){ //mainTextBox

        }

        private void Form1_Load(object sender, EventArgs e){

        }

        private void button_Click(object sender, EventArgs e){ //main TextBox
            if((textBox1.Text == "0") || (enter_value) || memFlag == true){
                textBox1.Text = "";
                enter_value = false; memFlag = false;
            }
            enter_value = false;

            Button num = (Button)sender;
            if(num.Text == "."){
                if(!textBox1.Text.Contains("."))
                    textBox1.Text += num.Text;
            }
            else
                textBox1.Text += num.Text;
        }

        private void button5_Click(object sender, EventArgs e){ //btnCE clear the last number
            textBox1.Text = "0";
            label1.Text = "";
            string f, s;

            s = Convert.ToString(num2);
            f = Convert.ToString(num1);

            s = ""; f = "";
        }

        private void button6_Click(object sender, EventArgs e){ //btnAC clear all memory
            textBox1.Text = "0";
            label1.Text = "";
        }

        private void button7_Click(object sender, EventArgs e){ //btnDelete
            if (textBox1.Text.Length > 0)
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1,1);

            if (textBox1.Text == "")
                textBox1.Text = "0";
        }

        private void btnSqrt_Click(object sender, EventArgs e){ //square root
            double sq = double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("sqrt" + "(" + textBox1.Text + ")");
            sq = Math.Sqrt(sq);
            textBox1.Text = System.Convert.ToString(sq);
        }

        private void label1_Click(object sender, EventArgs e){

        }

        private void btnLog_Click(object sender, EventArgs e){ //log10
            double ilog = double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("log" + "(" + textBox1.Text + ")");
            ilog = Math.Log10(ilog);
            textBox1.Text = System.Convert.ToString(ilog);
        }

        private void btnSin_Click(object sender, EventArgs e){ //sin
            double b_sin = double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("sin" + "(" + textBox1.Text + ")");
            b_sin = Math.Sin(b_sin);
            textBox1.Text = System.Convert.ToString(b_sin);
        }

        private void btnCos_Click(object sender, EventArgs e){ //cos
            double b_cos = double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("cos" + "(" + textBox1.Text + ")");
            b_cos = Math.Cos(b_cos);
            textBox1.Text = System.Convert.ToString(b_cos);
        }

        private void btnTan_Click(object sender, EventArgs e){ //tan
            double b_tan = double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("tan" + "(" + textBox1.Text + ")");
            b_tan = Math.Tan(b_tan);
            textBox1.Text = System.Convert.ToString(b_tan);
        }

        private void btnLn_Click(object sender, EventArgs e){ //ln
            double iln = double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("ln" + "(" + textBox1.Text + ")");
            iln = Math.Log(iln);
            textBox1.Text = System.Convert.ToString(iln);
        }

        private void btnSquare_Click(object sender, EventArgs e){ //square
            double a;
            a = Convert.ToDouble(textBox1.Text);
            label1.Text = System.Convert.ToString("square" + "(" + textBox1.Text + ")");
            a = Math.Pow(a, 2);
            textBox1.Text = System.Convert.ToString(a);
        }

        private void btnCube_Click(object sender, EventArgs e){ //cube
            double a;
            a = Convert.ToDouble(textBox1.Text);
            label1.Text = System.Convert.ToString("cube" + "(" + textBox1.Text + ")");
            a = Math.Pow(a, 3);
            textBox1.Text = System.Convert.ToString(a);
        }

        private void btnOption_Click(object sender, EventArgs e){ //option to solve kinds of equations
            (new OptionDisplay()).Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e){ //Result Textbox
          
        }

        private void btnMR_Click(object sender, EventArgs e){ //Memory Read
            textBox1.Text = memory.ToString();
            memFlag = true;
        }

        private void btnMC_Click(object sender, EventArgs e){ //Memory Clear
            textBox1.Text = "0"; memory = 0;
            btnMR.Enabled = false; btnMC.Enabled = false;
        }

        private void btnMAdd_Click(object sender, EventArgs e){ //M+
            label1.Text = System.Convert.ToString(memory + "M+" + textBox1.Text);
            num2 = memory + double.Parse(textBox1.Text);
            textBox2.Text = System.Convert.ToString(num2);
        }

        private void btnMSubt_Click(object sender, EventArgs e){ //M-
            label1.Text = System.Convert.ToString(memory + "M-" + textBox1.Text);
            num2 = memory - double.Parse(textBox1.Text);
            textBox2.Text = System.Convert.ToString(num2);
        }

        private void btnMS_Click(object sender, EventArgs e){ //Memory Save
            memory = double.Parse(textBox1.Text);
            btnMC.Enabled = true; btnMR.Enabled = true;
            memFlag = true;
            label1.Text = System.Convert.ToString("MS+" + memory);
        }

        private void btnPaint_Click(object sender, EventArgs e){ //Cubic Graphic Draw
            (new GraphicPaint()).Show();
        }

        private void Operators_Click(object sender, EventArgs e){ //operators
            Button num = (Button)sender;
            operation = num.Text;
            result = double.Parse(textBox1.Text);
            num1 = double.Parse(textBox1.Text);
            textBox1.Text = "";
            label1.Text = System.Convert.ToString(result) + " " + operation;
        }

        private void button2_Click(object sender, EventArgs e){ //Equal
            try{
                textBox2.Text = StringEvaluater.Eval(textBox1.Text, variables).ToString();
            }
            catch (Exception){
                textBox2.Text = "Math ERROR...";
            }
        }
    }
}
