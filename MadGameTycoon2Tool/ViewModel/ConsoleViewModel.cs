using MadGameTycoon2Tool.Model;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System.Windows.Input;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using MadGameTycoon2Tool.Config;
using System.Collections.ObjectModel;

namespace MadGameTycoon2Tool.ViewModel
{
    internal class ConsoleViewModel : ObservableObject
    {
        public ICommand TechnologyLevel_SelectionChangedCommand { get; set; }
        public ICommand AccessoryType_SelectionChangedCommand { get; set; }

        private ConsoleModel consoleM;
        public ConsoleModel ConsoleM
        {
            get { return consoleM; }
            set { SetProperty(ref consoleM, value); }
        }
        public ConsoleViewModel()
        {
            ConsoleM = new ConsoleModel();
            ConsoleM.AccessoryList = new ObservableCollection<ConsoleInfo>();
            TechnologyLevel_SelectionChangedCommand = new RelayCommand(TechnologyLevel_SelectionChanged);
            AccessoryType_SelectionChangedCommand = new RelayCommand(AccessoryType_SelectionChanged);
            Init();
        }
        JObject json;
        private void Init()
        {
            json = JsonConvert.DeserializeObject(File.ReadAllText(AppConfig.ConsoleInfo)) as JObject;
            ConsoleM.LevelList = new ObservableCollection<string>() { "T1", "T1+", "T2", "T2+", "T3", "T3+", "T4", "T4+", "T5", "T5+", "T6", "T6+", "T7", "T7+", "T8", "T8+", "T8++", "T8+++" };

            //直接从json中拿到配件类型，方便多语言的实现
            ObservableCollection<string> accessoryType = new ObservableCollection<string>();
            foreach (var item in json.Values())
            {
                if (!accessoryType.Contains(item["Type"].ToString()))
                {
                    accessoryType.Add(item["Type"].ToString());
                }
            }
            ConsoleM.TypeList = accessoryType;
        }
        private void TechnologyLevel_SelectionChanged()
        {
            JsonQuery("Level", ConsoleM.SelectLevel);
        }
        private void AccessoryType_SelectionChanged()
        {
            JsonQuery("Type", ConsoleM.SelectType);
        }
        private void JsonQuery(string queryKey, string select)
        {
            ObservableCollection<ConsoleInfo> list = new ObservableCollection<ConsoleInfo>();
            foreach (var item in json.Values())
            {
                if (item[queryKey].ToString() == select)
                {
                    list.Add(new ConsoleInfo
                    {
                        AccessoryName = item.Path.Replace('_', ' ').Replace('。', '.'),
                        AccessoryType = item["Type"].ToString(),
                        AccessoryLevel = item["Level"].ToString(),
                        AccessoryUnlock = item["Unlock"].ToString()
                    });
                }
            }
            ConsoleM.AccessoryList = list;
        }
    }
}
