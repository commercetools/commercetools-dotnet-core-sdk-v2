using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.OrderEditApplied))]
    public partial interface IOrderEditApplied : IOrderEditResult
    {
        DateTime AppliedAt { get; set; }

        IOrderExcerpt ExcerptBeforeEdit { get; set; }

        IOrderExcerpt ExcerptAfterEdit { get; set; }
    }
}
