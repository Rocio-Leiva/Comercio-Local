using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class BuyerItem : UserItem
    {
        public BuyerItem()
        {
            IsActive = true;
        }
        public bool IsActive { get; private set; }
        //public int IdUser { get; set; }
        public string UserName { get; set; }
        public int OrderNum { get; set; }
        public string Adress { get; set; }
    }
}
