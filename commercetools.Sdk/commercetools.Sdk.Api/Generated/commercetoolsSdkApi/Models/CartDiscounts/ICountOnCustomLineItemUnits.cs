using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CountOnCustomLineItemUnits))]
    public partial interface ICountOnCustomLineItemUnits : IPatternComponent
    {
        string Predicate { get; set; }

        int? MinCount { get; set; }

        int? MaxCount { get; set; }

        [ObsoleteAttribute("This property is obsolete", false)]
        int? ExcludeCount { get; set; }

    }
}
