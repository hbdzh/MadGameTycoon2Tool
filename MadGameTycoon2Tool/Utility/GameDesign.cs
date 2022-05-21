using MadGameTycoon2Tool.Model;
using Newtonsoft.Json.Linq;

namespace MadGameTycoon2Tool.Utility
{
    internal class GameDesign
    {
        /// <summary>
        /// 获取设计重点（单个）
        /// </summary>
        /// <param name="jo"></param>
        /// <param name="Home"></param>
        internal static void GetSingleType_DesignFocus(JObject jo, RecipeModel Home)
        {
            Home.GameLength = jo[Home.SelectMainType]["DesignFocus"][0].ToString();
            Home.GameDepth = jo[Home.SelectMainType]["DesignFocus"][1].ToString();
            Home.BeginnerFriendliness = jo[Home.SelectMainType]["DesignFocus"][2].ToString();
            Home.Innovation = jo[Home.SelectMainType]["DesignFocus"][3].ToString();
            Home.Story = jo[Home.SelectMainType]["DesignFocus"][4].ToString();
            Home.CharacterDesign = jo[Home.SelectMainType]["DesignFocus"][5].ToString();
            Home.LevelDesign = jo[Home.SelectMainType]["DesignFocus"][6].ToString();
            Home.MissionDesign = jo[Home.SelectMainType]["DesignFocus"][7].ToString();
        }
        /// <summary>
        /// 获取设计方向（单个）
        /// </summary>
        /// <param name="jo"></param>
        /// <param name="Home"></param>
        internal static void GetSingleType_DesignDirection(JObject jo, RecipeModel Home)
        {
            Home.HardCore = jo[Home.SelectMainType]["DesignDirection"][0].ToString();
            Home.ContentAge = jo[Home.SelectMainType]["DesignDirection"][1].ToString();
            Home.Difficulty = jo[Home.SelectMainType]["DesignDirection"][2].ToString();
        }
        /// <summary>
        /// 获取设计重点（多个）
        /// </summary>
        /// <param name="jo"></param>
        /// <param name="Home"></param>
        internal static void GetMultipleype_DesignFocus(JObject jo, RecipeModel Home)
        {
            Home.GameLength = jo[Home.SelectMainType][Home.SelectChildType]["DesignFocus"][0].ToString();
            Home.GameDepth = jo[Home.SelectMainType][Home.SelectChildType]["DesignFocus"][1].ToString();
            Home.BeginnerFriendliness = jo[Home.SelectMainType][Home.SelectChildType]["DesignFocus"][2].ToString();
            Home.Innovation = jo[Home.SelectMainType][Home.SelectChildType]["DesignFocus"][3].ToString();
            Home.Story = jo[Home.SelectMainType][Home.SelectChildType]["DesignFocus"][4].ToString();
            Home.CharacterDesign = jo[Home.SelectMainType][Home.SelectChildType]["DesignFocus"][5].ToString();
            Home.LevelDesign = jo[Home.SelectMainType][Home.SelectChildType]["DesignFocus"][6].ToString();
            Home.MissionDesign = jo[Home.SelectMainType][Home.SelectChildType]["DesignFocus"][7].ToString();
        }
        /// <summary>
        /// 获取设计方向（多个）
        /// </summary>
        /// <param name="jo"></param>
        /// <param name="Home"></param>
        internal static void GetMultipleype_DesignDirection(JObject jo, RecipeModel Home)
        {
            Home.HardCore = jo[Home.SelectMainType][Home.SelectChildType]["DesignDirection"][0].ToString();
            Home.ContentAge = jo[Home.SelectMainType][Home.SelectChildType]["DesignDirection"][1].ToString();
            Home.Difficulty = jo[Home.SelectMainType][Home.SelectChildType]["DesignDirection"][2].ToString();
        }
        /// <summary>
        /// 获取开发重点
        /// </summary>
        /// <param name="jo"></param>
        /// <param name="Home"></param>
        internal static void GetType_DesignPriority(JObject jo, RecipeModel Home)
        {
            Home.GamePlay = jo[Home.SelectMainType]["DesignPriority"][0].ToString();
            Home.Graphics = jo[Home.SelectMainType]["DesignPriority"][1].ToString();
            Home.Sound = jo[Home.SelectMainType]["DesignPriority"][2].ToString();
            Home.Technical = jo[Home.SelectMainType]["DesignPriority"][3].ToString();
        }
    }
}
