using System.ComponentModel.DataAnnotations.Schema;

namespace CourseWork.Domain.Models
{
    [Table("HISTORY_TYPEs")]
    public class HISTORY_TYPE
    {
        public int ID { get; set; }
        public string NAME{ get; set; }
    }
}
