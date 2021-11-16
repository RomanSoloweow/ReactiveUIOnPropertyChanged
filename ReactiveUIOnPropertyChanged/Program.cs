using System;
using System.Diagnostics;
using ReactiveUI;

namespace ReactiveUIOnPropertyChanged
{
    class Program
    {
        static void Main(string[] args)
        {
            var vm = new MyViewModel();
            vm.WhenAnyValue(x => x.Value)
                .Subscribe(_ =>
                {
                    Debug.WriteLine($"Value changed");
                });
            
            vm.InitChanged();
            vm.InitChanged();
            vm.InitChanged();
        }
    }
}