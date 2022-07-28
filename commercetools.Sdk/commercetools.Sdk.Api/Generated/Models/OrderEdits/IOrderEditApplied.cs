using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.OrderEditApplied))]
    public partial interface IOrderEditApplied : IOrderEditResult
    {
        DateTime AppliedAt { get; set; }

        IOrderExcerpt ExcerptBeforeEdit { get; set; }

        IOrderExcerpt ExcerptAfterEdit { get; set; }

    }
}
