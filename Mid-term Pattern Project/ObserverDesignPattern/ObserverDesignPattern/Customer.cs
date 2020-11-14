using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverDesignPattern
{
    class Customer : Observer{ //Ke thua Observer
        //Lop Thong tin Khach hang
        private string name; //Ten Khach hang
        public string Name{ //Ten Khach hang
            get{return name;}
            set{name = value;}
        }

        private string phoneNumber; //SDT
        public string PhoneNumber{ //SDT
            get{return phoneNumber;}
            set{phoneNumber = value;}
        }
        public override void ObserverInfo(string info){
            //Thong bao message cho Khach hang
            //Ke thua tu Observer
            MessageBox.Show("Thông báo tới Khách hàng: " + Name + " có SĐT: " + PhoneNumber + "\nThông tin Sản phẩm mới: " + info);
        }
        public Customer(string name,string phone){ //ham khoi tao
            this.Name = name; this.PhoneNumber = phone;
        }
    }
}
