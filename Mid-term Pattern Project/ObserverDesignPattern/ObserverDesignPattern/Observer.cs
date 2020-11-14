using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern{
    abstract class Observer{ //Khoi tao lop ao Observer, truyen tham so de thong bao la string, moi khach hang deu thay thong bao
        public abstract void ObserverInfo(string info);

    }
}
