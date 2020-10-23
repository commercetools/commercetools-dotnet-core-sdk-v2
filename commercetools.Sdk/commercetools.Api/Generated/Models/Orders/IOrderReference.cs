using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Orders
{
    public interface IOrderReference : IReference
    {
        IOrder Obj { get; set;}
    }
}
