using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartAddPaymentAction))]
    public partial interface ICartAddPaymentAction : ICartUpdateAction
    {
        IPaymentResourceIdentifier Payment { get; set; }

    }
}
