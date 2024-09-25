namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {        
        public TestData TestData { get; private set; }

        public MainPage()
        {
            InitializeComponent();
            TestData = new TestData();
        }
        private void Open_Window(object sender, EventArgs e)
        {
            var testPage = new TestPage(new TestViewModel(TestData));
            var window = new Window(testPage);
            App.Current?.OpenWindow(window);
        }        
        
        private async void Nav_Page(object sender, EventArgs e)
        {
            var testPage = new TestPage(new TestViewModel(TestData));
            await Shell.Current.Navigation.PushAsync(testPage);
        }
    }

}
