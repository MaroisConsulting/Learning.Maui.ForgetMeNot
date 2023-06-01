using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForgetMeNot.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        // This attribute causes .Net MAUI to automatically generate the public 
        // portion of the property
        [ObservableProperty]
        private string fullName;

        [ObservableProperty]
        private string iconName;

        public MainPageViewModel()
        {
            fullName = "Kevin Marois";
            iconName = "kevin.png";
        }
    }
}
