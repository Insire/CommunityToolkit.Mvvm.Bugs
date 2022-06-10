using CommunityToolkit.Mvvm.ComponentModel;

namespace WpfApp1
{
    /// <summary>
    /// I should get notified about the missing [ObservableRecipient] attribute on the class before compiling
    /// </summary>
    public sealed partial class NotifyPropertyChangedRecipientsMissingAnalyzerWarning : ObservableValidator
    {
        [ObservableProperty]
        [NotifyPropertyChangedRecipients]
        private object? _someProperty;
    }
}
