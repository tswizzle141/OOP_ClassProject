using System;

namespace IObservableImplementation
{
    class MyObservableRange : IObservable<int>{
        private int _start, _count;
        public MyObservableRange(int start, int count){
            _start = start; _count = count;
        }
        public IDisposable Subscribe(IObserver<int> observer){
            try{
                //observer.OnError(new Exception("Oops!"));

                for (int i = _start; i < _start + _count; i++)
                {
                    //observer.OnCompleted();
                    observer.OnNext(i);
                }
                observer.OnCompleted();
                return new MyDisposable();
            }
            catch(Exception ex){
                observer.OnError(ex);
                return new MyDisposable();
            }
        }
    }
}
