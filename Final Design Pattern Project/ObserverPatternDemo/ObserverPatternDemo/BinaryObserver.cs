using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ObserverPatternDemo{
    public class BinaryObserver : Observer{
        public BinaryObserver(Subject subject){
            this.subject = subject;
            this.subject.Attach(this);
        }
        public override void Update(){
            Console.WriteLine("Binary String: " + Convert.ToString(subject.getState(),2));
        }
    }
}
