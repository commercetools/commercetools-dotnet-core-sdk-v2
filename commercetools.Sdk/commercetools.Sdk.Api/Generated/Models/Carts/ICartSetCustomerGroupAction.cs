using commercetools.Api.Models.Carts;
using commercetools.Api.Models.CustomerGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartSetCustomerGroupAction))]
    public partial interface ICartSetCustomerGroupAction : ICartUpdateAction
    {
        ICustomerGroupResourceIdentifier CustomerGroup { get; set;}
    }
}
