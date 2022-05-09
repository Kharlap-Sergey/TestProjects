using System.ComponentModel.DataAnnotations.Schema;

namespace CourseWork.Domain.Models
{
    [Table("WAREHOUSES")]
    public class WAREHOUSE
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public int LOCATION_ID { get; set; }

        [ForeignKey("LOCATION_ID")]
        public virtual LOCATION Location { get; set; }
    }
}
