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
        /// <summary>
        /// 所有游戏类型
        /// </summary>
        internal static List<string> AllGameType { get; } = new List<string> { "动作", "冒险", "模拟建筑", "模拟经营", "格斗", "第一人称射击", "交互式电影", "横版", "益智", "竞速", "即时战略", "角色扮演", "模拟", "技巧", "体育", "策略", "第三人称射击", "交互式小说" };
    }
}
