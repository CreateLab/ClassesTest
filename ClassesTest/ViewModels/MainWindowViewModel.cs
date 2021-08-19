using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Avalonia.Controls;

namespace ClassesTest.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<TestObj> Messages => new ObservableCollection<TestObj>()
        {
            new TestObj
            {
                Class=true,
                Name = "Red"
                    
            },
            new TestObj
            {
            
            Name = "Blue"
                    
            }
        };
    }
}