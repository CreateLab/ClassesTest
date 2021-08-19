using Avalonia.Controls;
using ReactiveUI;

namespace ClassesTest.ViewModels
{
    public class TestObj : ReactiveObject
    {
        public string Name { get; set; }
        public bool Class { get; set; }
    }
}