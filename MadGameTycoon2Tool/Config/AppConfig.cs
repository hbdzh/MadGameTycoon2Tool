using System.Collections.Generic;
using Windows.Storage;

namespace MadGameTycoon2Tool.Config
{
    internal class AppConfig
    {
        /// <summary>
        /// 临时存储适合的游戏主题
        /// </summary>
        internal static List<string> GameThemeTemp { get; set; }
        /// <summary>
        /// 单类型json文件
        /// </summary>
        internal static string GameInfo_SingleType
        {
            get
            {
                if ((string)ApplicationData.Current.LocalSettings.Values["Language"] == "简体中文")
                {
                    return "Data\\zh-Hans\\GameInfo_SingleType.json";
                }
                else if ((string)ApplicationData.Current.LocalSettings.Values["Language"] == "繁体中文")
                {
                    return "Data\\zh-Hant\\GameInfo_SingleType.json";
                }
                else if ((string)ApplicationData.Current.LocalSettings.Values["Language"] == "英语")
                {
                    return "Data\\en\\GameInfo_SingleType.json";
                }
                else
                {
                    return "Data\\zh-Hans\\GameInfo_SingleType.json";
                }
            }
        }
        /// <summary>
        /// 多类型json文件
        /// </summary>
        internal static string GameInfo_MultipleType
        {
            get
            {
                if ((string)ApplicationData.Current.LocalSettings.Values["Language"] == "简体中文")
                {
                    return "Data\\zh-Hans\\GameInfo_MultipleType.json";
                }
                else if ((string)ApplicationData.Current.LocalSettings.Values["Language"] == "繁体中文")
                {
                    return "Data\\zh-Hant\\GameInfo_MultipleType.json";
                }
                else if ((string)ApplicationData.Current.LocalSettings.Values["Language"] == "英语")
                {
                    return "Data\\en\\GameInfo_MultipleType.json";
                }
                else
                {
                    return "Data\\zh-Hans\\GameInfo_MultipleType.json";
                }
            }
        }
    }
}
