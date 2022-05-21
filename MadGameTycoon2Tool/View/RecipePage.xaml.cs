using MadGameTycoon2Tool.ViewModel;
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
    public sealed partial class RecipePage : Page
    {
        public RecipePage()
        {
            this.InitializeComponent();
        }

        private void RecipePage_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            //窗口高度-文本框高度-Grid高度，这样就可以约束住ListView的高度，不会再让高度随内容变高
            ThemeList.Height = AppHome.ActualHeight - GameTypeGrid.ActualHeight - SearchGameTheme.ActualHeight - 50;
        }
    }
}
