using System;
using System.Reactive;

namespace IObservableImplementation{
    class Program{
        public static void Main(){
            Console.WriteLine("Press any key to exit program");
            Console.ReadLine();
        }
        public static void Demo(){
            var observable = new MyObservableRange(5, 10);
            var observer = new MyObserver<int>();
            var subscription = observable.Subscribe(observer);

            Console.WriteLine("Press any key to dispose the subscription");
            Console.ReadLine();
            subscription.Dispose();
        }
        /*
        public static void ObserverNoContractViolation(){
            var observable = new MyObservableRange(5, 10);
            var observer = Observer.Create<int>(Console.WriteLine,
                ex => Console.WriteLine(ex.Message),
                () => Console.WriteLine("Completed..."));
            var subscription = observable.Subscribe(observer);

            Console.WriteLine("Press any key to dispose the subscription");
            Console.ReadLine();
            subscription.Dispose();
        }
        */
    }
}
