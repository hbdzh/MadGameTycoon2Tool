using MadGameTycoon2Tool.Model;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MadGameTycoon2Tool.ViewModel
{
    internal class ConsoleViewModel : ObservableObject
    {
        public ICommand TechnologyLevel_SelectionChangedCommand { get; set; }

        private ConsoleModel consoleM;
        public ConsoleModel ConsoleM
        {
            get { return consoleM; }
            set { SetProperty(ref consoleM, value); }
        }
        public ConsoleViewModel()
        {
            TechnologyLevel_SelectionChangedCommand = new RelayCommand(TechnologyLevel_SelectionChanged);
        }
        private void TechnologyLevel_SelectionChanged()
        {

        }
    }
}
