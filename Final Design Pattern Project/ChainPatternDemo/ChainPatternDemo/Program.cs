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
    public class Program{
        private static AbstractLogger getChainOfLoggers(){
            AbstractLogger errorLogger = new ErrorLogger(AbstractLogger.ERROR);
            AbstractLogger fileLogger = new FileLogger(AbstractLogger.DEBUG);
            AbstractLogger consoleLogger = new ConsoleLogger(AbstractLogger.INFO);

            errorLogger.setNextLogger(fileLogger);
            fileLogger.setNextLogger(consoleLogger);

            return errorLogger;
        }
        public static void Main(){
            AbstractLogger loggerChain = getChainOfLoggers();

            loggerChain.logMessage(AbstractLogger.INFO, "This is an information.");
            loggerChain.logMessage(AbstractLogger.DEBUG, "This is an debug level information.");
            loggerChain.logMessage(AbstractLogger.ERROR, "This is an error information.");
        }
    }
}
