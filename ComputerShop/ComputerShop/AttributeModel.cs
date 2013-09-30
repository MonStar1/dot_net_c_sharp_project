using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop
{
    class AttributeModel
    {
        //Оперативная память

        private string memorymodule;//Тип памяти(DD2...)

        public string Memory
        {
            get { return memoremodule; }
            set { memorymodule = value; }
        }

        //Процессор

        private long core;//Количество ядер

        public long Core
        {
            get { return core; }
            set { core = value; }
        }

        private long cache;//Кэш

        public long Cache
        {
            get { return cache; }
            set { cache = value; }
        }

        //Видеокарта

        private long videomemory;//Видеопамять

        public long VideoMemory
        {
            get { return videomemory; }
            set { videomemory = value; }
        }

        private long memoryclock;//Частота памяти

        public long MemoryClock
        {
            get { return memoryclock; }
            set { memoryclock = value; }
        }


        //Блок питания

        private long power;//Мощность

        public long Power
        {
            get { return power; }
            set { power = value; }
        }

        private long numberoffans;//КОличество вентиляторов

        public long NumberOfFans
        {
            get { return numberoffans; }
            set { numberoffans = value; }
        }

        //Монитор

        private long daigonal;//Размер диагонали экрана

        public long Diagonal
        {
            get { return daigonal; }
            set { daigonal = value; }
        }

        private string screenresolution;//Разрешение экрана

        public string ScreenResolution
        {
            get { return screenresolution; }
            set { screenresolution = value; }
        }

        private long screenrefreshrate;//Частота обновления экрана

        public long ScreenRefreshRate
        {
            get { return screenrefreshrate; }
            set { screenrefrashrate = value; }
        }

        //Общие поля

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        private long memory;//Память Мб

        public long Memory
        {
            get { return memory; }
            set { memory = value; }
        }


        private long clockfrequency;//Тактовая частота

        public long ClockFrequency
        {
            get { return clockfrequency; }
            set { clockfrequency = value; }
        }
    }
}
