namespace MauiApp1
{
    public partial class TestPage : ContentPage
    {
        public TestPage(TestViewModel testViewModel)
        {
            InitializeComponent();
            BindingContext = testViewModel;
        }

    }

}
