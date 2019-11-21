using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BabyShop.Models.BabyShop
{
    public partial class Supplier
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}