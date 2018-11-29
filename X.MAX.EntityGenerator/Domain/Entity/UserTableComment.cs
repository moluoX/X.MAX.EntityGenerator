using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace X.MAX.EntityGenerator.Domain.Entity
{
    [Table("USER_TAB_COMMENTS")]
    public class UserTableComment
    {
        [Key]
        public string TABLE_NAME { get; set; }
        public string TABLE_TYPE { get; set; }
        public string COMMENTS { get; set; }
    }
}
