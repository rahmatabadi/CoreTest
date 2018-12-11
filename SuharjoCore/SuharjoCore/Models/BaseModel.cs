using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuharjoCore.Models
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; }
        public DateTime Createdate { get; set; }
        public DateTime Updatedate { get; set; }
        public DateTime Deletedate { get; set; }
    }
}
