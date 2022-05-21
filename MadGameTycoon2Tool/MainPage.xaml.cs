using MadGameTycoon2Tool.View;
using Microsoft.UI.Xaml.Controls;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Globalization;
using Windows.Storage;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace MadGameTycoon2Tool
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            LoadLanguage();
            LoadThemeStyle();
            this.InitializeComponent();

            var coreTitleBar = CoreApplication.GetCurrentView().TitleBar;
            ApplicationViewTitleBar appTitleBar = ApplicationView.GetForCurrentView().TitleBar;
            appTitleBar.ButtonBackgroundColor = Colors.Transparent;
            appTitleBar.ButtonInactiveBackgroundColor = Colors.Transparent;

            coreTitleBar.ExtendViewIntoTitleBar = true;
            UpdateTitleBarLayout();

            // Set XAML element as a draggable region.
            Window.Current.SetTitleBar(AppTitleBar);

            // Register a handler for when the size of the overlaid caption control changes.
            // For example, when the app moves to a screen with a different DPI.
            coreTitleBar.LayoutMetricsChanged += CoreTitleBar_LayoutMetricsChanged;

            ApplicationView.PreferredLaunchViewSize = new Size(730, 840);
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.Auto;

            ContentFrame.Navigate(typeof(RecipePage));
        }
        private void CoreTitleBar_LayoutMetricsChanged(CoreApplicationViewTitleBar sender, object args)
        {
            UpdateTitleBarLayout();
        }

        private void UpdateTitleBarLayout()
        {
            // Get the size of the caption controls area and back button 
            // (returned in logical pixels), and move your content around as necessary.
            TitleBar.Margin = new Thickness(15, 10, 0, 10);
        }
        private void AppNav_ItemInvoked(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewItemInvokedEventArgs args)
        {
            //先判断是否选中了setting
            if (args.IsSettingsInvoked)
            {
                ContentFrame.Navigate(typeof(SettingPage));
            }
            else
            {
                Microsoft.UI.Xaml.Controls.NavigationViewItem selectItem =  AppNav.SelectedItem as Microsoft.UI.Xaml.Controls.NavigationViewItem;
                //选中项的内容
                switch (selectItem.Name)
                {
                    case "GameRecipe":
                        ContentFrame.Navigate(typeof(RecipePage));
                        break;
                    case "GameMachineInfo":
                        ContentFrame.Navigate(typeof(ConsolePage));
                        break;
                }
            }
            LoadThemeStyle();
        }
        /// <summary>
        /// 加载储存的主题样式
        /// </summary>
        private void LoadThemeStyle()
        {
            if ((string)ApplicationData.Current.LocalSettings.Values["ThemeStyle"] == "Mica")
            {
                BackdropMaterial.SetApplyToRootOrPageBackground(this, true);
            }
            else if ((string)ApplicationData.Current.LocalSettings.Values["ThemeStyle"] == "Acrylic")
            {
                BackdropMaterial.SetApplyToRootOrPageBackground(this, false);
                Background = (Brush)Application.Current.Resources["AcrylicBackgroundFillColorDefaultBrush"];
            }
            else
            {
                BackdropMaterial.SetApplyToRootOrPageBackground(this, true);
            }
        }
        /// <summary>
        /// 加载储存的语言
        /// </summary>
        private void LoadLanguage()
        {
            if ((string)ApplicationData.Current.LocalSettings.Values["Language"] == "简体中文")
            {
                ApplicationLanguages.PrimaryLanguageOverride = "zh-Hans";
            }
            else if ((string)ApplicationData.Current.LocalSettings.Values["Language"] == "繁体中文")
            {
                ApplicationLanguages.PrimaryLanguageOverride = "zh-Hant";
            }
            else if ((string)ApplicationData.Current.LocalSettings.Values["Language"] == "英语")
            {
                ApplicationLanguages.PrimaryLanguageOverride = "en";
            }
        }
    }
}
