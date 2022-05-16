using EntityFrameworkExtras.EF5;

namespace CourseWork.Domain.StoredProceduresTypes
{
    [UserDefinedTableType("PRODUCT_LIST_TYPE")]
    public class ProductListType
    {
        [UserDefinedTableTypeColumn(1)]
        public int ProductId { get; set; }

        [UserDefinedTableTypeColumn(2)]
        public int Amount { get; set; }

    }
}
