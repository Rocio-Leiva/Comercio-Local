using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class AdminItem : UserItem
    {
        public AdminItem()
        {
            IsActive = true;
        }
        public bool IsActive { get; private set; }
        public int CompanyNum { get; set; }
        public string UserName { get; set; }
    }
}
