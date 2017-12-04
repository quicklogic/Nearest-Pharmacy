using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nearest_Pharmacy.Models
{
    public class MenuModel
    {
        public string Item { get; set; }

        public MenuModel(string item)
        {
            Item = item;
        }
    }
}
