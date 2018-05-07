using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine2
{
    interface IProducts
    {
         string Name { get; set; }
         string Info { get; set; }
         int Price { get; set; }
        
    }

}
