using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartSetLineItemTaxAmountAction))]
    public partial interface ICartSetLineItemTaxAmountAction : ICartUpdateAction
    {
        string LineItemId { get; set;}
        
        IExternalTaxAmountDraft ExternalTaxAmount { get; set;}
    }
}
