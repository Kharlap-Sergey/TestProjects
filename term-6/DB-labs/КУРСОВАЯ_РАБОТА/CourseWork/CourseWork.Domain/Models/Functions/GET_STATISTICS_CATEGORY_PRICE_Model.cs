namespace CourseWork.Domain.Models.Functions
{
    public class GET_STATISTICS_CATEGORY_PRICE_Model
    {
        //CATEGORY_ID, CATEGORY, SUM(COUNT* PRICE) AS TOTAL_SUM

        public int CATEGORY_ID { get; set; }
        public string CATEGORY { get; set; }
        public decimal TOTAL_SUM { get; set; }
    }
}
