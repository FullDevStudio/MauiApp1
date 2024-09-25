using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Diagnostics;

namespace MauiApp1
{
    public partial class TestViewModel: ObservableObject
    {
        public TestData TestData { get; }


        public TestViewModel(TestData testData)
        {
            TestData = testData;
        }

        [RelayCommand]
        void TestTrigger()
        {
            Console.WriteLine($"------------------------------------------Toggled to {TestData.IsToggled}------------------------------------------");
            Trace.WriteLine($"------------------------------------------Toggled to {TestData.IsToggled}------------------------------------------");
        }
    }
}
