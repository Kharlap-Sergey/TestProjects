using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseWork.Domain.Models
{
    [Table("HISTORIES")]
    public class HISTORY
    {
        public int ID { get; set; }
        public DateTime DATE { get; set; }
        public int HISTORY_TYPE_ID { get; set; }
        [ForeignKey("HISTORY_TYPE_ID")]
        public virtual HISTORY_TYPE HistoryType { get; set; }

        public virtual List<HISTORY_PRODUCT> HistoryProducts { get; set; }
    }
}
