using MadGameTycoon2Tool.Config;
using MadGameTycoon2Tool.Model;
using MadGameTycoon2Tool.Utility;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Windows.Input;

namespace MadGameTycoon2Tool.ViewModel
{
    internal class RecipeViewModel : ObservableObject
    {
        public ICommand MainType_SelectionChangedCommand { get; }
        public ICommand ChildType_SelectionChangedCommand { get; }
        public ICommand SearchGameTheme_TextChangedCommand { get; }

        private RecipeModel recipeM;
        public RecipeModel RecipeM
        {
            get { return recipeM; }
            set { SetProperty(ref recipeM, value); }
        }
        JObject jo;
        public RecipeViewModel()
        {
            //直接从json中拿到主游戏类型
            List<string> gameType = new List<string>();
            jo = JsonConvert.DeserializeObject(File.ReadAllText(AppConfig.GameInfo_SingleType)) as JObject;
            foreach (var item in jo.Children())
            {
                gameType.Add(item.Path);
            }
            RecipeM = new RecipeModel
            {
                MainType = gameType,
                ChildType = new List<string>()
            };
            MainType_SelectionChangedCommand = new RelayCommand(MainType_SelectionChanged);
            ChildType_SelectionChangedCommand = new RelayCommand(ChildType_SelectionChanged);
            SearchGameTheme_TextChangedCommand = new RelayCommand(SearchGameTheme_TextChanged);
        }
        /// <summary>
        /// 主类型combobox发生改变以后
        /// </summary>
        public void MainType_SelectionChanged()
        {
            //目标人群
            RecipeM.TargetGroup = jo[RecipeM.SelectMainType]["TargetGroup"].ToString();

            //根据主类型获得合适的主题
            List<string> gameThemeList = new List<string>();
            foreach (var item in jo[RecipeM.SelectMainType]["GameTheme"])
            {
                gameThemeList.Add(item.ToString());
            }
            RecipeM.Theme = GameTypeAndTheme.GetGameTheme(gameThemeList);
            AppConfig.GameThemeTemp = RecipeM.Theme;

            //根据主类型获得合适的子类型
            RecipeM.SelectChildType = string.Empty;
            RecipeM.ChildType = GameTypeAndTheme.GetChildType(jo, RecipeM.SelectMainType);

            //根据单个主类型获取设计重点、设计方向、开发重点
            GameDesign.GetSingleType_DesignFocus(jo, RecipeM);
            GameDesign.GetSingleType_DesignDirection(jo, RecipeM);
            GameDesign.GetType_DesignPriority(jo, RecipeM);
        }
        /// <summary>
        /// 子类型combobox发生改变以后
        /// </summary>
        public void ChildType_SelectionChanged()
        {
            //如果选择的子类型是空的，就跳出去
            //因为重新选择主类型以后，会把子类型的combobox选择项清空
            //然后会跳到这个事件，如果不处理会报错
            if (RecipeM.SelectChildType == "")
            {
                return;
            }
            JObject jo = JsonConvert.DeserializeObject(File.ReadAllText(AppConfig.GameInfo_SingleType)) as JObject;
            JObject jo2 = JsonConvert.DeserializeObject(File.ReadAllText(AppConfig.GameInfo_MultipleType)) as JObject;
            //根据相同类型获得合适的主题
            List<string> sameTheme = GameTypeAndTheme.GetSameGameTheme(jo, RecipeM.SelectMainType, RecipeM.SelectChildType);
            RecipeM.Theme = GameTypeAndTheme.GetGameTheme(sameTheme);
            AppConfig.GameThemeTemp = RecipeM.Theme;

            //根据主类型和子类型获取设计重点、设计方向、开发重点
            GameDesign.GetMultipleype_DesignFocus(jo2, RecipeM);
            GameDesign.GetMultipleype_DesignDirection(jo2, RecipeM);
            GameDesign.GetType_DesignPriority(jo, RecipeM);
        }
        /// <summary>
        /// 查找游戏主题
        /// </summary>
        public void SearchGameTheme_TextChanged()
        {
            RecipeM.Theme = AppConfig.GameThemeTemp;//先把界面上显示的主题设置成全部合适的主题
            List<string> searchResult = new List<string>();
            string searchText = RecipeM.SearchTheme;//要搜索的主题
            if (!string.IsNullOrWhiteSpace(searchText))//如果不是null或者空格再搜索
            {
                foreach (var item in RecipeM.Theme)//从所有合适的主题里查找
                {
                    if (item.Contains(searchText))//如果存在
                    {
                        searchResult.Add(item);//就添加到列表里
                    }
                }
                RecipeM.Theme = searchResult;
            }
            else
            {
                RecipeM.Theme = AppConfig.GameThemeTemp;
            }
        }
    }
}
