using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnoCollectionBindingSample.ViewModels
{
    public class MainViewModel : NotifyPropertyBase
    {
        public ObservableCollection<Person> _people;
        public ObservableCollection<Person> People
        {
            get { return _people; }
            set { SetProperty(ref _people, value); }
        }


        public  MainViewModel ()
        {            
            People = new ObservableCollection<Person>()
            {
                new Person { Name = "葉大雄", Address ="台北市信義路 58 號", Age=61 },
                new Person { Name = "胖虎", Address ="台中市台灣大道七段 1009 號", Age=34 },
                new Person { Name = "小夫", Address ="台北市松仁路 1 號", Age=37 },
                new Person { Name = "魯夫", Address ="高雄市七賢二路 321 號", Age=28 },
                new Person { Name = "幕之內一步", Address ="台北市忠孝東路路走九遍", Age=23 },
                new Person { Name = "索隆", Address ="台北市中山北路二段 575 號", Age=31 },
                new Person { Name = "悟空", Address ="台北市愛國東路路 1 號", Age=38 },
                new Person { Name = "香吉士", Address ="桃園市經國路 997 號", Age=21 },
            };            
        }
    }
}
