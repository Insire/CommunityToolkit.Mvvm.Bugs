using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using NUnit.Framework;

namespace WpfLibrary1
{
    public sealed class SourceGenObservableRecipientTests
    {
        [Test]
        public void ShouldRaiseEvent()
        {
            var propertyChanged = false;

            var viewModel = new BroadCastViewModel();
            viewModel.PropertyChanged += ViewModel_PropertyChanged;
            viewModel.Property = new object();

            Assert.IsTrue(propertyChanged);

            void ViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
            {
                propertyChanged = true;
            }
        }

        [Test]
        public void Should_Send_Message_With_Explicit_Messenger()
        {
            var propertyChanged = false;
            var messageSent = false;
            var messenger = new StrongReferenceMessenger();
            var viewModel = new BroadCastViewModel(messenger);
            messenger.Register<SourceGenObservableRecipientTests, PropertyChangedMessage<object>>(this, (r, m) =>
            {
                messageSent = true;
            });
            viewModel.PropertyChanged += ViewModel_PropertyChanged;
            viewModel.Property = new object();

            Assert.IsTrue(messageSent);
            Assert.IsTrue(propertyChanged);

            void ViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
            {
                propertyChanged = true;
            }
        }

        [Test]
        public void Should_Send_Message_Without_Explicit_Messenger()
        {
            var propertyChanged = false;
            var messageSent = false;
            var messenger = WeakReferenceMessenger.Default;
            var viewModel = new BroadCastViewModel();
            messenger.Register<SourceGenObservableRecipientTests, PropertyChangedMessage<object>>(this, (r, m) =>
            {
                messageSent = true;
            });
            viewModel.PropertyChanged += ViewModel_PropertyChanged;
            viewModel.Property = new object();

            Assert.IsTrue(messageSent);
            Assert.IsTrue(propertyChanged);

            void ViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
            {
                propertyChanged = true;
            }
        }
    }
}
