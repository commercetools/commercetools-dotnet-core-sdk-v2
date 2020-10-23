using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Me
{
    public interface IMyCustomerAddAddressAction : IMyCustomerUpdateAction
    {
        IAddress Address { get; set;}
    }
}
