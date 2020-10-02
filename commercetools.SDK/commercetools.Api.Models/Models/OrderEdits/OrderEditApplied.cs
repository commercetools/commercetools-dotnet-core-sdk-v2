using commercetools.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("Applied")]
    public partial class OrderEditApplied : OrderEditResult
    {
        public DateTime AppliedAt { get; set;}
        
        public OrderExcerpt ExcerptBeforeEdit { get; set;}
        
        public OrderExcerpt ExcerptAfterEdit { get; set;}
        public OrderEditApplied()
        { 
           this.Type = "Applied";
        }
    }
}
