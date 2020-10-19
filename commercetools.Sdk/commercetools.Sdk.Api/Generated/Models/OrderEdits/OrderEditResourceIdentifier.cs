using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("order-edit")]
    public partial class OrderEditResourceIdentifier : ResourceIdentifier
    {
        public OrderEditResourceIdentifier()
        { 
           this.TypeId = "order-edit";
        }
    }
}
