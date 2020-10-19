using commercetools.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("NotProcessed")]
    public partial class OrderEditNotProcessed : OrderEditResult
    {
        public OrderEditNotProcessed()
        { 
           this.Type = "NotProcessed";
        }
    }
}
