using System;
using System.Collections.Generic;
using System.Text;

namespace IObservableImplementation{
    internal class MyObserver<T> : IObserver<T>{
        private string _name = null;

        public MyObserver(string subscriberName = "SUBSCRIBER"){
            _name = subscriberName;
        }
        public virtual void OnCompleted(){
            Console.WriteLine($"Observation completed by {_name}...");
        }
        public virtual void OnError(Exception error){
            Console.WriteLine($"Error occured when {_name} observing: {error.Message}.");
        }
        public virtual void OnNext(T value){
            Console.WriteLine($"{_name} received: {value.ToString()}");
        }
    }
}
