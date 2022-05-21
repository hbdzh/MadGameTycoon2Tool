using Microsoft.Toolkit.Mvvm.ComponentModel;
using System.Collections.Generic;

namespace MadGameTycoon2Tool.Model
{
    internal class RecipeModel : ObservableObject
    {
        private string searchTheme = "";
        /// <summary>
        /// 要查找的游戏主题
        /// </summary>
        public string SearchTheme
        {
            get => searchTheme;
            set => SetProperty(ref searchTheme, value);
        }
        private List<string> mainType;
        /// <summary>
        /// 主类型
        /// </summary>
        public List<string> MainType
        {
            get => mainType;
            set => SetProperty(ref mainType, value);
        }
        private string selectMainType = "";
        /// <summary>
        /// 选中的主类型
        /// </summary>
        public string SelectMainType
        {
            get => selectMainType;
            set => SetProperty(ref selectMainType, value);
        }
        private List<string> childType;
        /// <summary>
        /// 子类型
        /// </summary>
        public List<string> ChildType
        {
            get => childType;
            set => SetProperty(ref childType, value);
        }
        private string selectChildType = "";
        /// <summary>
        /// 选中的子类型
        /// </summary>
        public string SelectChildType
        {
            get => selectChildType;
            set => SetProperty(ref selectChildType, value);
        }
        private List<string> theme;
        /// <summary>
        /// 游戏主题
        /// </summary>
        public List<string> Theme
        {
            get => theme;
            set => SetProperty(ref theme, value);
        }
        private string targetGroup = "";
        /// <summary>
        /// 目标人群
        /// </summary>
        public string TargetGroup
        {
            get => targetGroup;
            set => SetProperty(ref targetGroup, value);
        }
        private string gameLength = "";
        /// <summary>
        /// 游戏时长
        /// </summary>
        public string GameLength
        {
            get => gameLength;
            set => SetProperty(ref gameLength, value);
        }
        private string gameDepth = "";
        /// <summary>
        /// 游戏深度
        /// </summary>
        public string GameDepth
        {
            get => gameDepth;
            set => SetProperty(ref gameDepth, value);
        }
        private string beginnerFriendliness = "";
        /// <summary>
        /// 萌新上手度
        /// </summary>
        public string BeginnerFriendliness
        {
            get => beginnerFriendliness;
            set => SetProperty(ref beginnerFriendliness, value);
        }
        private string innovation = "";
        /// <summary>
        /// 创意
        /// </summary>
        public string Innovation
        {
            get => innovation;
            set => SetProperty(ref innovation, value);
        }
        private string story = "";
        /// <summary>
        /// 剧情
        /// </summary>
        public string Story
        {
            get => story;
            set => SetProperty(ref story, value);
        }
        private string characterDesign = "";
        /// <summary>
        /// 角色设计
        /// </summary>
        public string CharacterDesign
        {
            get => characterDesign;
            set => SetProperty(ref characterDesign, value);
        }
        private string levelDesign = "";
        /// <summary>
        /// 关卡设计
        /// </summary>
        public string LevelDesign
        {
            get => levelDesign;
            set => SetProperty(ref levelDesign, value);
        }
        private string missionDesign = "";
        /// <summary>
        /// 任务设计
        /// </summary>
        public string MissionDesign
        {
            get => missionDesign;
            set => SetProperty(ref missionDesign, value);
        }
        private string hardCore = "";
        /// <summary>
        /// 核心玩家-休闲玩家
        /// </summary>
        public string HardCore
        {
            get => hardCore;
            set => SetProperty(ref hardCore, value);
        }
        private string contentAge = "";
        /// <summary>
        /// 和平向-成人内容
        /// </summary>
        public string ContentAge
        {
            get => contentAge;
            set => SetProperty(ref contentAge, value);
        }
        private string difficulty = "";
        /// <summary>
        /// 简单-传奇
        /// </summary>
        public string Difficulty
        {
            get => difficulty;
            set => SetProperty(ref difficulty, value);
        }
        private string gamePlay = "";
        /// <summary>
        /// 游戏玩法
        /// </summary>
        public string GamePlay
        {
            get => gamePlay;
            set => SetProperty(ref gamePlay, value);
        }
        private string graphics = "";
        /// <summary>
        /// 图像
        /// </summary>
        public string Graphics
        {
            get => graphics;
            set => SetProperty(ref graphics, value);
        }
        private string sound = "";
        /// <summary>
        /// 声音
        /// </summary>
        public string Sound
        {
            get => sound;
            set => SetProperty(ref sound, value);
        }
        private string technical = "";
        /// <summary>
        /// 技术
        /// </summary>
        public string Technical
        {
            get => technical;
            set => SetProperty(ref technical, value);
        }
    }
}
