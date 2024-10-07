using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.FacetTerm))]
    public partial interface IFacetTerm
    {
        Object Term { get; set; }

        long Count { get; set; }

        long? ProductCount { get; set; }

    }
}
