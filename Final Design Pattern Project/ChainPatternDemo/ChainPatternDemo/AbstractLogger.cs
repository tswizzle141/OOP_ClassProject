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
    public abstract class AbstractLogger{
        public static int INFO = 1, DEBUG = 2, ERROR = 3;
        protected int level;

        protected AbstractLogger nextLogger; //next element in chain or responsibility

        public void setNextLogger(AbstractLogger nextLogger){
            this.nextLogger = nextLogger;
        }
        public void logMessage(int level, String message){
            if (this.level <= level) Write(message);
            if (nextLogger != null) nextLogger.logMessage(level, message);
        }
        abstract protected void Write(String message);
    }
}
