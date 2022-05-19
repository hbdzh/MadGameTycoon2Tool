using System.Collections.Generic;

namespace MadGameTycoon2Tool.Config
{
    internal class AppConfig
    {
        /// <summary>
        /// 临时存储适合的游戏主题
        /// </summary>
        internal static List<string> GameThemeTemp { get; set; }
        /// <summary>
        /// 游戏信息json文件
        /// </summary>
        internal static string GameInfoJson { get; } = "Data\\GameInfo.json";
        /// <summary>
        /// 游戏信息2json文件
        /// </summary>
        internal static string GameInfo2Json { get; } = "Data\\GameInfo2.json";
    }
}
