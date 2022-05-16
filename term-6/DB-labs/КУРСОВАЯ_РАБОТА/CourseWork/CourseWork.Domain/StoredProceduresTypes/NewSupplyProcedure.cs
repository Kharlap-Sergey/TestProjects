using EntityFrameworkExtras.EF5;

namespace CourseWork.Domain.StoredProceduresTypes
{
    [StoredProcedure("NEW_SUPPLY")]
    public class NewSupplyProcedure : BaseHistoryEvent
    {
    }
}
