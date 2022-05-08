using CommunityToolkit.Mvvm.ComponentModel;

namespace WpfLibrary1
{
    public partial class ViewModel : ObservableObject
    {
        [ObservableProperty]
        private object _property;
    }
}
