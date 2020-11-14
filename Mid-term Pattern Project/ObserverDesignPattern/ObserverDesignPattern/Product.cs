using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverDesignPattern{
    class Product : Observer{
        //Quan ly Thong tin San pham

        private string name; //Ten Khach hang
        public string Name{ //Ten Khach hang
            get{return name;}
            set{name = value;}
        }

        //Danh sach Khach hang muon nhan thong tin san pham
        private List<Customer> customerList = new List<Customer>();
        public void AddCustomer(Customer cus){
            if(cus != null){
                customerList.Add(cus);
            }
        }
        public void RemoveCustomer(Customer cus){
            if (cus != null){
                customerList.Remove(cus);
            }
        }
        public override void ObserverInfo(string info){
            //Thong bao message cho Khach hang
            //Ke thua tu Observer
            //MessageBox.Show(info);
            foreach(Customer item in customerList){
                if(item!=null){
                    item.ObserverInfo(Name);
                }
            }
        }
        public Product(string name){ //ham khoi tao
            this.Name = name;
        }
    }
}
