using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shoper.Data.Models
{
    public class Car
    {
        public int id { set; get; }
        public string name { set; get; }
        public string shortdesc { set; get; }
        public string longdesc { set; get; }
        public string img { set; get; }
        public ushort prace { set; get; }
        public bool isFavourite { set; get; }
        public bool ivailable { set; get; }
        public int categoryID { set; get; }
        public virtual Category Category { set; get; }
    }
}
