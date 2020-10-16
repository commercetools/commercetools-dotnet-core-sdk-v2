using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("order")]
    public partial class OrderResourceIdentifier : ResourceIdentifier
    {
        public OrderResourceIdentifier()
        { 
           this.TypeId = "order";
        }
    }
}
