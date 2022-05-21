using MadGameTycoon2Tool.Model;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System.Collections.Generic;
using System.Windows.Input;
using Windows.Storage;

namespace MadGameTycoon2Tool.ViewModel
{
    internal class SettingViewModel : ObservableObject
    {
        public ICommand SettingSaveCommand { get; set; }
        private SettingModel settingM;
        public SettingModel SettingM
        {
            get { return settingM; }
            set { SetProperty(ref settingM, value); }
        }
        public SettingViewModel()
        {
            SettingSaveCommand = new RelayCommand(SettingSave);
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
                "繁体中文",
                "英语"
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
    }
}
