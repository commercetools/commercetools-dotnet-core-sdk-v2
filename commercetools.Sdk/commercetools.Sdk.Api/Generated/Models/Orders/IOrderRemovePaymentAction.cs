using commercetools.Api.Models.Orders;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderRemovePaymentAction))]
    public partial interface IOrderRemovePaymentAction : IOrderUpdateAction
    {
        IPaymentResourceIdentifier Payment { get; set; }
    }
}
