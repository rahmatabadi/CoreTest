using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SuharjoCore.Models
{
    public class Item:BaseModel

    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }

}
