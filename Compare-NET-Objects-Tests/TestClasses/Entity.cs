using System;
using System.Collections.Generic;
using System.Text;

namespace KellermanSoftware.CompareNETObjectsTests
{
    public enum Level : int 
    {
        Company,
        Division,
        Department
    }

    [Serializable]
    public class Entity
    {
        private List<Entity> _children = new List<Entity>();

        public string Description
        {
            get;
            set;
        }

        public Level EntityLevel
        {
            get;
            set;
        }

        public Entity Parent
        {
            get;
            set;
        }

        public List<Entity> Children
        {
            get { return _children; }
            set { _children = value; }
        }
    }
}
