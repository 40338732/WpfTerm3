using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3.ViewModels
{
    class MainWindowViewModel : BaseViewModel
    {
        public string NameTextBlock { get; private set; }
        public string AgeTextBlock { get; private set; }
        public string AddressTextBlock { get; private set; }


        public string ClearButtonText { get; private set; }
        public string SaveButtonText { get; private set; }

        public MainWindowViewModel()
        {
            NameTextBlock = "Name";
            AgeTextBlock = "Age";
            AddressTextBlock = "Address";

            ClearButtonText = "Clear";
            SaveButtonText = "Save";

            NameTextBlock = string.Empty;
            AgeTextBlock = string.Empty;
            AddressTextBlock = string.Empty;
        }
    }

    
    
}
