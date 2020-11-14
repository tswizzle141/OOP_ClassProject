using System;
using EventBasedObserverDesignPattern;

namespace DerivingObservable{ 
    class Program{ 
        public static void Main(){
            var observable = new ObservableNumbers();

            //Action<int> action = n => Console.WriteLine(n);

            observable.Subscribe(n => Console.WriteLine(n));
            //observable.UnSubscribe(n => Console.WriteLine(n));

            /*
            Subscribe to the number sequence => Provide a lambda
            Unsubscribe => Provide the same lambda
            => MEMORY LEAK because lambdas/delegates are immutable => 2 methods 2 different delegates
            => UnSubscribe method is non-sense.
            => Need to be mitigated by client code (Action, IDisposable,...)
            */ 
        }
    }
}
