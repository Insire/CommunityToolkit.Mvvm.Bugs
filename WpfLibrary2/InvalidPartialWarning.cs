using CommunityToolkit.Mvvm.ComponentModel;

namespace WpfLibrary2
{
    public sealed class InvalidPartialWarning
    {
        private sealed partial class ViewModel : ObservableObject
        {
            [ObservableProperty]
            private object _property;
        }
    }
}
