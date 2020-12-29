using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridDemo{
    public partial class Form1 : Form{
        DataTable table1 = new DataTable(); DataTable table2 = new DataTable();
        int idxRow, idxCol;
        System.Text.Encoding Encoder = System.Text.ASCIIEncoding.Default;

        public Form1(){
            InitializeComponent();
        }

        private void btnAdd_Clicked(object sender, EventArgs e){
            table1.Rows.Add(rtbProduct.Text, rtbVND.Text, rtbDollar.Text, rtbEuro.Text, rtbRMB.Text, rtbWon.Text);
            dataGridView1.DataSource = table1;
        }

        private void btnUpdate_Clicked(object sender, EventArgs e){
            DataGridViewRow newDataRow = dataGridView1.Rows[idxRow];

            newDataRow.Cells[0].Value = rtbProduct.Text;
            newDataRow.Cells[1].Value = rtbVND.Text;
            newDataRow.Cells[2].Value = rtbDollar.Text;
            newDataRow.Cells[3].Value = rtbEuro.Text;
            newDataRow.Cells[4].Value = rtbRMB.Text;
            newDataRow.Cells[5].Value = rtbWon.Text;
        }

        private void btnDelete_Clicked(object sender, EventArgs e){
            int rowIdx = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIdx);
        }

        private void Form1_Load(object sender, EventArgs e){
            table1.Columns.Add("Product", typeof(string));
            table1.Columns.Add("VND", typeof(double));
            table1.Columns.Add("Dollar", typeof(double));
            table1.Columns.Add("Euro", typeof(double));
            table1.Columns.Add("RMB", typeof(double));
            table1.Columns.Add("Won", typeof(double));

            dataGridView1.DataSource = table1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e){

        }

        private void btnExport_Clicked(object sender, EventArgs e){
            TextWriter w = new StreamWriter(@"C:\Users\tswizzle\source\repos\table2.txt");

            for(int i=0; i<dataGridView1.Rows.Count-1; i++){
                for(int j=0; j<dataGridView1.Columns.Count; j++){
                    w.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString());
                }
                w.WriteLine("");
            }
            w.Close();
            MessageBox.Show("Data Exported!");
        }

        private void rtbVND_Changed(object sender, EventArgs e){

        }

        private void rtbDollar_Changed(object sender, EventArgs e){

        }

        private void rtbEuro_Changed(object sender, EventArgs e){

        }

        private void rtbRMB_Changed(object sender, EventArgs e){

        }

        private void rtbWon_Changed(object sender, EventArgs e){

        }

        private void rtbProduct_Changed(object sender, EventArgs e){

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e){
            int idxRow = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[idxRow];

            rtbProduct.Text = selectedRow.Cells[0].Value.ToString();
            rtbVND.Text = selectedRow.Cells[1].Value.ToString();
            rtbDollar.Text = selectedRow.Cells[2].Value.ToString();
            rtbEuro.Text = selectedRow.Cells[3].Value.ToString();
            rtbRMB.Text = selectedRow.Cells[4].Value.ToString();
            rtbWon.Text = selectedRow.Cells[5].Value.ToString();
        }
    }
}
