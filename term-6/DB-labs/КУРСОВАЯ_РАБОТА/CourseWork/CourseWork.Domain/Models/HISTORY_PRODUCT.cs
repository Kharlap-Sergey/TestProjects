using System.ComponentModel.DataAnnotations.Schema;

namespace CourseWork.Domain.Models
{
    [Table("HISTORY_PRODUCT")]
    public class HISTORY_PRODUCT
    {
        public int HISTORY_ID { get; set; }

        [ForeignKey("HISTORY_ID")]
        public virtual HISTORY History { get; set; }
        public int PRODUCT_ID { get; set; }

        [ForeignKey("PRODUCT_ID")]
        public virtual PRODUCT Product { get; set; }
        public int WAREHOUSE_ID { get; set; }
        [ForeignKey("WAREHOUSE_ID")]
        public virtual WAREHOUSE Warehouse { get; set; }
        public int COUNT { get; set; }
    }
}
