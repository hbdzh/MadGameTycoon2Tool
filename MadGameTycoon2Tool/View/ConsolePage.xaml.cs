using MadGameTycoon2Tool.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace MadGameTycoon2Tool.View
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class ConsolePage : Page
    {
        ConsoleViewModel ConsoleVM;
        public ConsolePage()
        {
            this.InitializeComponent();
            ConsoleVM = new ConsoleViewModel();
        }

        private void ConsoleAccessory_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            //窗口高度-文本框高度-Grid高度，这样就可以约束住ListView的高度，不会再让高度随内容变高
            ConsoleAccessoryList.Height = ConsoleAccessory.ActualHeight - ConsoleGrid.ActualHeight - 30;
        }
    }
}
