using commercetools.Api.Models.Common;
using commercetools.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("order-edit")]
    public partial class OrderEditReference : Reference
    {
        public OrderEdit Obj { get; set;}
        public OrderEditReference()
        { 
           this.TypeId = "order-edit";
        }
    }
}
