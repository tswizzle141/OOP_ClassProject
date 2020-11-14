using System;

namespace EventBasedObserverDesignPattern{ 
    interface IObservable<T>{ //raise notifications
        //passive
        void Subscribe(Action<T> action); //keep a subscribed method on T 
        void UnSubscribe(Action<T> action);
    }
    class ObservableNumbers : IObservable<int>{
        //active
        private event Action<int> _action = null;
        public void Subscribe(Action<int> action){
            _action += action;
        }
        public void UnSubscribe(Action<int> action){
            _action -= action;
        }
    }
}
