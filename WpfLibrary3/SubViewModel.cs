using CommunityToolkit.Mvvm.ComponentModel;

namespace WpfLibrary3
{
    public sealed partial class SubViewModel : WpfLibrary1.ViewModel
    {
        [ObservableProperty]
        private object _otherProperty;
    }

    [ObservableObject]
    internal sealed partial class ViewModel
    {
        [ObservableProperty]
        private object _property;
    }
}
