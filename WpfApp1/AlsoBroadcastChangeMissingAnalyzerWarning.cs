using CommunityToolkit.Mvvm.ComponentModel;

namespace WpfApp1
{
    /// <summary>
    /// I should get notified about the missing [ObservableRecipient] attribute on the class before compiling
    /// </summary>
    public sealed partial class AlsoBroadcastChangeMissingAnalyzerWarning : ObservableValidator
    {
        [ObservableProperty]
        [AlsoBroadcastChange]
        private object? _someProperty;
    }
}
