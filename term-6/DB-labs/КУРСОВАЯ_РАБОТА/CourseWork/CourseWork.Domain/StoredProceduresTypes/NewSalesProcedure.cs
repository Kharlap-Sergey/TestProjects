using EntityFrameworkExtras.EF5;

namespace CourseWork.Domain.StoredProceduresTypes
{
    [StoredProcedure("NEW_SALE")]
    public class NewSalesProcedure : BaseHistoryEvent
    {
    }
}
