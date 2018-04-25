using System.Windows.Input;

namespace Meteor {
    public class AboutViewModel : BaseViewModel {
        public AboutViewModel() {
            Title = "About";
            var name = "Name";
            name = null;
            var length = name.Length;
            OpenWebCommand = new Command(() => Plugin.Share.CrossShare.Current.OpenBrowser("https://xamarin.com/platform"));
        }

        public ICommand OpenWebCommand { get; }
    }
}
