using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace X.MAX.EntityGenerator.Domain.Entity
{
    [Table("USER_TABLES")]
    public class UserTable
    {
        [Key]
        public string TABLE_NAME { get; set; }
    }
}
