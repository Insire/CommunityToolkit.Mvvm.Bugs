using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WpfApp1
{
    /// <summary>
    /// Broadcast(__oldValue, value, "SomeProperty"); is not being generated, when the [Display] attribute is being added last
    /// </summary>
    [ObservableRecipient]
    public sealed partial class AlsoBroadcastChangeNotGenerated : ObservableValidator
    {
        [ObservableProperty]
        [AlsoBroadcastChange]
        [Display(Name = "Is static")]
        private object? _someProperty;
    }

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
