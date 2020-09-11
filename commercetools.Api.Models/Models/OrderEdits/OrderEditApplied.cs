using commercetools.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.OrderEdits
{
    public class OrderEditApplied : OrderEditResult
    {
        public DateTime AppliedAt { get; set;}
        
        public OrderExcerpt ExcerptBeforeEdit { get; set;}
        
        public OrderExcerpt ExcerptAfterEdit { get; set;}
    }
}
