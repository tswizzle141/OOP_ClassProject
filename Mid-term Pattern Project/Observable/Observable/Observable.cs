using System;

namespace DerivingObservable{
    interface IObservable<T>{ //raise notifications
        //passive
        void Subscribe(IObservable<T> observer); //keep a subscribed method on T 
        void UnSubscribe(IObservable<T> observer);
    }
    interface IObserver<T>{
        //active
        void OnNext(T value); //get the next value & notify observer
        void OnError(Exception ex); //error notification
        void OnCompleted(); //signal of completion
    }
}
