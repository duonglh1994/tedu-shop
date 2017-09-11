using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Model.Models;

namespace TeduShop.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        public DateTime CreatDate { get; set; }
        [MaxLength(256)]
        public string CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        [MaxLength(256)]
        public string UpdateBy { get; set; }
    }
}
}
