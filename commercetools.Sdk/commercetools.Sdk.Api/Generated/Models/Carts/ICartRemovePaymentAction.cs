using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartRemovePaymentAction))]
    public interface ICartRemovePaymentAction : ICartUpdateAction
    {
        IPaymentResourceIdentifier Payment { get; set;}
    }
}
