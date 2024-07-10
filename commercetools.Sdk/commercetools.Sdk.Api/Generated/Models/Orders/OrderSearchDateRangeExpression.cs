using commercetools.Sdk.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderSearchDateRangeExpression : IOrderSearchDateRangeExpression
    {
        public IOrderSearchDateRangeValue Range { get; set; }
    }
}
