using commercetools.Api.Generated.Models.Carts;
using commercetools.Api.Generated.Models.CustomerGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Carts
{
    public interface ICartSetCustomerGroupAction : ICartUpdateAction
    {
        ICustomerGroupResourceIdentifier CustomerGroup { get; set;}
    }
}
