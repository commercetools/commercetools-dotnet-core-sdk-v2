using commercetools.Api.Models.OrderEdits;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.OrderEditAddStagedActionAction))]
    public interface IOrderEditAddStagedActionAction : IOrderEditUpdateAction
    {
        IStagedOrderUpdateAction StagedAction { get; set;}
    }
}
