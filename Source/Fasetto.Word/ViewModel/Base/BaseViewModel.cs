using PropertyChanged;
using System.ComponentModel;

namespace Fasetto.Word
{
    /// <summary>
    /// BaseViewModel that fires property changed events as needed
    /// </summary>
    [ImplementPropertyChanged]
    public class BaseViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// The event that gets fired when any child property changes its value
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

        /// <summary>
        /// Call this to fire a <see cref="PropertyChanged"/> event
        /// </summary>
        /// <param name="name"></param>
        public void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}