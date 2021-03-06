using commercetools.Api.Models.Orders;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderAddPaymentAction))]
    public partial interface IOrderAddPaymentAction : IOrderUpdateAction
    {
        IPaymentResourceIdentifier Payment { get; set;}
    }
}
