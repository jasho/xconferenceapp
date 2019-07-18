using System.ComponentModel;
using System.Runtime.CompilerServices;
using XConferenceApp.Models.Interfaces;

namespace XConferenceApp.Models
{
    public abstract class ModelBase<TKey> : IModel<TKey>, INotifyPropertyChanged
    {
        public TKey Id { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}