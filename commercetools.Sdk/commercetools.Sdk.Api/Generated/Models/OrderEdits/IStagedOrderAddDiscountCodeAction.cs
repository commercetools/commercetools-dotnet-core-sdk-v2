using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderAddDiscountCodeAction))]
    public partial interface IStagedOrderAddDiscountCodeAction : IStagedOrderUpdateAction
    {
        string Code { get; set;}
    }
}
