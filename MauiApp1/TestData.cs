using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiApp1
{
    public partial class TestData : ObservableObject
    {
        [ObservableProperty]
        private bool isToggled;
    }

}
