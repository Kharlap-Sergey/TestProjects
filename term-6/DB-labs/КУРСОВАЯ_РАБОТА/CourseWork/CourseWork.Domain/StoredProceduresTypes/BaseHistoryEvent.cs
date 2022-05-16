using System;
using System.Collections.Generic;
using System.Data;
using EntityFrameworkExtras.EF5;

namespace CourseWork.Domain.StoredProceduresTypes
{
    public class BaseHistoryEvent
    {
        //@PRODUCT_ITEMS PRODUCT_LIST_TYPE READONLY,
        [StoredProcedureParameter(SqlDbType.Udt, ParameterName = "PRODUCT_ITEMS")]
        public List<ProductListType> SelectedProducts { get; set; }
        //    @WAREHOUSE_ID INT,
        [StoredProcedureParameter(SqlDbType.Int, ParameterName = "WAREHOUSE_ID")]
        public int WarehouseId { get; set; }
        //@DATE DATETIME,
        [StoredProcedureParameter(SqlDbType.DateTime, ParameterName = "DATE")]
        public DateTime Date { get; set; }
    }
}
