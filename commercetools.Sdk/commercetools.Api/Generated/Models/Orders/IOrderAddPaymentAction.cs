using commercetools.Api.Generated.Models.Orders;
using commercetools.Api.Generated.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Orders
{
    public interface IOrderAddPaymentAction : IOrderUpdateAction
    {
        IPaymentResourceIdentifier Payment { get; set;}
    }
}
