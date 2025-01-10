using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AutoDoc
{
    public static class SharedData
    {
        private static string _uName;

        public static string uName
        {
            get { return _uName; }
            set
            {
                _uName = value;
            }
        }
    }
}
