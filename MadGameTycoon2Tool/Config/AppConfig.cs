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
        /// 游戏机信息json文件路径
        /// </summary>
        internal static string ConsoleInfo
        {
            get
            {
                if ((string)ApplicationData.Current.LocalSettings.Values["AppLanguage"] == "简体中文")
                {
                    return "Data\\ConsoleInfo_cns.json";
                }
                else if ((string)ApplicationData.Current.LocalSettings.Values["AppLanguage"] == "繁體中文")
                {
                    return "Data\\ConsoleInfo_cnt.json";
                }
                else if ((string)ApplicationData.Current.LocalSettings.Values["AppLanguage"] == "Engilsh")
                {
                    return "Data\\ConsoleInfo_en.json";
                }
                else
                {
                    return "Data\\ConsoleInfo_cns.json";
                }
            }
        }
        /// <summary>
        /// 单类型json文件
        /// </summary>
        internal static string GameInfo_SingleType
        {
            get
            {
                if ((string)ApplicationData.Current.LocalSettings.Values["AppLanguage"] == "简体中文")
                {
                    return "Data\\GameInfo_SingleType_cns.json";
                }
                else if ((string)ApplicationData.Current.LocalSettings.Values["AppLanguage"] == "繁體中文")
                {
                    return "Data\\GameInfo_SingleType_cnt.json";
                }
                else if ((string)ApplicationData.Current.LocalSettings.Values["AppLanguage"] == "Engilsh")
                {
                    return "Data\\GameInfo_SingleType_en.json";
                }
                else
                {
                    return "Data\\GameInfo_SingleType_cns.json";
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
                if ((string)ApplicationData.Current.LocalSettings.Values["AppLanguage"] == "简体中文")
                {
                    return "Data\\GameInfo_MultipleType_cns.json";
                }
                else if ((string)ApplicationData.Current.LocalSettings.Values["AppLanguage"] == "繁體中文")
                {
                    return "Data\\GameInfo_MultipleType_cnt.json";
                }
                else if ((string)ApplicationData.Current.LocalSettings.Values["AppLanguage"] == "Engilsh")
                {
                    return "Data\\GameInfo_MultipleType_en.json";
                }
                else
                {
                    return "Data\\GameInfo_MultipleType_cns.json";
                }
            }
        }
    }
}
