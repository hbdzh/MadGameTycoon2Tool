using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;

namespace MadGameTycoon2Tool.Utility
{
    internal class GameTypeAndTheme
    {
        /// <summary>
        /// 获取主类型和子类型之间相同的游戏主题
        /// </summary>
        /// <param name="jo"></param>
        /// <param name="selectMainType">选择的游戏主要类型</param>
        /// <param name="selectChildType">选择的游戏子类型</param>
        /// <returns></returns>
        internal static List<string> GetSameGameTheme(JObject jo, string selectMainType, string selectChildType)
        {
            selectChildType = selectChildType.Replace("*", "");
            List<string> mainTheme = new List<string>();
            List<string> childTheme = new List<string>();
            foreach (var item in jo[selectMainType]["GameTheme"])
            {
                mainTheme.Add(item.ToString());
            }
            foreach (var item in jo[selectChildType]["GameTheme"])
            {
                childTheme.Add(item.ToString());
            }
            return mainTheme.Intersect(childTheme).ToList();//筛选出两个list相同的内容以后，转成list
        }
        /// <summary>
        /// 根据主类型获得合适的子类型
        /// </summary>
        /// <param name="jo"></param>
        /// <param name="gameType">游戏类型</param>
        /// <returns></returns>
        internal static List<string> GetChildType(JObject jo, string gameType)
        {
            List<string> childTypeList = new List<string>();
            foreach (JToken item in jo[gameType].Children())
            {
                childTypeList.Add(item.Path.ToString().Replace(gameType + ".", ""));
            }
            //foreach (var item in jo[gameType]["ChildType"])
            //{
            //    childTypeList.Add(item.ToString());
            //}
            return childTypeList;
        }
        /// <summary>
        /// 获取游戏主题
        /// </summary>
        /// <param name="themeList">游戏主题列表</param>
        /// <returns></returns>
        internal static List<string> GetGameTheme(List<string> themeList)
        {
            int i = 1;
            string temp = "";
            List<string> gameThemeList = new List<string>();
            for (int j = 0; j < themeList.Count(); j++)
            {
                if ((themeList.Count() - j) < 5)//如果剩余的主题数量小于5，就不够一组，需要特殊处理
                {
                    if (temp != "")//如果temp的内容不是空的，在处理
                    {
                        if (!gameThemeList.Contains(temp))//如果已经添加的主题列表里，没有temp项再添加
                        {
                            gameThemeList.Add(temp);//添加
                            temp = "";//这时候可以清空temp了，因为后续不再需要使用
                        }
                    }
                    gameThemeList.Add(themeList[j].ToString());//单独添加剩余的
                    i = 6;//设置成6，就不会再执行下方的代码
                }
                if (i == 1)
                {
                    temp = themeList[j].ToString();//第一次不需要添加“，”
                    i++;
                }
                else if (i < 5)
                {
                    temp = temp + "，" + themeList[j];//如果依然小于5就只添加到temp，先不添加到列表
                    i++;
                }
                else if (i == 5)
                {
                    gameThemeList.Add(temp + "，" + themeList[j]);//temp里已经存够5个以后，就可以添加到列表了
                    temp = temp + "，" + themeList[j];
                    i = 1;
                }
            }
            return gameThemeList;
        }
    }
}
