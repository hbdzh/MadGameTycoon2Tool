using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace MadGameTycoon2Tool.View
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class HomePage : Page
    {
        public HomePage()
        {
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

            ApplicationView.PreferredLaunchViewSize = new Size(780, 850);
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;

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
        private void HomePage_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            //窗口高度-文本框高度-Grid高度，这样就可以约束住ListView的高度，不会再让高度随内容变高
            ThemeList.Height = AppHome.ActualHeight - AppTitleBar.ActualHeight - GameTypeGrid.ActualHeight - SearchGameTheme.ActualHeight - 50;
        }
    }
}
