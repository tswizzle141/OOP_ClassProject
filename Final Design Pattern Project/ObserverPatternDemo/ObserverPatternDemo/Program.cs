using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ObserverPatternDemo{
    public class Program{
        public static void Main(){
            Subject subject = new Subject();

            new HexaObserver(subject);
            new OctalObserver(subject);
            new BinaryObserver(subject);

            Console.WriteLine("First state change: 15"); subject.setState(15);
            Console.WriteLine("Second state change: 10"); subject.setState(10);
        }
    }
}
