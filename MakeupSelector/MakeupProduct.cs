using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeupSelector
{
    class MakeupProduct
    {
        [PrimaryKey]
        public int id { get; set; }
        public String brand { get; set; }
        public String name { get; set; }
        public String image_link { get; set; }
        public String product_link { get; set; }

    }
}
