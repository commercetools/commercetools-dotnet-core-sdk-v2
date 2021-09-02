using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartSetCustomLineItemShippingDetailsAction))]
    public partial interface ICartSetCustomLineItemShippingDetailsAction : ICartUpdateAction
    {
        string CustomLineItemId { get; set; }

        IItemShippingDetailsDraft ShippingDetails { get; set; }
    }
}
