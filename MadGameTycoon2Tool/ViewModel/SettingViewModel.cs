using MadGameTycoon2Tool.Model;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Windows.Input;
using Windows.ApplicationModel;
using Windows.Storage;
using Windows.System;

namespace MadGameTycoon2Tool.ViewModel
{
    internal class SettingViewModel : ObservableObject
    {
        public ICommand SettingSaveCommand { get; set; }
        public ICommand GoToGithubCommand { get; set; }
        public ICommand FiveStarCommand { get; set; }
        private SettingModel settingM;
        public SettingModel SettingM
        {
            get { return settingM; }
            set { SetProperty(ref settingM, value); }
        }
        public SettingViewModel()
        {
            SettingSaveCommand = new RelayCommand(SettingSave);
            GoToGithubCommand = new RelayCommand(GoToGithub);
            FiveStarCommand = new RelayCommand(FiveStar);
            SettingM = new SettingModel();
            InitThemeStyle();
        }
        private void InitThemeStyle()
        {
            SettingM.ThemeStyle = new List<string>
            {
                "Mica",
                "Acrylic"
            };
            SettingM.LanguageList = new List<string>
            {
                "简体中文",
                "繁體中文",
                "Engilsh"
            };
            if (ApplicationData.Current.LocalSettings.Values.ContainsKey("Language"))
            {
                SettingM.UseLanguage = (string)ApplicationData.Current.LocalSettings.Values["Language"];
            }
            else
            {
                SettingM.UseLanguage = "简体中文";
            }
            if (ApplicationData.Current.LocalSettings.Values.ContainsKey("ThemeStyle"))
            {
                SettingM.UseThemeStyle = (string)ApplicationData.Current.LocalSettings.Values["ThemeStyle"];
            }
            else
            {
                SettingM.UseThemeStyle = "Mica";
            }
        }
        private void SettingSave()
        {
            if (SettingM.UseThemeStyle != null)
            {
                ApplicationData.Current.LocalSettings.Values["ThemeStyle"] = SettingM.UseThemeStyle;
            }
            if (SettingM.UseLanguage != null)
            {
                ApplicationData.Current.LocalSettings.Values["Language"] = SettingM.UseLanguage;
            }
        }
        private async void GoToGithub()
        {
            await Launcher.LaunchUriAsync(new Uri(@"https://github.com/hbdzh/MadGameTycoon2Tool"));
        }
        private async void FiveStar()
        {
            var pfn = Package.Current.Id.FamilyName;
            await Launcher.LaunchUriAsync(new Uri("ms-windows-store://review/?PFN=" + pfn));
        }
    }
}
