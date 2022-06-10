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
        [NotifyPropertyChangedRecipients]
        [Display(Name = "Is static")]
        private object? _someProperty;
    }
}
