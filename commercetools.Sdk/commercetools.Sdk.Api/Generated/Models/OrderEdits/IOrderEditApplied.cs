using commercetools.Sdk.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.OrderEditApplied))]
    public partial interface IOrderEditApplied : IOrderEditResult
    {
        new string Type { get; set; }

        DateTime AppliedAt { get; set; }

        IOrderExcerpt ExcerptBeforeEdit { get; set; }

        IOrderExcerpt ExcerptAfterEdit { get; set; }

    }
}
