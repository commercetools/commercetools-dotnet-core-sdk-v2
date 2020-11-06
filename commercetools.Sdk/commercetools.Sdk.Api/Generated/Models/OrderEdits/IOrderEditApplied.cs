using commercetools.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.OrderEditApplied))]
    public partial interface IOrderEditApplied : IOrderEditResult
    {
        DateTime AppliedAt { get; set;}
        
        IOrderExcerpt ExcerptBeforeEdit { get; set;}
        
        IOrderExcerpt ExcerptAfterEdit { get; set;}
    }
}
