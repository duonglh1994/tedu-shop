using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
   public interface IAuditable
    {
        DateTime CreatDate { get; set; }
        string CreateBy { get; set; }
        DateTime? UpdateDate { get; set; }
        string UpdateBy { get; set; }
    }
}
