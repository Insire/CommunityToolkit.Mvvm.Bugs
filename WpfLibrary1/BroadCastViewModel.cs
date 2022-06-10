using CommunityToolkit.Mvvm.ComponentModel;

namespace WpfLibrary1
{
    [ObservableRecipient]
    internal sealed partial class BroadCastViewModel : ObservableObject
    {
        [NotifyPropertyChangedRecipients]
        [ObservableProperty]
        private object _property;
    }
}
