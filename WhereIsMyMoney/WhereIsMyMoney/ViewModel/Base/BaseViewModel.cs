using System.ComponentModel;

namespace WhereIsMyMoney.ViewModel
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => {};
    }
}
