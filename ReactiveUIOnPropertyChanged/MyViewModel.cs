using System.Reactive.Disposables;
using DynamicData;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace ReactiveUIOnPropertyChanged
{
    public class MyViewModel:BaseViewModel
    {
        [Reactive] public int Value { get; set; }

        public void InitChanged()
        {
            this.RaisePropertyChanged(nameof(Value));
        }
    }
}