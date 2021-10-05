using System.ComponentModel;
using System.Runtime.CompilerServices;
using Behavioral.Observer.Annotations;

namespace Behavioral.Observer.BidirectionalObserver
{
    public class Window : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string _productName;

        public string ProductName
        {
            get => _productName;
            set
            {
                if (value == _productName) return;
                _productName = value;
                OnPropertyChanged();
            }
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public override string ToString()
        {
            return $"Window : {ProductName}";
        }
    }
}