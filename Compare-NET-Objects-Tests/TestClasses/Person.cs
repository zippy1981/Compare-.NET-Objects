using System;
using System.Collections.Generic;
using System.Text;

namespace KellermanSoftware.CompareNETObjectsTests
{
    [Serializable]
    public class Person
    {
        public DateTime DateCreated;

        public string Name
        {
            get;
            set;
        }
    }
}
