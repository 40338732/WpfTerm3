using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp3.Commands;
using System.Windows;


namespace WpfApp3.ViewModels
{
    class MainWindowViewModel : BaseViewModel
    {
        public string NameTextBlock { get; private set; }
        public string AgeTextBlock { get; private set; }
        public string AddressTextBlock { get; private set; }

        public string NameTextBox { get; set; }
        public string AgeTextBox { get; set; }
        public string AddressTextBox { get; set; }

        public ICommand ClearButtonCommand { get; private set; }
        public ICommand SaveButtonCommand { get; private set; }
        
        public string ClearButtonText { get; private set; }
        public string SaveButtonText { get; private set; }

        public MainWindowViewModel()
        {
            NameTextBlock = "Name";
            AgeTextBlock = "Age";
            AddressTextBlock = "Address";

            ClearButtonText = "Clear";
            SaveButtonText = "Save";

            NameTextBox = string.Empty;
            AgeTextBox = string.Empty;
            AddressTextBox = string.Empty;

            ClearButtonCommand = new RelayCommand(ClearButtonClick);
            SaveButtonCommand = new RelayCommand(SaveButtonClick);
        }

        private void SaveButtonClick()
        {
            MessageBox.Show("Save Button Clicked");
        }

        private void ClearButtonClick()
        {
            MessageBox.Show("Clear Button Clicked");
        }
    }

    
    
}
