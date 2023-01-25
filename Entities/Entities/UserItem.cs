using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class UserItem
    {
        public UserItem() { }
        public int Id { get; set; }
        public Guid IdWeb { get; set; }
        public string DNI { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsActive { get; private set; }
        private string Password { get; set; }
        private string EncryptedPassword { get; set; }
    }
}

