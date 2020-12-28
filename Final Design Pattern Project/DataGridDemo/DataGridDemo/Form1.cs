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
            table1.Rows.Add(rtbDecNum.Text, rtbBinNum.Text, rtbOctNum.Text, rtbHexNum.Text);
            dataGridView1.DataSource = table1;
        }

        private void btnUpdate_Clicked(object sender, EventArgs e){
            DataGridViewRow newDataRow = dataGridView1.Rows[idxRow];

            newDataRow.Cells[0].Value = rtbDecNum.Text;
            newDataRow.Cells[1].Value = rtbBinNum.Text;
            newDataRow.Cells[2].Value = rtbOctNum.Text;
            newDataRow.Cells[3].Value = rtbHexNum.Text;
        }

        private void btnDelete_Clicked(object sender, EventArgs e){
            int rowIdx = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIdx);
        }

        private void rtbDecNum_Changed(object sender, EventArgs e){

        }

        private void rtbBinNum_Changed(object sender, EventArgs e)
        {

        }

        private void rtbOct_Changed(object sender, EventArgs e)
        {

        }

        private void rtbHexNum_Changed(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e){
            table1.Columns.Add("Decimal Number", typeof(int));
            table1.Columns.Add("Binary Number", typeof(int));
            table1.Columns.Add("Octal Number", typeof(int));
            table1.Columns.Add("Hexa Number", typeof(string));

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e){
            int idxRow = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[idxRow];
            rtbDecNum.Text = selectedRow.Cells[0].Value.ToString();
            rtbBinNum.Text = selectedRow.Cells[1].Value.ToString();
            rtbOctNum.Text = selectedRow.Cells[2].Value.ToString();
            rtbHexNum.Text = selectedRow.Cells[3].Value.ToString();
        }
    }
}
