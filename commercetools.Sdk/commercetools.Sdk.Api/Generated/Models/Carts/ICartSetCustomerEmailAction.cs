using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartSetCustomerEmailAction))]
    public partial interface ICartSetCustomerEmailAction : ICartUpdateAction
    {
        string Email { get; set;}
    }
}
