using System.Collections.Generic;

namespace Fill_Up_.Fill_Up_
{
    class MapFactory
    {
        private List<IMap> mapList;

        public MapFactory()
        {
            this.mapList = new List<IMap>();
        }

        public void AddNewMap(IMap map)
        {
            this.mapList.Add(map);
        }

        public List<IMap> GetMapList()
        {
            return mapList;
        }

        public string GetUrl(string name)
        {
            foreach(IMap m in mapList)
            {
                if (m.Name == name)
                    return m.Url;
            }
            return null;
        }
    }
}
