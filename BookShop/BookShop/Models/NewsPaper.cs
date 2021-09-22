using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Models { 
    
        public class NewsPaper : Publication
        {
            public DateTime Date { get; set; }
            public int Pages { get; set; }
        }
    
}
