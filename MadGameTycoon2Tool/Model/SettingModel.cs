using Microsoft.Toolkit.Mvvm.ComponentModel;
using System.Collections.Generic;

namespace MadGameTycoon2Tool.Model
{
    internal class SettingModel : ObservableObject
    {
        private List<string> themeColor;
        public List<string> ThemeColor
        {
            get => themeColor;
            set => SetProperty(ref themeColor, value);
        }
        private string useThemeColor;
        public string UseThemeColor
        {
            get => useThemeColor;
            set => SetProperty(ref useThemeColor, value);
        }
        private List<string> themeStyle;
        public List<string> ThemeStyle
        {
            get => themeStyle;
            set => SetProperty(ref themeStyle, value);
        }
        private string useThemeStyle;
        public string UseThemeStyle
        {
            get => useThemeStyle;
            set => SetProperty(ref useThemeStyle, value);
        }
        private List<string> languageList;
        public List<string> LanguageList
        {
            get => languageList;
            set => SetProperty(ref languageList, value);
        }
        private string useLanguage;
        public string UseLanguage
        {
            get => useLanguage;
            set => SetProperty(ref useLanguage, value);
        }
    }
}
