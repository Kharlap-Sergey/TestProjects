using System.ComponentModel.DataAnnotations.Schema;

namespace CourseWork.Domain.Models
{
    [Table("LOCATIONS")]
    public class LOCATION
    {
        public int ID { get; set; }
        public string COUNTRY_CODE { get; set; }
        public string LOCATION_1 { get; set; }
        public string LOCATION_2 { get; set; }
        public string LOCATION_3 { get; set; }
        public string LOCATION_4 { get; set; }
    }
}
