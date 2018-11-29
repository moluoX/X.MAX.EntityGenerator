using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace X.MAX.EntityGenerator.Domain.Entity
{
    [Table("USER_COL_COMMENTS")]
    public class UserColumnComment
    {
        public string TABLE_NAME { get; set; }
        public string COLUMN_NAME { get; set; }
        public string COMMENTS { get; set; }
    }
}
