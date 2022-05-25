using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MadGameTycoon2Tool.Model
{
    internal class ConsoleModel : ObservableObject
    {
        private ObservableCollection<ConsoleInfo> accessoryList;
        public ObservableCollection<ConsoleInfo> AccessoryList
        {
            get => accessoryList;
            set => SetProperty(ref accessoryList, value);
        }
        private string selectLevel;
        public string SelectLevel
        {
            get => selectLevel;
            set => SetProperty(ref selectLevel, value);
        }
        private ObservableCollection<string> levelList;
        public ObservableCollection<string> LevelList
        {
            get => levelList;
            set => SetProperty(ref levelList, value);
        }
        private string selectType;
        public string SelectType
        {
            get => selectType;
            set => SetProperty(ref selectType, value);
        }
        private ObservableCollection<string> typeList;
        public ObservableCollection<string> TypeList
        {
            get => typeList;
            set => SetProperty(ref typeList, value);
        }
    }
    internal class ConsoleInfo : ObservableObject
    {
        private string accessoryName;
        public string AccessoryName
        {
            get => accessoryName;
            set => SetProperty(ref accessoryName, value);
        }
        private string accessoryType;
        public string AccessoryType
        {
            get => accessoryType;
            set => SetProperty(ref accessoryType, value);
        }
        private string accessoryLevel;
        public string AccessoryLevel
        {
            get => accessoryLevel;
            set => SetProperty(ref accessoryLevel, value);
        }
        private string accessoryUnlock;
        public string AccessoryUnlock
        {
            get => accessoryUnlock;
            set => SetProperty(ref accessoryUnlock, value);
        }
    }
}
