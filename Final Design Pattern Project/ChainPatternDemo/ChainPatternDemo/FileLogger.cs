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

namespace ChainPatternDemo{
    public class FileLogger : AbstractLogger{
        public FileLogger(int level){
            this.level = level;
        }
        protected override void Write(String message){
            Console.WriteLine("File::Logger: " + message);
        }
    }
}
