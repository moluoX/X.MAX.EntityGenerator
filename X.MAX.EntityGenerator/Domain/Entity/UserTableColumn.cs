using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace X.MAX.EntityGenerator.Domain.Entity
{
    [Table("USER_TAB_COLUMNS")]
    public class UserTableColumn
    {
        public string TABLE_NAME { get; set; }
        public string COLUMN_NAME { get; set; }
        public string DATA_TYPE { get; set; }
        public decimal? DATA_LENGTH { get; set; }
        public string NULLABLE { get; set; }
        public decimal? COLUMN_ID { get; set; }
    }
}
