using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverDesignPattern
{
    public partial class Form1 : Form{
        public Form1(){
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e){
            Product sp = new Product("eFootball PES 2020");

            Customer cus1 = new Customer("Nhâm Đỗ Hải Ninh","0969653116");
            Customer cus2 = new Customer("Trần Anh Tuấn","0869640814");
            Customer cus3 = new Customer("Nguyễn Sỹ Đạt", "0969147692");

            sp.AddCustomer(cus1); sp.AddCustomer(cus2); sp.AddCustomer(cus3);
            sp.ObserverInfo("Sản phẩm phục vụ đá PES version mới nhất!");
        }
    }
}
